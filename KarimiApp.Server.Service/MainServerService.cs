using KarimiApp.Model;
using KarimiApp.Server.Repository;
using KarimiApp.Server.Repository.Repository;
using KarimiApp.Server.Api;
using KarimiApp.Workstation.ModelFactory;
using KarimiApp.Workstation.Server.Repository.Interface;
using Newtonsoft.Json;
using ServerService;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;
using ArvinWorkstation = Arvin.Net.Workstation;

namespace KarimiApp.Server.Service
{
    public partial class MainServerService : ServiceBase
    {
        private HttpSelfHostServer _server;
        private ModelFactory modelFactory;
        private List<ArvinWorkstation> workstations;
        private UnitOfWork unitOfWork;
        private IWorkstationServer workstationServer;
        private readonly HttpSelfHostConfiguration _config;
        public const string ServiceAddress = "http://localhost:4321";
        public MainServerService()
        {
            unitOfWork = new UnitOfWork();
            this.modelFactory = new ModelFactory();
            _config = new HttpSelfHostConfiguration(ServiceAddress);
            KarimiApp.Server.Api.MyApiConfig.RegisterSelfHost(_config);
            _config.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            _config.DependencyResolver = new OverriddenWebApiDependencyResolver(_config.DependencyResolver).Add(
             typeof(WorkstationServerController),
            () => new WorkstationServerController(this.workstations));
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                this.workstations = new List<ArvinWorkstation>();
                this.WsProccess();

                _server = new HttpSelfHostServer(_config);
                _server.OpenAsync();
            }
            catch (Exception e)
            {

                System.IO.File.WriteAllText("d://errorlog.txt", e.Message);
            }
        }
        private void WsProccess()
        {
            // netReceiptHeader header = JsonConvert.DeserializeObject<netReceiptHeader>(System.IO.File.ReadAllText("d://detail.txt"));
            // netReceiptDetail detail = JsonConvert.DeserializeObject<netReceiptDetail>(System.IO.File.ReadAllText("d://h.txt"));
            //  ReceiptModel tmpReciept = this.modelFactory.Reciept.ToDb(header, new netReceiptDetail[] { detail });
            //  this.unitOfWork.Workstation.InsertReceipt(tmpReciept);
            List<WorkstationModel> tmplist = unitOfWork.Workstation.List();
            System.IO.File.WriteAllText("d://count.txt", tmplist.Count.ToString());
            try
            {
                tmplist.ForEach(x => this.WorkstationDbToArvin(x));
                System.IO.File.WriteAllText("d://wslog.txt", workstations[0].FullAddress + workstations[0].WorkstationStatus + "," + workstations[1].FullAddress + workstations[1].WorkstationStatus);
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText("d://wslog.txt", e.Message);
            }
            workstationServer = new WorkstationServerRepository(this.workstations);
        }

        private void WorkstationDbToArvin(WorkstationModel item)
        {
            ArvinWorkstation workstation = new ArvinWorkstation();
            workstation.Start(item.IpAddress, Convert.ToInt32(item.PortNumber));
            workstation.StartReadingInvoice();
            workstation.InvoiceReceived += Workstation_InvoiceReceived;
            this.workstations.Add(workstation);
        }

        private void Workstation_InvoiceReceived(ArvinWorkstation ws, Arvin.Model.netReceiptHeader header, IList<Arvin.Model.netReceiptDetail> receiptDetail, int lastReceiptNo)
        {
            // System.IO.File.WriteAllText(@"C://recieptdetail.txt", ws.IPAddress + receiptDetail.Count.ToString());
            System.IO.File.WriteAllText(@"d://rheader.txt", JsonConvert.SerializeObject(header));
            System.IO.File.WriteAllText(@"d://rdetail.txt", JsonConvert.SerializeObject(receiptDetail));
            try
            {
                ReceiptModel tmpReciept = this.modelFactory.Reciept.ToDb(header, receiptDetail);
                System.IO.File.WriteAllText(@"d://d.txt", JsonConvert.SerializeObject(tmpReciept));
                System.IO.File.WriteAllText(@"d://rdm.txt", JsonConvert.SerializeObject(tmpReciept));
                this.workstationServer.InsertReceipt(tmpReciept);
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText("c://errorlog.txt", e.Message + e.StackTrace + e.Source);
            }

        }

        protected override void OnStop()
        {

        }
    }
}

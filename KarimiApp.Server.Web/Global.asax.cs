using KarimiApp.Model;
using KarimiApp.Server.Api;
using KarimiApp.Server.Repository;
using KarimiApp.Server.Repository.Repository;
using KarimiApp.Server.Web.App_Start;
using KarimiApp.Workstation.ModelFactory;
using KarimiApp.Workstation.Server.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ArvinWorkstation = Arvin.Net.Workstation;

namespace KarimiApp.Server.Web
{
    public class Global : HttpApplication
    {
        private HttpConfiguration httpConfiguration;
        private ModelFactory modelFactory;
        private List<ArvinWorkstation> workstations;
        private UnitOfWork unitOfWork;
        private IWorkstationServer workstationServer;
        void Application_Start(object sender, EventArgs e)
        {
            this.modelFactory = new ModelFactory();
            this.workstations = new List<ArvinWorkstation>();


            HttpConfiguration http = GlobalConfiguration.Configuration;
            http.DependencyResolver = new OverriddenWebApiDependencyResolver(http.DependencyResolver).Add(
             typeof(WorkstationServerController),
            () => new WorkstationServerController(this.workstations));
            unitOfWork = new UnitOfWork();
            // unitOfWork = new UnitOfWork(new List<ArvinWorkstation>());
            WsProccess();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            
            
            // Code that runs on application startup
           // RouteConfig.RegisterRoutes(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();

            // RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
        private void WsProccess()
        {
            this.workstationServer = new WorkstationServerRepository(this.workstations);
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
            //  System.IO.File.WriteAllText(@"d://rheader.txt", JsonConvert.SerializeObject(header));
            //  System.IO.File.WriteAllText(@"d://rdetail.txt", JsonConvert.SerializeObject(receiptDetail));
            try
            {
              //  Arvin.Model.netReceiptHeader h = JsonConvert.DeserializeObject<Arvin.Model.netReceiptHeader>(System.IO.File.ReadAllText(@"C:\rheader.txt"));
               // List<Arvin.Model.netReceiptDetail> d= JsonConvert.DeserializeObject<List<Arvin.Model.netReceiptDetail>>(System.IO.File.ReadAllText(@"C:\rdetail.txt"));
                //  string g = "غرفه آجیل";
                //  int t4 = h.Gorfeh_name.Length;
                //  List<char> tm = h.Gorfeh_name.ToList();
                //  List<char> ts = g.ToList();
                //  int i = 0;
                //  foreach (char item in tm)
                //  {


                //      bool x = item.Equals(ts[i]);
                //      i++;
                //  }
                //  List<char> g1 = "غرفه آجیل".ToList();
                //  List<char> g2 = "غرفه آجیل".ToList();
                //  List<char> g3 = "غرفه آجيل".ToList();
                //  int t5 = "غرفه آجیل".Length;
                //  bool tr3 = string.Equals("1", "1");
              ReceiptModel tmpReciept = this.modelFactory.Reciept.ToDb(header, receiptDetail);
              //bool tr=  string.Equals(h.Gorfeh_name.Trim(), "غرفه آجیل");
               // ReceiptModel tmpReciept = this.modelFactory.Reciept.ToDb(h, d);
                //  System.IO.File.WriteAllText(@"d://d.txt", JsonConvert.SerializeObject(tmpReciept));
                //   System.IO.File.WriteAllText(@"d://rdm.txt", JsonConvert.SerializeObject(tmpReciept));
                this.workstationServer.InsertReceipt(tmpReciept);
            }
            catch (Exception e)
            {
                System.IO.File.WriteAllText("c://errorlog.txt", e.Message + e.StackTrace + e.Source);
            }

        }
    }
}
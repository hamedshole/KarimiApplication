using Arvin.Net;
using KarimiApp.Model;
using KarimiApp.Workstation.ModelFactory;
using KarimiApp.Workstation.Server.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ArvinWorkstation = Arvin.Net.Workstation;
using Plu = Arvin.Model.netPLU;



namespace KarimiApp.Server.Repository.Repository
{
    public class WorkstationServerRepository : IWorkstationServer
    {
        private List<ArvinWorkstation> loadedlist;
        private ModelFactory factory;
        private UnitOfWork unitOfWork;

        public WorkstationServerRepository(List<ArvinWorkstation> loadedlist)
        {
            this.loadedlist = loadedlist;
            factory = new ModelFactory();
            unitOfWork = new UnitOfWork();
        }

        string IWorkstationServer.InsertReceipt(ReceiptModel receipt)
        {
   
            return unitOfWork.Receipt.Insert(receipt);
        }

        string IWorkstationServer.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            try
            {
               // List<HardwareKeyModel> d = JsonConvert.DeserializeObject<List<HardwareKeyModel>>(workstationHardKey.HardKeyString);
                ArvinWorkstation tmp = this.loadedlist.Find(x => x.IPAddress == workstationHardKey.IpAddress);
                CommandResult cr = new CommandResult();
               // List<int> keys = this.factory.HardKey.HardKeyToNet(d);
                tmp.StopReadingInvoice();
                tmp.SendEnableMemoryMap();
                List<int> keys = new List<int>();
                foreach (var item in workstationHardKey.HardKeys)
                {
                    if (item == null)
                    {
                        keys.Add(0);
                    }
                    else
                    {
                        keys.Add( item.Item.Memory);
                    }
                    
                }
                cr = tmp.SendMemoryMap(keys);
                List<int> keysint = new List<int>();
                foreach (var item in workstationHardKey.HardKeys)
                {
                    if (item != null)
                    {
                        keysint.Add(item.Item.Memory);
                    }
                    else
                    {
                        keysint.Add(0);
                    }
                }
                cr = tmp.SendMemoryMap(keysint);
                tmp.StartReadingInvoice();
                if (cr.ToString() == "OK")
                {
                    string s= unitOfWork.HardWarekey.Delete(new HardwareKeyModel(workstationHardKey.IpAddress));
                    foreach (var hardkey in workstationHardKey.HardKeys)
                    {
                       // int index = 0;
                        //if (hardkey != null)
                        //{
                        //    unitOfWork.HardWarekey.Insert(new HardwareKeyModel(workstation: workstationHardKey.Workstation, key: index, item: new ItemModel { Memory=0}));
                        //}
                        if(hardkey!=null)
                        {
                            unitOfWork.HardWarekey.Insert(hardkey);
                        }
                      //  index++;
                    }
                      //workstationHardKey.HardKeys.(x => unitOfWork.HardWarekey.Insert(x));
                }


                return "h";
              //  return workstationHardKey.HardKeys[0].Plu.Id.ToString() + workstationHardKey.HardKeys[1].Plu.Id.ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        string IWorkstationServer.SendMessage(WorkStationMessageModel workStationMessage)
        {
            try
            {
                ArvinWorkstation tmp = this.loadedlist.Find(x => x.IPAddress == workStationMessage.Ip);
                CommandResult cr = new CommandResult();
                if (tmp.WorkstationStatus != WorkstationStatus.Unavailable)
                {
                    tmp.StopReadingInvoice();
                    cr = tmp.SendMessage(workStationMessage.Message, workStationMessage.Title, workStationMessage.Duration, workStationMessage.CloseByKey, workStationMessage.Beep);
                    tmp.StartReadingInvoice();
                }
                return cr.ToString() + " " + tmp.WorkstationStatus + " " + tmp.IPAddress.ToString() + workStationMessage.Ip;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        string IWorkstationServer.SendPlu(WorkstationPluModel workstationPlu)
        {
            try
            {
                ArvinWorkstation tmpws = this.loadedlist.Find(x => x.IPAddress == workstationPlu.Ip);
                tmpws.StopReadingInvoice();
                CommandResult cr = new CommandResult();
                int count = 0;
                CommandResult res=new CommandResult();
                if (tmpws.WorkstationStatus != WorkstationStatus.Unavailable)
                {
                    tmpws.StopReadingInvoice();
                    List<ItemModel> items = this.unitOfWork.Item.List();
                    List<Plu> tmp = this.factory.Plu.ItemToArvinPlu(workstationPlu.Items);
                    List<Plu> tmpPlus = this.factory.Plu.ItemToArvinPlu(items);
                    res = tmpws.SendPLUAll(tmpPlus,out count);
                }
                tmpws.StartReadingInvoice();
            //    if (res.ToString() == "OK")
            //    {
                    //  Task task = this.InsertPlus(workstationPlu.Plus);
             //       await Task.Run(() => this.InsertPlus(workstationPlu.Plus));
                  // await this.InsertPlus(workstationPlu.Plus).ConfigureAwait(false);
                   // Task.Factory.StartNew(() => this.InsertPlus(workstationPlu.Plus).GetAwaiter());
                   // await this.InsertPlus(workstationPlu.Plus).ConfigureAwait(false);
                    //Task.Run(async () => await this.InsertPlus(workstationPlu.Plus).ConfigureAwait(false));
                    //unitOfWork.Plu.Delete(new PluModel(workstation: workstationPlu.Plus[0].Workstation));
                   // workstationPlu.Plus.ForEach(x => unitOfWork.Plu.Insert(x));
              //  }
                return res.ToString()+"\n"+ cr.ToString() + "\n" + count.ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        private async Task InsertPlus(List<PluModel> plus)
        {
            unitOfWork.Plu.Delete(new PluModel(workstation: plus[0].Workstation));
            foreach (var item in plus)
            {
                await Task.Run(() => { this.unitOfWork.Plu.Insert(item); }).ConfigureAwait(false);
            }
            // plus.ForEach(x =>await Task.Run(async()=> unitOfWork.Plu.Insert(x)));
        }
        long IWorkstationServer.TotalReceiptAmount(string workstation)
        {
            return unitOfWork.Workstation.TotalReceiptAmount(workstation);
        }

        long IWorkstationServer.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return unitOfWork.Workstation.TotalReceiptAmountForDate(receipt);
        }

        int IWorkstationServer.TotalReceiptCount(string workstation)
        {
            return unitOfWork.Workstation.TotalReceiptCount(workstation);
        }

        int IWorkstationServer.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return unitOfWork.Workstation.TotalReceiptCountForDate(receipt);
        }

        List<WorkstationModel> IWorkstationServer.WorkstationList()
        {
            var list = unitOfWork.Workstation.List();
            return list;
        }
    }
}

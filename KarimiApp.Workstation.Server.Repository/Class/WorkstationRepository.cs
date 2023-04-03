using Arvin.Net;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.Workstation.Server.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using ArvinWorkstation = Arvin.Net.Workstation;
using Plu = Arvin.Model.netPLU;

namespace KarimiApp.Workstation.Server.Repository.Class
{
    internal class WorkstationRepository : IWorkstation
    {
        private List<ArvinWorkstation> loadedlist;
        private ModelFactory.ModelFactory factory;
        private UnitOfWork unitOfWork;

        public WorkstationRepository(List<ArvinWorkstation> loadedlist)
        {
            this.loadedlist = loadedlist;
            factory = new ModelFactory.ModelFactory();
            unitOfWork = new UnitOfWork();
        }

        string IWorkstation.InsertReceipt(ReceiptModel receipt)
        {
            return unitOfWork.Receipt.Insert(receipt);
        }

        string IWorkstation.SendHardKey(WorkstationHardKeyModel workstationHardKey)
        {
            try
            {
                ArvinWorkstation tmp = this.loadedlist.Find(x => x.IPAddress == workstationHardKey.IpAddress);
                CommandResult cr = new CommandResult();
               // List<int> keys = this.factory.HardKey.HardKeyToNet(workstationHardKey.HardKeys);
                tmp.StopReadingInvoice();
                tmp.SendEnableMemoryMap();
             //   cr = tmp.SendMemoryMap(workstationHardKey.HardKeys.ToList());
                tmp.StartReadingInvoice();
                // unitOfWork.HardKey.Delete(new HardwareKeyModel(workstationHardKey.HardKeys[0].Plu.Workstation));
                // workstationHardKey.HardKeys.ForEach(x => unitOfWork.HardKey.Create(x));

                return "h";
               // return workstationHardKey.HardKeys[0].Plu.Id.ToString() + workstationHardKey.HardKeys[1].Plu.Id.ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        string IWorkstation.SendMessage(WorkStationMessageModel workStationMessage)
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

        string IWorkstation.SendPlu(WorkstationPluModel workstationPlu)
        {
            try
            {
                ArvinWorkstation tmpws = this.loadedlist.Find(x => x.IPAddress == workstationPlu.Ip);
                List<ItemModel> items = this.unitOfWork.Item.List();
                tmpws.StopReadingInvoice();
                CommandResult cr = new CommandResult();
                int count = 0;
                if (tmpws.WorkstationStatus != WorkstationStatus.Unavailable)
                {
                    tmpws.StopReadingInvoice();
                    List<Plu> tmpPlus = this.factory.Plu.ItemToArvinPlu(items);
                    cr = tmpws.SendPLUAll(tmpPlus, out count);
                }
                tmpws.StartReadingInvoice();
              //  unitOfWork.Plu.Delete(new PluModel(workstation:workstationPlu.Plus[0].Workstation));
              //  workstationPlu.Plus.ForEach(x => unitOfWork.Plu.Create(x));
                return cr.ToString() + "\n" + count.ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        long IWorkstation.TotalReceiptAmount(string workstation)
        {
            return unitOfWork.Workstation.TotalReceiptAmount(workstation);
        }

        long IWorkstation.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            return unitOfWork.Workstation.TotalReceiptAmountForDate(receipt);
        }

        int IWorkstation.TotalReceiptCount(string workstation)
        {
            return unitOfWork.Workstation.TotalReceiptCount(workstation);
        }

        int IWorkstation.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            return unitOfWork.Workstation.TotalReceiptCountForDate(receipt);
        }

        List<WorkstationModel> IWorkstation.WorkstationList()
        {
            var list= unitOfWork.Workstation.List();
            return list;
        }
    }
}

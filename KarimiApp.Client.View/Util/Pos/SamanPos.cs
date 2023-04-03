using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using Newtonsoft.Json;
using SSP1126.PcPos.BaseClasses;
using SSP1126.PcPos.Infrastructure;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Util.Pos
{
    internal class SamanPos : ISamanPos
    {
        private bool lastResult = false;
        private UnitOfWork mainunitOfWork;
        private PrintUnit printUnit;
        private TransactionModel transaction;
        private long discountvalue = 0;
        private string _gridMemoryComboValue = "";
        public SamanPos()
        {
            this.printUnit = new PrintUnit();
            mainunitOfWork = new UnitOfWork();
        }
        public bool PosPurchase(TransactionModel transaction,string gridMemoryComboValue,long discountvalue=0)
        {
            this.transaction = transaction;
            this.discountvalue = discountvalue;
            this._gridMemoryComboValue = gridMemoryComboValue;
            PaymentMethodModel paymentMethod = this.mainunitOfWork.PaymentMethod.Get(transaction.PaymentMethod);
            PcPosFactory pcPos = new PcPosFactory();
            pcPos.PosResultReceived += PcPos_PosResultReceived;
            pcPos.SetCom("COM" + paymentMethod.PosCom.ToString());
            pcPos.Initialization(ResponseLanguage.Persian, 20, AsyncType.Async);
            pcPos.PcStarterPurchase(transaction.TotalValue.ToString(), string.Empty, "", "");
           
            return lastResult;
        }

        

        private void PcPos_PosResultReceived(PosResult posResult)
        {
            if (posResult.ResponseDescription == "عملیات موفق")
            {
                this.lastResult = true;
                CashierMain cashier = (CashierMain)(Application.OpenForms["CashierMain"]);
               string msg= mainunitOfWork.Transaction.Insert(transaction);
                cashier.SetResultMessage(msg);
                this.printUnit.Transaction.Print(transaction,this.discountvalue);
                cashier.ResetTransaction(this._gridMemoryComboValue);
            }
            else
            {
                MessageBox.Show(posResult.ResponseDescription);
            }
            string ress = JsonConvert.SerializeObject(posResult);
            System.IO.File.WriteAllText("posresult.txt", ress);

        }
    }
}

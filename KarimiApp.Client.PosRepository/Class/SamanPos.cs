using KarimiApp.Client.PosRepository.Interface;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using Newtonsoft.Json;
using SSP1126.PcPos.BaseClasses;
using SSP1126.PcPos.Infrastructure;
using KarimiApp.Client.View;
using System.Windows.Forms;

namespace KarimiApp.Client.PosRepository.Class
{
    internal class SamanPos : ISamanPos
    {
        private PcPosFactory samanPcPos;
        private bool lastResult=false;
        private UnitOfWork mainunitOfWork;
        private PrintUnit printUnit;
        private TransactionModel transaction;
        public SamanPos()
        {
            this.printUnit = new PrintUnit();
            mainunitOfWork = new UnitOfWork();
            this.samanPcPos = new PcPosFactory();
        }
        public bool PosPurchase(TransactionModel transaction)
        {
            this.transaction = new TransactionModel();
            PaymentMethodModel paymentMethod = this.mainunitOfWork.PaymentMethod.Get(transaction.PaymentMethod);
            SSP1126.PcPos.BaseClasses.PcPosFactory pcPos = new SSP1126.PcPos.BaseClasses.PcPosFactory();
            pcPos.SetCom("COM" + paymentMethod.PosCom.ToString());
            pcPos.Initialization(SSP1126.PcPos.Infrastructure.ResponseLanguage.Persian, 0, SSP1126.PcPos.Infrastructure.AsyncType.Async);
            pcPos.PcStarterPurchase(transaction.TotalValue.ToString(), string.Empty, "", "");
            pcPos.PosResultReceived += PcPos_PosResultReceived;
            return lastResult;
        }

        private void PcPos_PosResultReceived(PosResult posResult)
        {
            if (posResult.ResponseDescription == "عملیات موفق")
            {
                this.lastResult = true;
                mainunitOfWork.Transaction.Insert(transaction);
                this.printUnit.Transaction.Print(transaction,0);
               // ((CashierMain)(Application.OpenForms["CashierMain"])).ResetTransaction();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("خطا در تراکنش");
            }
            string ress = JsonConvert.SerializeObject(posResult);
            System.IO.File.WriteAllText("posresult.txt", ress);

        }
    }
}

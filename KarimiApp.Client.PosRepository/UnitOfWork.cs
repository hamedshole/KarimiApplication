using KarimiApp.Client.PosRepository.Class;
using KarimiApp.Client.PosRepository.Interface;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System.Windows.Forms;
using KarimiApp.ReportPrintRepository;

namespace KarimiApp.Client.PosRepository
{
    public class PosUnit
    {

        private IMellatPos _MellatPos;
        private ISamanPos _SamanPos;
        private UnitOfWork mainunitOfWork;
        private PrintUnit printUnit;

        public PosUnit()
        {
            this.printUnit = new PrintUnit();
            mainunitOfWork = new UnitOfWork();
            _MellatPos = new MellatPos();
            _SamanPos = new SamanPos();
        }
        private bool Pay(TransactionModel transaction)
        {
            bool result = false;
            PaymentMethodModel paymentMethod = this.mainunitOfWork.PaymentMethod.Get(transaction.PaymentMethod);
            if (paymentMethod.Title == "شتاب سامان") 
            {
               result= _SamanPos.PosPurchase(transaction);
            }
            else if(paymentMethod.Title=="شتاب ملت")
            {
               // _MellatPos.
            }
            return result;
        }
        public void Payment(TransactionModel transaction)
        {
            if (transaction.PaymentMethod != "نقد")
            {
                bool payResult = this.Pay(transaction);
                if (payResult)
                {
                    mainunitOfWork.Transaction.Insert(transaction);
                    this.printUnit.Transaction.Print(transaction,0);
                }
                else
                {
                    MessageBox.Show("خطا در تراکنش");
                }
            }
            else
            {
                mainunitOfWork.Transaction.Insert(transaction);
                this.printUnit.Transaction.Print(transaction,0);
            }
        }
    }
}

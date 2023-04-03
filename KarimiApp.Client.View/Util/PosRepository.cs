using KarimiApp.Client.Repository;
using KarimiApp.Client.View.Util.Pos;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Util
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
        private bool Pay(TransactionModel transaction, string gridMemoryComboValue, long discountvalue = 0)
        {
            bool result = false;
            PaymentMethodModel paymentMethod = this.mainunitOfWork.PaymentMethod.Get(transaction.PaymentMethod);
            if (paymentMethod.Title == "شتاب سامان")
            {
                result = _SamanPos.PosPurchase(transaction, gridMemoryComboValue, discountvalue);
            }
            else if (paymentMethod.Title == "شتاب ملت")
            {
                // _MellatPos.
            }
            return result;
        }
        public void Payment(TransactionModel transaction, string gridMemoryComboValue, long discountvalue = 0)
        {
            if (transaction.PaymentMethod != "نقد")
            {
                this.Pay(transaction, gridMemoryComboValue, discountvalue);
                // if (payResult)
                //  {
                //  mainunitOfWork.Transaction.Insert(transaction);
                // this.printUnit.Transaction.Print(transaction);
                //  }
                //  else
                //  {
                //     MessageBox.Show("خطا در تراکنش");
                // }
            }
            else
            {
                CashierMain cashier = ((CashierMain)Application.OpenForms["CashierMain"]);
             //   System.IO.File.WriteAllText("d://tt.txt", System.IO.File.ReadAllText("d://tt.txt") + DateTime.Now.ToString() + "\n");
                string msg = mainunitOfWork.Transaction.Insert(transaction);
              ////  cashier.SetResultMessage(msg);
                this.printUnit.Transaction.Print(transaction, discountvalue);
               // System.IO.File.WriteAllText("d://tt.txt", System.IO.File.ReadAllText("d://tt.txt") + DateTime.Now.ToString() + "\n");
                cashier.ResetTransaction(gridMemoryComboValue);
            }
        }
    }

    internal class MellatPos : IMellatPos
    {
    }
}

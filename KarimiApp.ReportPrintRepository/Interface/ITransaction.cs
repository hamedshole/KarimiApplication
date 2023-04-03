using KarimiApp.Model;

namespace KarimiApp.ReportPrintRepository.Interface
{
    public interface ITransaction
    {
        void Print( TransactionModel transaction,long discountvalue);
    }
}

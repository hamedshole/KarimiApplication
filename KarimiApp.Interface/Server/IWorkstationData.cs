using KarimiApp.Model;
using System;

namespace KarimiApp.Interface.Server
{
    public interface IWorkstationData
    {
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}

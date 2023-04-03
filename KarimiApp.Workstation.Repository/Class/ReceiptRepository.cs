using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Workstation.Repository.Repository
{
    internal class ReceiptRepository : IReceipt
    {
        IReceiptRepo repository;

        public ReceiptRepository(IReceiptRepo repository)
        {
            this.repository = repository;
        }

        ReceiptModel IReceipt.Get(string barcode)
        {
            ReceiptModel receipt = this.repository.Get(barcode);
            receipt.SetEntries(repository.ReceiptItemsRead(receipt.Id));
            return receipt;
        }

        string IReceipt.Insert(ReceiptModel receipt)
        {
           string msg= repository.Insert(receipt);
            receipt.Entries.ForEach(x => repository.InsertItem(x));
            return msg;
        }

        List<ReceiptModel> IReceipt.List(string workstation)
        {
            throw new NotImplementedException();
        }
    }
}

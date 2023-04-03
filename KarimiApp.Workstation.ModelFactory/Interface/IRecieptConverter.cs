using Arvin.Model;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Workstation.ModelFactory.Interface
{
    public interface IRecieptConverter
    {
        ReceiptModel ToDb(netReceiptHeader receiptHeader, IList<netReceiptDetail> receiptDetails);


    }
}

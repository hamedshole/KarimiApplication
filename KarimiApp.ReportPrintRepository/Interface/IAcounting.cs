using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.ReportPrintRepository.Interface
{
    public interface IAcounting
    {
        /// <summary>
        /// report all of customers with their balance
        /// </summary>
        /// <param name="customers"></param>
        void CustomersReport(List<PersonModel> customers);
        void AllPersons(List<PersonCreditHeaderModel> persons);
        void PersonLog(PersonCreditHeaderModel personCredit);
        void Payouts(List<PayoutTransactionModel> payoutTransactions,DateTime startTime,DateTime endTime,bool printToFile=false);
    }
}

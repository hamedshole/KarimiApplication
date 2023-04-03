using DevExpress.XtraGrid.Views.Printing;
using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IAcountingRepo
    {
        List<PersonCreditHeaderModel> PersonCreditsList();
        PersonCreditHeaderModel PersonCreditGet(PersonModel person);
        List<PersonCreditLogModel> PersonCreditLogRead(string person);
        List<PayoutTransactionModel> PayoutList(DateTime date);
    }
}

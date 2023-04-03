using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IAcounting
    {
         List<PayoutTransactionModel> PayoutList(DateTime date);
        List<PersonCreditHeaderModel> PersonCreditList();
    }
}

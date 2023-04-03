using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{

    public class AcountingRepository:IAcounting
    {
        IAcountingRepo repository;

        public AcountingRepository(IAcountingRepo repository)
        {
            this.repository = repository;
        }

        List<PayoutTransactionModel> IAcounting.PayoutList(DateTime date)
        {
            var res= this.repository.PayoutList(date);
            return res;
        }

        List<PersonCreditHeaderModel> IAcounting.PersonCreditList()
        {
            List<PersonCreditHeaderModel> personCredits = new List<PersonCreditHeaderModel>();
            personCredits = this.repository.PersonCreditsList();
            personCredits.ForEach(x => x.Log = this.repository.PersonCreditLogRead(x.Name));
            return personCredits;
        }

       
    }
}

using KarimiApp.Interface.Server;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Server.Repository.Repository
{
    internal class BatchRepository : IBatch
    {
        IBatchRepo repository;

        public BatchRepository(IBatchRepo repository)
        {
            this.repository = repository;
        }

        string IBatch.Close(BatchModel model)
        {
           string res= this.repository.Close(model);
            model.BankValues.ForEach(x => repository.BankValueInsert(x,register: model.BatchRegister,user: model.BatchUser));
            return res;
        }

        List<BatchModel> IBatch.Getall()
        {
            var list = this.repository.Getall();
            list.ForEach(x => x.BankValues=(repository.GetBankValues(x.Id)));
            return list;
        }
    }
}

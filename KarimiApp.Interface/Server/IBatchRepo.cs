﻿using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Server
{
    public interface IBatchRepo:IBatch

    {
        string BankValueInsert(BankValueModel bankValue, string register, string user);
        List<BankValueModel> GetBankValues(int batchid);
    }
}

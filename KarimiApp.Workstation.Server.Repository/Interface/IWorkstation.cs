﻿using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Workstation.Server.Repository.Interface
{
    public interface IWorkstation
    {
        string SendMessage(WorkStationMessageModel workStationMessage);
        string SendPlu(WorkstationPluModel workstationPlu);
        string SendHardKey(WorkstationHardKeyModel workstationHardKey);
        List<WorkstationModel> WorkstationList();
        string InsertReceipt(ReceiptModel receipt);
        long TotalReceiptAmount(string workstation);
        int TotalReceiptCount(string workstation);
        long TotalReceiptAmountForDate(ReceiptModel receipt);
        int TotalReceiptCountForDate(ReceiptModel receipt);
    }
}

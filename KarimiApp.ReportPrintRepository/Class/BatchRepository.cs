using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository.Interface;
using Stimulsoft.Base.Json;
using Stimulsoft.Report;
using System.Collections.Generic;
using System.Data;

namespace KarimiApp.ReportPrintRepository.Class
{
    class BatchRepository : IBatch
    {
       // private UnitOfWork unitOfWork;

        public BatchRepository()
        {
         //   unitOfWork = new UnitOfWork();
        }

        void IBatch.Print(BatchModel batch)
        {
            string reportfile = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk")).BatchReport;
            StiReport sti = this.SetLicense();
            sti.Load(reportfile);
            this.SetVariables(sti, batch);
           // sti.Design();
            sti.Render();
            sti.Print(false);

        }

        private void SetVariables(StiReport stiReport, BatchModel batch)
        {
            stiReport.Dictionary.Variables.Add("user", batch.BatchUser);
            stiReport.Dictionary.Variables.Add("register", batch.BatchRegister);
            stiReport.Dictionary.Variables.Add("opentitme", batch.OpenTime);
            stiReport.Dictionary.Variables.Add("closetime", batch.CloseTime);
            stiReport.Dictionary.Variables.Add("payout", batch.StorePayouts.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("totalsell", batch.TotalSell.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("cashiersum", batch.CashierSum.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("totalacountsvalue", batch.TotalAccountsValue.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("totalsellwithoutcredit", batch.TotalSell.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("totaldifference", batch.SystemCashierVariant.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("accountingin", batch.Income.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("accountingout", batch.Credit.ToString("#,#"));
            stiReport.Dictionary.Variables.Add("systemsum", batch.SystemSum.ToString("#,#"));
            stiReport.RegData(this.BankValueToTable(batch.BankValues));
        }

        private DataTable BankValueToTable(List<BankValueModel> bankValues)
        {
            int id = 0;
            DataTable dataTable = new DataTable("bankvalue");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("paymentmethod");
            dataTable.Columns.Add("openvalue");
            dataTable.Columns.Add("closevalue");
            dataTable.Columns.Add("total");
            dataTable.Columns.Add("variant");
            foreach (var item in bankValues)
            {
                dataTable.Rows.Add(new object[] { id, item.PaymentMethod, item.OpenValue.ToString("#,#"), item.CloseValue.ToString("#,#"), item.TotalSell.ToString("#,#"), item.Variant.ToString("#,#") });
                id++;
            }
            return dataTable;
        }

        private StiReport SetLicense()
        {
            StiReport stiReport = new Stimulsoft.Report.StiReport();
            Stimulsoft.Base.StiLicense.Key =
               "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkcgIvwL0jnpsDqRpWg5FI5kt2G7A0tYIcUygBh" +
               "1sPs7koivWV0htru4Pn2682yhdY3+9jxMCVTKcKAjiEjgJzqXgLFCpe62hxJ7/VJZ9Hq5l39md0pyydq" +
               "d5Dc1fSWhCtYqC042BVmGNkukYJQN0ufCozjA/qsNxzNMyEql26oHE6wWE77pHutroj+tKfOO1skJ52c" +
               "bZklqPm8OiH/9mfU4rrkLffOhDQFnIxxhzhr2BL5pDFFCZ7axXX12y/4qzn5QLPBn1AVLo3NVrSmJB2K" +
               "iwGwR4RL4RsYVxGScsYoCZbwqK2YrdbPHP0t5vOiLjBQ+Oy6F4rNtDYHn7SNMpthfkYiRoOibqDkPaX+" +
               "RyCany0Z+uz8bzAg0oprJEn6qpkQ56WMEppdMJ9/CBnEbTFwn1s/9s8kYsmXCvtI4iQcz+RkUWspLcBz" +
               "lmj0lJXWjTKMRZz+e9PmY11Au16wOnBU3NHvRc9T/Zk0YFh439GKd/fRwQrk8nJevYU65ENdAOqiP5po" +
               "7Vnhif5FCiHRpxgF";
            return stiReport;
        }
    }
}
//Stimulsoft.Report.StiReport stiReport = new Stimulsoft.Report.StiReport();
//stiReport.Load(Properties.Resources.mainbatchreport);
//Stimulsoft.Base.StiLicense.Key =
//   "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkcgIvwL0jnpsDqRpWg5FI5kt2G7A0tYIcUygBh" +
//   "1sPs7koivWV0htru4Pn2682yhdY3+9jxMCVTKcKAjiEjgJzqXgLFCpe62hxJ7/VJZ9Hq5l39md0pyydq" +
//   "d5Dc1fSWhCtYqC042BVmGNkukYJQN0ufCozjA/qsNxzNMyEql26oHE6wWE77pHutroj+tKfOO1skJ52c" +
//   "bZklqPm8OiH/9mfU4rrkLffOhDQFnIxxhzhr2BL5pDFFCZ7axXX12y/4qzn5QLPBn1AVLo3NVrSmJB2K" +
//   "iwGwR4RL4RsYVxGScsYoCZbwqK2YrdbPHP0t5vOiLjBQ+Oy6F4rNtDYHn7SNMpthfkYiRoOibqDkPaX+" +
//   "RyCany0Z+uz8bzAg0oprJEn6qpkQ56WMEppdMJ9/CBnEbTFwn1s/9s8kYsmXCvtI4iQcz+RkUWspLcBz" +
//   "lmj0lJXWjTKMRZz+e9PmY11Au16wOnBU3NHvRc9T/Zk0YFh439GKd/fRwQrk8nJevYU65ENdAOqiP5po" +
//   "7Vnhif5FCiHRpxgF";
//stiReport.Dictionary.Variables.Add("user", this.batchReport.User.Username);
//stiReport.Dictionary.Variables.Add("register", this.batchReport.Register.ComputerName);
//stiReport.Dictionary.Variables.Add("opentitme", this.batchReport.OpenTime);
//stiReport.Dictionary.Variables.Add("closetime", this.batchReport.CloseTime);
//stiReport.Dictionary.Variables.Add("payout", this.batchReport.Payout);
//stiReport.Dictionary.Variables.Add("totalsell", this.batchReport.TotalSell);
//stiReport.Dictionary.Variables.Add("totaldifference", this.batchReport.TotalDifference);
//stiReport.Dictionary.Variables.Add("accountingin", this.batchReport.AccountingIn);
//stiReport.Dictionary.Variables.Add("accountingout", this.batchReport.AccountingOut);
//stiReport.Design();


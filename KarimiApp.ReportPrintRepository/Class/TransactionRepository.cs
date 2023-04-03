using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository.Interface;
using Stimulsoft.Base.Json;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace KarimiApp.ReportPrintRepository.Class
{
    internal class TransactionRepository:ITransaction
    {
        private UnitOfWork unitOfWork;
        Configuration config;
        AppSettingsSection app;
        public TransactionRepository()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
            unitOfWork = new UnitOfWork();
        }

         void ITransaction.Print( TransactionModel transaction,long discountvalue=0)
        {
            string reportfile = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk")).CashierReport;
            StiReport sti = this.SetLicense();
            sti.Load(reportfile);
            this.SetVariables(sti, transaction,discountvalue);
            sti.Design();
            //sti.EndRender += Sti_EndRender;
            // sti.Render();
             sti.Print(false);
           // sti.Show(false);

        }

        private void Sti_EndRender(object sender, System.EventArgs e)
        {
            foreach (StiPage page in (sender as StiReport).RenderedPages)
            {
                double max = 0;
                foreach (StiComponent comp in page.GetComponents())
                {
                    if (comp.Bottom > max) max = comp.Bottom;
                }
                page.PageHeight = max + page.Margins.Top + page.Margins.Bottom;
            }
        }

        private void SetVariables(StiReport stiReport,TransactionModel transaction,long discountvalue)
        {
            long total = 0;
            long discount = 0;
            if (discountvalue != 0)
            {
                total = discountvalue * 100 / 90;
                discount = total - discountvalue;
            }
            else
            {
                total = transaction.TotalValue;
            }
           // string barcode = unitOfWork.Transaction.LastCode();
            stiReport.Dictionary.Variables.Add("usercode", transaction.BatchUser);
            stiReport.Dictionary.Variables.Add("customername", transaction.Person);
            stiReport.Dictionary.Variables.Add("discount", discount);
            stiReport.Dictionary.Variables.Add("tottalcost", total);
            stiReport.Dictionary.Variables.Add("storename", app.Settings["storeName"].Value);
            stiReport.Dictionary.Variables.Add("storebranch", app.Settings["branchName"].Value);
            stiReport.Dictionary.Variables.Add("storewebsite", app.Settings["storeWebsite"].Value);
            stiReport.Dictionary.Variables.Add("storePhone", app.Settings["storePhone"].Value);
            stiReport.Dictionary.Variables.Add("storeAddress", app.Settings["storeAddress"].Value);
            // stiReport.Dictionary.Variables.Add("barcode", barcode);
            stiReport.RegData(this.TransactionToTable(transaction.Entries));
        }

        private DataTable TransactionToTable(List<TransactionEntryModel> transactionEntries ) 
        {
            int id = 0;
            DataTable dataTable = new DataTable("order");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("cost");
            dataTable.Columns.Add("count");
            dataTable.Columns.Add("totalcost");
            foreach (var item in transactionEntries)
            {
                dataTable.Rows.Add(new object[] { id, item.Item, item.SellPrice, item.Amount, item.SellPrice * item.Amount });
                id++;
            }
            return dataTable;
        }

        private  StiReport SetLicense()
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

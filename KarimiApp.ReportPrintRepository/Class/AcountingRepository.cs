using KarimiApp.Model;
using KarimiApp.ReportPrintRepository.Interface;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace KarimiApp.ReportPrintRepository.Class
{
    public class AcountingRepository : IAcounting
    {
        PersianCalendar persianCalendar;
        void IAcounting.AllPersons(List<PersonCreditHeaderModel> persons)
        {
            throw new NotImplementedException();
        }

        void IAcounting.PersonLog(PersonCreditHeaderModel personCredit)
        {
            this.PersonLogPrint(personCredit);
        }

        void PersonLogPrint(PersonCreditHeaderModel person)
        {
           // string reportfile = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk")).BatchReport;
            StiReport sti = this.SetLicense();
            sti.Load(@"Settings\Reports\creditlogreport.mrt");
            this.CreditsSetVariables(sti, person);
          // sti.Design();
           // sti.Render();
            sti.Print(false);

        }
        void PersonsBalanceReport(List<PersonModel> customers)
        {
            StiReport sti = this.SetLicense();
            sti.Load(@"Settings\Reports\customersreport.mrt");
           sti.RegData( this.PersonListToTable(customers));
            // sti.Design();
            // sti.Render();
            sti.Print(false);
        }

        private DataTable PersonListToTable(List<PersonModel> customers)
        {
            int id = 1;
            DataTable dataTable = new DataTable("PersonReport");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("customername");
            dataTable.Columns.Add("balance");
            foreach (PersonModel person in customers)
            {
                dataTable.Rows.Add(new object[] { id, person.Name, person.Balance });
                id++;
            }
            return dataTable;
        }

        private void CreditsSetVariables(StiReport stiReport, PersonCreditHeaderModel person)
        {
            stiReport.Dictionary.Variables.Add("personname", person.Name);
            stiReport.Dictionary.Variables.Add("balance", person.Balance);
          
            stiReport.RegData(this.LogToTable(person.Log));
        }

        private DataTable LogToTable(List<PersonCreditLogModel> personCreditLogs)
        {
            int id = 0;
            DataTable dataTable = new DataTable("personlog");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("bedehkari");
            dataTable.Columns.Add("bestankari");
            dataTable.Columns.Add("balance");
            dataTable.Columns.Add("recordtime");
            foreach (var item in personCreditLogs)
            {
                dataTable.Rows.Add(new object[] { id, item.Bedehkari, item.Bestankari, item.Remain,item.RecordTime.ToString()});
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

        void IAcounting.Payouts(List<PayoutTransactionModel> payoutTransactions,DateTime starttime,DateTime endtime,bool printToFile=false)
        {
            StiReport sti = this.SetLicense();
            sti.Load(@"Settings\Reports\payoutreport.mrt");
            this.PayoutsSetVariables(sti, payoutTransactions,starttime,endtime);
            // sti.Design();
            // sti.Render();
            if (printToFile)
            {
                System.Drawing.Printing.PrinterSettings printerSettings = new System.Drawing.Printing.PrinterSettings();
                printerSettings.PrinterName = "Microsoft Print To Pdf";
                printerSettings.PrintToFile = true;
                sti.Print(printerSettings: printerSettings,showPrintDialog:false);
            }
            else
            {
                sti.Print(false);
            }
           
        }

        private void PayoutsSetVariables(StiReport sti, List<PayoutTransactionModel> payoutTransactions, DateTime starttime, DateTime endtime)
        {
            sti.Dictionary.Variables.Add("starttime", starttime);
            sti.Dictionary.Variables.Add("endtime", endtime);
            persianCalendar = new PersianCalendar();

            DataTable dataTable = new DataTable("payouts");
            dataTable.Columns.Add("description");
            dataTable.Columns.Add("user");
            dataTable.Columns.Add("value");
            dataTable.Columns.Add("RecordDate");
            dataTable.Columns.Add("recordtime");
            foreach (var item in payoutTransactions)
            {
                dataTable.Rows.Add(new object[] { item.Description, item.BatchUser, item.Value,item.RecordTime.ToString("yyyy/MM/dd", new CultureInfo("fa-IR")),item.RecordTime.ToString("HH:mm:ss") });
            }
            sti.RegData(dataTable);
        }

        void IAcounting.CustomersReport(List<PersonModel> customers)
        {
            this.PersonsBalanceReport(customers);
        }
    }
}

using DevExpress.XtraEditors;
using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using KarimiApp.Model;
using System;

namespace KarimiApp.Client.Repository.Repository
{
    internal class DepartmentRepository : MainRepository<DepartmentModel>, IDepartment
    {
        public DepartmentRepository(HttpClientAccess httpClient) : base("department", httpClient)
        {

        }

        public override void List(ComboBoxEdit comboBox,string text)
        {
            this.ListResult().ForEach(x => comboBox.Properties.Items.Add(x.Title));
        }


    }
}

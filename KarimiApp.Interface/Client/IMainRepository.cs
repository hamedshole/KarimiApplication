using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IMainRepository<TModel>
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        List<TModel> List(string text="");
         void List(GridControl gridControl,string text="");
        void List(ComboBoxEdit comboBox,string text="");
        List<TModel> Search(string model);
        void Search(string text, GridControl gridControl);
        TModel Get(string text);
    }
}

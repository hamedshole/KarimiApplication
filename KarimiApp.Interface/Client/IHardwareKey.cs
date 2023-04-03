using DevExpress.XtraGrid;
using KarimiApp.Model;
using System.Collections.Generic;

namespace KarimiApp.Interface.Client
{
    public interface IHardwareKey
    {
        void Create(HardwareKeyModel model);
        void Update(HardwareKeyModel model);
        void Delete(HardwareKeyModel model);
        List<HardwareKeyModel> List(HardwareKeyModel model);
        void List(HardwareKeyModel model, GridControl grid);
        List<HardwareKeyModel> Search(HardwareKeyModel model);
        void Search(HardwareKeyModel model, GridControl grid);
    }
}

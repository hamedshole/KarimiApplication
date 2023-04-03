using System;
using DevExpress.Xpo;
using DevExpress.XtraGrid;

namespace KarimiApp.Interface.Client
{

    public interface IAcounting 
    {
        void PayoutList(DateTime date,GridControl grid);
        void PersonCreditList(GridControl grid);
    }

}
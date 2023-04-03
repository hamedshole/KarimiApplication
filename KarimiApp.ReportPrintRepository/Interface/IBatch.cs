using KarimiApp.Model;

namespace KarimiApp.ReportPrintRepository.Interface
{
    public interface IBatch
    {
        void Print(BatchModel batch);
    }
}

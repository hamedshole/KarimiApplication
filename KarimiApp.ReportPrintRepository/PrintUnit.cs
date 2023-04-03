using KarimiApp.ReportPrintRepository.Class;
using KarimiApp.ReportPrintRepository.Interface;

namespace KarimiApp.ReportPrintRepository
{
    public class PrintUnit
    {
        private ITransaction _transactionRepository;
        private IBatch _batchRepository;
        private IAcounting _acountingRepository;
        public IAcounting Acounting
        {
            get
            {
                if (_acountingRepository == null)
                {
                    _acountingRepository = new AcountingRepository();
                }
                return _acountingRepository;
            }
        }
        public ITransaction Transaction
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository();
                }
                return _transactionRepository;
            }
        }
        public IBatch Batch
        {
            get
            {
                if (_batchRepository == null)
                {
                    _batchRepository = new BatchRepository();
                }
                return _batchRepository;
            }
        }
    }
}

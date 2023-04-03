using KarimiApp.Client.Repository.Util;
using KarimiApp.Client.Repository.Repository;
using KarimiApp.Interface.Client;

namespace KarimiApp.Client.Repository
{
    public class UnitOfWork
    {
        private readonly HttpClientAccess httpClientAccess;

        public UnitOfWork()
        {
            httpClientAccess = new HttpClientAccess();
        }

        private IItemCategory _itemCategoryRepository;
        private IInventory _inventoryRepository;
        private IItem _itemRepository;
        private IPersonGroup _persoGroupRepository;
        private IUserRole _userRoleRepository;
        private IDepartment _departmentRepository;
        private IPaymentMethod _paymentMethodrepository;
        private IPaymentType _paymentTypeRepository;
        private IUser _userRepository;
        private IInventoryGroup _inventoryGroupRepository;
        private IPosInfo _posInfoRepository;
        private IRegister _registerRepository;
        private IPerson _personRepository;
        private IHardwareKey _harKeyRepository;
        private IWorkstation _workstationrepository;
        private IReceipt _receiptRepository;
        private ISupplier _supplierRepository;
        private ISupplierCompany _supplierCompanyRepository;
        private ITransactionType _transactionTypeRepository;
        private ITransaction _transactionRepository;
        private IOrder _orderRepository;
        private IPaymentTransaction _paymentTransactionRepository;
        private IPayoutTransaction _payoutTransactionRepository;
        private IBatch _batchRepository;
        private IAuthentication _authenticationrepository;
        private IPlu _pluRepository;
        private IAcounting _acountingRepository;
        private IDiscount _discountRepository;
        private IInventoryManagement _inventoryManagement;

        public IItemCategory ItemCategory
        {
            get
            {
                if (_itemCategoryRepository == null)
                {
                    _itemCategoryRepository = new ItemCategoryRepository(httpClientAccess);
                }
                return _itemCategoryRepository;
            }
        }

        public IItem Item
        {
            get
            {
                if (_itemRepository == null)
                {
                    _itemRepository = new ItemRepositroy(httpClientAccess);
                }
                return _itemRepository;
            }
        }
        public IInventory Inventory
        {
            get
            {
                if (_inventoryRepository == null)
                {
                    _inventoryRepository = new InventoryRepository(httpClientAccess);
                }
                return _inventoryRepository;
            }
        }
        public IPersonGroup PersonGroup
        {
            get
            {
                if (_persoGroupRepository == null)
                {
                    _persoGroupRepository = new PersonGroupRepository(httpClientAccess);
                }
                return _persoGroupRepository;
            }
        }
        public IUserRole UserRole
        {
            get
            {
                if (_userRoleRepository == null)
                {
                    _userRoleRepository = new UserRoleRepository(httpClientAccess);
                }
                return _userRoleRepository;
            }
        }
        public IDepartment Department
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(httpClientAccess);
                }
                return _departmentRepository;
            }
        }
        public IPaymentMethod PaymentMethod
        {
            get
            {
                if (_paymentMethodrepository == null)
                {
                    _paymentMethodrepository = new PaymentMethodRepository(httpClientAccess);
                }
                return _paymentMethodrepository;
            }
        }
        public IPaymentType PaymentType
        {
            get
            {
                if (_paymentTypeRepository == null)
                {
                    _paymentTypeRepository = new PaymentTypeRepository(httpClientAccess);
                }
                return _paymentTypeRepository;
            }
        }
        public IUser User
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(httpClientAccess);
                }
                return _userRepository;
            }
        }
        public IInventoryGroup InventoryGroup
        {
            get
            {
                if (_inventoryGroupRepository == null)
                {
                    _inventoryGroupRepository = new InventoryGroupRepository(httpClientAccess);
                }
                return _inventoryGroupRepository;
            }
        }
        public IPosInfo PosInfo
        {
            get
            {
                if (_posInfoRepository == null)
                {
                    _posInfoRepository = new PosInfoRepository(httpClientAccess);
                }
                return _posInfoRepository;
            }
        }
        public IRegister Register
        {
            get
            {
                if (_registerRepository == null)
                {
                    _registerRepository = new RegisterRepository(httpClientAccess);
                }
                return _registerRepository;
            }
        }
        public IPerson Person
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(httpClientAccess);
                }
                return _personRepository;
            }
        }
        public IHardwareKey HardKey
        {
            get
            {
                if (_harKeyRepository == null)
                {
                    _harKeyRepository = new HardwareKeyRepository(httpClientAccess);
                }
                return _harKeyRepository;
            }
        }
        public IWorkstation Workstation
        {
            get
            {
                if (_workstationrepository == null)
                {
                    _workstationrepository = new WorkstationRepository(httpClientAccess);
                }
                return _workstationrepository;
            }
        }
        public ITransactionType TransactionType
        {
            get
            {
                if (_transactionTypeRepository == null)
                {
                    _transactionTypeRepository = new TransactionTypeRepository(httpClientAccess);
                }
                return _transactionTypeRepository;
            }
        }
        public ISupplier Supplier
        {
            get
            {
                if (_supplierRepository == null)
                {
                    _supplierRepository = new SupplierRepository(httpClientAccess);
                }
                return _supplierRepository;
            }
        }
        public ISupplierCompany SupplierCompany
        {
            get
            {
                if (_supplierCompanyRepository == null)
                {
                    _supplierCompanyRepository = new SupplierCompanyRepository(httpClientAccess);
                }
                return _supplierCompanyRepository;
            }
        }
        public ITransaction Transaction
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(httpClientAccess);
                }
                return _transactionRepository;
            }
        }
        public IPaymentTransaction PaymentTransaction
        {
            get
            {
                if (_paymentTransactionRepository == null)
                {
                    _paymentTransactionRepository = new PaymentTransactionRepository(httpClientAccess);
                }
                return _paymentTransactionRepository;
            }
        }
        public IPayoutTransaction PayoutTransaction
        {
            get
            {
                if (_payoutTransactionRepository == null)
                {
                    _payoutTransactionRepository = new PayoutTransactionRepository(httpClientAccess);
                }
                return _payoutTransactionRepository;
            }
        }
        public IOrder Order
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderTransactionRepository(httpClientAccess);
                }
                return _orderRepository;
            }
        }
        public IReceipt Receipt
        {
            get
            {
                if (_receiptRepository == null)
                {
                    _receiptRepository = new ReceiptRepository(httpClientAccess);
                }
                return _receiptRepository;
            }
        }
        public IBatch Batch
        {
            get
            {
                if (_batchRepository == null)
                {
                    _batchRepository = new BatchRepository(httpClientAccess);
                }
                return _batchRepository;
            }
        }
        public IAuthentication Authentication
        {
            get
            {
                if (_authenticationrepository == null)
                {
                    _authenticationrepository = new AuthenticationRepository(httpClientAccess);
                }
                return _authenticationrepository;
            }
        }
        public IPlu Plu
        {
            get
            {
                if (_pluRepository == null)
                {
                    _pluRepository = new PluRepository(httpClientAccess);
                }
                return _pluRepository;
            }
        }
        public IAcounting Acounting
        {
            get
            {
                if (_acountingRepository == null)
                {
                    _acountingRepository = new AcountingRepository(httpClientAccess);
                }
                return _acountingRepository;
            }
        }
        public IDiscount Discount
        {
            get
            {
                if (_discountRepository == null)
                {
                    _discountRepository = new DiscountRepository(this.httpClientAccess) ;
                }
                return _discountRepository;
            }
        }
        public IInventoryManagement InventoryManagement
        {
            get
            {
                if (_inventoryManagement == null)
                {
                    _inventoryManagement = new InventoryManagementRepository(this.httpClientAccess);
                }
                return _inventoryManagement;
            }
        }
    }
}

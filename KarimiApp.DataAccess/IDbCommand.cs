using KarimiApp.Interface.Server;

namespace KarimiApp.DataAccess
{
    public interface IDbCommand: IBatchRepo, IDepartment, IHardwareKey, IInventoryGroup
        , IInventory, IItemCategory, IItem, IPaymentMethod, IPaymentType,
        IPersonGroup, IPerson, IPlu, IPosInfo, IRegister, ISupplier,
        ISupplierCompany, ITransactionType, IUser, IUserRole, IUserSettings,
        IWorkstation,IDiscount
    {
        //void CreateAndConnect();
        //void Dispose();
        //string PersonInsert(PersonModel person);
        //string PersonUpdate(PersonModel person);
        //string PersonDelete(PersonModel person);
        //PersonModel PersonGet(PersonModel person);
        //List<PersonModel> PersonList();
        //string PersonGroupInsert(PersonGroupModel personGroup);
        //string PersonGroupUpdate(PersonGroupModel personGroup);
        //string PersonGroupDelete(PersonGroupModel personGroup);
        //PersonGroupModel PersonGroupGet(PersonGroupModel personGroup);
        //List<PersonGroupModel> PersonGroupList();
        //string DepartmentInsert(DepartmentModel department);
        //string DepartmentUpdate(DepartmentModel department);
        //string DepartmentDelete(DepartmentModel department);
        //DepartmentModel DepartmentGet(DepartmentModel department);
        //List<DepartmentModel> DepartmentList();
        //string InventoryInsert(InventoryModel inventory);
        //string InventoryUpdate(InventoryModel inventory);
        //string InventoryDelete(InventoryModel inventory);
        //InventoryModel InventoryGet(InventoryModel inventory);
        //List<InventoryModel> InventoryList();
        //string InventoryGroupInsert(InventoryGroupModel inventoryGroup);
        //string InventoryGroupUpdate(InventoryGroupModel inventoryGroup);
        //string InventoryGroupDelete(InventoryGroupModel inventoryGroup);
        //InventoryGroupModel InventoryGroupGet(InventoryGroupModel inventoryGroup);
        //List<InventoryGroupModel> InventoryGroupList();
        //string ItemCategoryInsert(ItemCategoryModel itemCategory);
        //string ItemCategoryUpdate(ItemCategoryModel itemCategory);
        //string ItemCategoryDelete(ItemCategoryModel itemCategory);
        //ItemCategoryModel ItemCategoryGet(ItemCategoryModel itemCategory);
        //List<ItemCategoryModel> ItemCategoryList();
        //string UserRoleInsert(UserRoleModel userRole);
        //string UserRoleUpdate(UserRoleModel userRole);
        //string UserRoleDelete(UserRoleModel userRole);
        //UserRoleModel UserRoleGet(UserRoleModel userRole);
        //List<UserRoleModel> UserRoleList();
        //string ItemInsert(ItemModel item);
        //string ItemUpdate(ItemModel item);
        //string ItemDelete(ItemModel item);
        //ItemModel ItemGet(ItemModel item);
        //List<ItemModel> ItemList();
        //string HardwareKeyInsert(HardwareKeyModel hardwareKey);
        //string HardwareKeyUpdate(HardwareKeyModel hardware);
        //string ItemDelete(HardwareKeyModel hardware);
        //HardwareKeyModel HardWareKeyGet(HardwareKeyModel item);
        //List<HardwareKeyModel> HardwareKeyList(HardwareKeyModel hardwareKey);
        //string PaymentMethodInsert(PaymentMethodModel paymentMethod);
        //string PaymentMethodUpdate(PaymentMethodModel paymentMethod);
        //string PaymentMethodDelete(PaymentMethodModel paymentMethod);
        //PaymentMethodModel PaymentMethodGet(PaymentMethodModel paymentMethod);
        //List<PaymentMethodModel> PaymentMethodList();
        //string PaymentTypeInsert(PaymentTypeModel paymentType);
        //string PaymentTypeUpdate(PaymentTypeModel paymentType);
        //string PaymentTypeDelete(PaymentTypeModel paymentType);
        //PaymentTypeModel PaymentTypeGet(PaymentTypeModel paymentType);
        //List<PaymentTypeModel> PaymentTypeList();
        //string WorkstationInsert(WorkstationModel workstation);
        //string WorkstationUpdate(WorkstationModel workstation);
        //string WorkstationDelete(WorkstationModel workstation);
        //WorkstationModel WorkstationGet(WorkstationModel workstation);
        //List<WorkstationModel> WorkstationList();
        //string RegisterInsert(RegisterModel register);
        //string RegisterUpdate(RegisterModel register);
        //string RegisterDelete(RegisterModel register);
        //RegisterModel RegisterGet(RegisterModel register);
        //List<RegisterModel> RegisterList();
        //string ReceiptInsert(ReceiptModel receipt);
        //string ReceiptUpdate(ReceiptModel receipt);
        //string ReceiptDelete(ReceiptModel receipt);
        //ReceiptModel ReceiptGet(ReceiptModel receipt);
        //List<ReceiptModel> ReceiptList();
        //string ReceiptEntryInsert(ReceiptEntryModel receiptEntry);
        //string ReceiptEntryUpdate(ReceiptEntryModel receiptEntry);
        //string ReceiptEntryDelete(ReceiptEntryModel receiptEntry);
        //ReceiptEntryModel ReceiptEntryGet(ReceiptEntryModel receiptEntry);
        //List<ReceiptEntryModel> ReceiptEntryList(ReceiptModel receipt);
        //string PosInfoInsert(PosInfoModel posInfo);
        //string PosInfoUpdate(PosInfoModel posInfo);
        //string PosInfoDelete(PosInfoModel posInfo);
        //PosInfoModel PosInfoGet(PosInfoModel posInfo);
        //List<PosInfoModel> PosInfoList();
        //string SupplierCompanyInsert(SupplierCompanyModel supplierCompany);
        //string SupplierCompanyUpdate(SupplierCompanyModel supplierCompany);
        //string SupplierCompanyDelete(SupplierCompanyModel supplierCompany);
        //SupplierCompanyModel SupplierCompanyGet(SupplierCompanyModel supplierCompany);
        //List<SupplierCompanyModel> SupplierCompanyList();
        //string SupplierAgentInsert(SupplierAgentModel supplierAgent);
        //string SupplierAgentUpdate(SupplierAgentModel supplierAgent);
        //string SupplierAgentDelete(SupplierAgentModel supplierAgent);
        //SupplierAgentModel SupplierAgentGet(SupplierAgentModel supplierAgent);
        //List<SupplierAgentModel> SupplierAgentList();
        //string TransactionTypeInsert(TransactionTypeModel transactionType);
        //string TransactionTypeUpdate(TransactionTypeModel transactionType);
        //string TransactionTypeDelete(TransactionTypeModel transactionType);
        //TransactionTypeModel TransactionTypeGet(TransactionTypeModel transactionType);
        //List<TransactionTypeModel> TransactionTypeList();
        //string PluInsert(PluModel plu);
        //string PluUpdate(PluModel plu);
        //string PluDelete(PluModel plu);
        //PluModel PluGet(PluModel plu);
        //List<PluModel> PluList(PluModel plu);

    }

}

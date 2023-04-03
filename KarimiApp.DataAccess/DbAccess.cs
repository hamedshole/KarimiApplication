using KarimiApp.Interface.Server;
using KarimiApp.Model;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;

namespace KarimiApp.DataAccess
{

    public class DbAccess : IBatchRepo, IDepartment, IHardwareKey, IInventoryGroup
        , IInventory, IItemCategory, IItem, IPaymentMethod, IPaymentType,
        IPersonGroup, IPerson, IPlu, IPosInfo, IRegister, ISupplier,
        ISupplierCompany, ITransactionType, IUser, IUserRole, IUserSettings,
        IWorkstation, IPaymentTransaction, IPayoutTransaction, IAuthentication, ITransactionRepo, IReceiptRepo, IOrder, IAcountingRepo, IDiscount, IInventoryManagement
    {
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private bool disposed = false;
        private SqlConnection connection;
        private SqlCommand command;
        private readonly string insertMessage = "آیتم با موفقیت افزوده شد";
        private readonly string updateMessage = "تغییرات با موفقیت اعمال شد";
        private readonly string deleteMessage = "آیتم با موفقیت حذف شد";

        void CreateAndConnect()
        {
            string s = @"Data Source=.;Initial Catalog=KarimiDb99-3-20;User ID=sa;Password=Hshk24121373;TrustServerCertificate=True";
            this.connection = new SqlConnection
            {

                // ConnectionString = @"Data Source=KARIMI-CSERVER\MSPOSINSTANCE;Initial Catalog=KarimiDb99-3-20;Integrated Security=True",
                // ConnectionString = @"Data Source=DESKTOP-DEATHLY\MSSQLSERVER2016;Initial Catalog=KarimiDb99-3-20;Integrated Security=True",
                ConnectionString = s,
                // ConnectionString = @"Data Source=KARIMI-CSERVER\MSPOSINSTANCE;Initial Catalog=KarimiDb99-3-20; User Id:KarimiLogin;Password:123456;",
            };
            this.connection.Open();
            this.command = new SqlCommand
            {
                Connection = this.connection,
            };
        }

        void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.handle.Dispose();
                this.connection.Dispose();
                this.command.Dispose();
            }

            this.disposed = true;
        }

        private string RunProcedure(string command, List<SqlParameter> parameters, string successMessage)
        {
            try
            {
                this.CreateAndConnect();
                this.command.CommandType = System.Data.CommandType.StoredProcedure;
                this.command.CommandText = command;
                this.command.Parameters.AddRange(parameters.ToArray());
                this.command.ExecuteNonQuery();
                this.Dispose();
                return successMessage;
            }
            catch (Exception e)
            {
                return e.Message + e.StackTrace;
            }
        }
        private SqlDataReader ReadProcedure(string command, List<SqlParameter> parameters = null)
        {
            try
            {
                this.CreateAndConnect();
                this.command.CommandType = System.Data.CommandType.StoredProcedure;
                this.command.CommandText = command;
                if (parameters != null)
                {
                    this.command.Parameters.AddRange(parameters.ToArray());
                }
                SqlDataReader dataReader = this.command.ExecuteReader();
            
                return dataReader;
            }
            catch (Exception e)
            {

                throw e;
            }

        }



        string IBatch.Close(BatchModel model)
        {
            return this.RunProcedure(command: "sp_batch_close",
               parameters: new List<SqlParameter> {
                                new SqlParameter("@register", model.BatchRegister),
                                new SqlParameter("user", model.BatchUser) },
               successMessage: "شیفت بسته شد");
        }

        string IMain<DepartmentModel>.Insert(DepartmentModel model)
        {
            return this.RunProcedure("sp_department_insert", this.DepartmentInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> DepartmentInsertParameters(DepartmentModel model)
        {
            return new List<SqlParameter>
            {
                 new SqlParameter("@name", model.Title) ,
            new SqlParameter("@description", model.Description),
            new SqlParameter("@inventory", model.DefaultInventory),
            new SqlParameter("@active", model.Active)
            };
        }

        string IMain<DepartmentModel>.Update(DepartmentModel model)
        {
            return this.RunProcedure("sp_department_update",
                parameters: this.DepartmentInsertParameters(model).Concat(new SqlParameter[] { new SqlParameter("@id", model.Id) }).ToList(),
                successMessage: this.updateMessage);
        }

        string IMain<DepartmentModel>.Delete(DepartmentModel model)
        {
            return this.RunProcedure(command: "sp_department_delete",
                 parameters: new List<SqlParameter> { new SqlParameter("@id", model.Id) },
                 successMessage: this.deleteMessage);
        }

        DepartmentModel IMain<DepartmentModel>.Get(string title)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_department_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();

                return this.DepartmentRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DepartmentModel DepartmentRead(SqlDataReader dataReader)
        {
            return new DepartmentModel(
                id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                defaultInventory: dataReader["DefaultInventory"].ToString(),
                description: dataReader["Description"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<DepartmentModel> IMain<DepartmentModel>.Search(string text)
        {
            try
            {
                List<DepartmentModel> departments = new List<DepartmentModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_department_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    departments.Add(this.DepartmentRead(dataReader));
                }
                return departments;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        List<DepartmentModel> IMain<DepartmentModel>.List(string department)
        {
            try
            {
                List<DepartmentModel> list = new List<DepartmentModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_department_read");
                while (dataReader.Read())
                {
                    list.Add(this.DepartmentRead(dataReader));
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IHardwareKey.Insert(HardwareKeyModel model)
        {
            return this.RunProcedure("sp_hardwarekey_insert", this.HardKeyInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> HardKeyInsertParameters(HardwareKeyModel model)
        {
            return new List<SqlParameter> {  new SqlParameter("@workstation", model.Workstation),
            new SqlParameter("@key", model.Key),
            new SqlParameter("@plu", model.Item.Memory) };
        }

        List<HardwareKeyModel> IHardwareKey.List(HardwareKeyModel model)
        {
            try
            {
                List<HardwareKeyModel> hardwareKeys = new List<HardwareKeyModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_hardwarekey_read", new List<SqlParameter> { new SqlParameter("@workstation", model.Workstation) });
                while (dataReader.Read())
                {
                    hardwareKeys.Add(this.HardwareKeyRead(dataReader));
                }
                return hardwareKeys;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private HardwareKeyModel HardwareKeyRead(SqlDataReader dataReader)
        {
            return new HardwareKeyModel(
                id: this.IntChecker(dataReader, "Id"),
                workstation: dataReader["Workstation"].ToString(),
               key: this.IntChecker(dataReader, "Key"))
            { ItemMemory = Convert.ToInt32(dataReader["Plu"]) };
        }

        ItemModel IHardwareKey.ItemGetByMemory(int memory)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_item_get_by_memory", new List<SqlParameter> { new SqlParameter("@memory", memory) });
            dataReader.Read();
            return this.ItemRead(dataReader);
        }

        private PluModel PluGetById(int id)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_plu_getbyid", new List<SqlParameter> { new SqlParameter("@id", id) });
            return this.PluRead(dataReader);
        }

        string IMain<InventoryGroupModel>.Insert(InventoryGroupModel model)
        {
            return this.RunProcedure("sp_inventorygroup_insert", this.InventoryGroupInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> InventoryGroupInsertParameters(InventoryGroupModel model)
        {
            return new List<SqlParameter>{  new SqlParameter("@title", model.Title),
           new SqlParameter("@description", model.Description),
           new SqlParameter("@active", model.Active)};
        }

        string IMain<InventoryGroupModel>.Update(InventoryGroupModel model)
        {
            return this.RunProcedure("sp_inventorygroup_update", this.InventoryGroupInsertParameters(model).Concat(new[] { new SqlParameter("@id", model.Id) }).ToList(), this.updateMessage);
        }

        string IMain<InventoryGroupModel>.Delete(InventoryGroupModel model)
        {
            return this.RunProcedure("sp_inventorygroup_delete", new List<SqlParameter> { new SqlParameter("@id", model.Id) }, this.deleteMessage);
        }

        InventoryGroupModel IMain<InventoryGroupModel>.Get(string title)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_inventorygroup_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return this.InventoryGroupRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private InventoryGroupModel InventoryGroupRead(SqlDataReader dataReader)
        {
            return new InventoryGroupModel(id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                description: dataReader["Description"].ToString(),
                Convert.ToBoolean(dataReader["Active"]));
        }

        List<InventoryGroupModel> IMain<InventoryGroupModel>.Search(string text)
        {
            try
            {
                List<InventoryGroupModel> inventoryGroups = new List<InventoryGroupModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_inventorygroup_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    inventoryGroups.Add(this.InventoryGroupRead(dataReader));
                }
                return inventoryGroups;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<InventoryGroupModel> IMain<InventoryGroupModel>.List(string inventoryGroup)
        {
            try
            {
                List<InventoryGroupModel> inventoryGroups = new List<InventoryGroupModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_inventorygroup_read");
                while (dataReader.Read())
                {
                    inventoryGroups.Add(this.InventoryGroupRead(dataReader));
                }
                return inventoryGroups;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<InventoryModel>.Insert(InventoryModel model)
        {
            return this.RunProcedure("sp_inventory_insert", this.InventoryInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> InventoryInsertParameters(InventoryModel model)
        {
            return new List<SqlParameter>{ new SqlParameter("@title", model.Title),
       new SqlParameter("@description", model.Description),
       new SqlParameter("@keeper", model.Keeper),
       new SqlParameter("@group", model.Group),
       new SqlParameter("@active", model.Active)};
        }

        string IMain<InventoryModel>.Update(InventoryModel model)
        {
            return this.RunProcedure("sp_inventory_update", this.InventoryInsertParameters(model).Concat(new[] { new SqlParameter("@id", model.Id) }).ToList(), this.updateMessage); ;
        }

        string IMain<InventoryModel>.Delete(InventoryModel model)
        {
            return this.RunProcedure("sp_inventory_delete", new List<SqlParameter> { new SqlParameter("@id", model.Id) }, this.deleteMessage);
        }

        InventoryModel IMain<InventoryModel>.Get(string title)
        {
            try
            {

                SqlDataReader dataReader = this.ReadProcedure("sp_inventory_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return this.InventoryRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private InventoryModel InventoryRead(SqlDataReader dataReader)
        {
            return new InventoryModel(id: Convert.ToInt32(dataReader["Id"]),
                                        title: dataReader["Title"].ToString(),
                                        group: dataReader["Group"].ToString(),
                                        keeper: dataReader["Keeper"].ToString(),
                                        description: dataReader["Description"].ToString(),
                                        active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<InventoryModel> IMain<InventoryModel>.Search(string text)
        {
            try
            {
                List<InventoryModel> inventories = new List<InventoryModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_inventory_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    inventories.Add(this.InventoryRead(dataReader));
                }
                return inventories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<InventoryModel> IMain<InventoryModel>.List(string inventory)
        {
            try
            {
                List<InventoryModel> list = new List<InventoryModel>();

                SqlDataReader dataReader = this.ReadProcedure("sp_inventory_read");
                while (dataReader.Read())
                {
                    list.Add(this.InventoryRead(dataReader));
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<ItemCategoryModel>.Insert(ItemCategoryModel itemCategory)
        {
            return this.RunProcedure("sp_itemcategory_insert", this.ItemCategoryInsertParameters(itemCategory), this.insertMessage);
        }

        private List<SqlParameter> ItemCategoryInsertParameters(ItemCategoryModel itemCategory)
        {
            return new List<SqlParameter>{ new SqlParameter("@title", itemCategory.Title),
          new SqlParameter("@description", itemCategory.Description),
          new SqlParameter("@active", itemCategory.Active)};
        }

        string IMain<ItemCategoryModel>.Update(ItemCategoryModel itemCategory)
        {
            return this.RunProcedure("sp_itemcategory_update", this.ItemCategoryInsertParameters(itemCategory).Concat(new[] { new SqlParameter("@id", itemCategory.Id) }).ToList(), this.updateMessage);
        }

        string IMain<ItemCategoryModel>.Delete(ItemCategoryModel itemCategory)
        {
            return this.RunProcedure("sp_itemcategory_delete", new List<SqlParameter> { new SqlParameter("@id", itemCategory.Id) }, this.deleteMessage);
        }

        ItemCategoryModel IMain<ItemCategoryModel>.Get(string title)
        {
            try
            {

                SqlDataReader dataReader = this.ReadProcedure("sp_itemcategory_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return this.ItemCategoryRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ItemCategoryModel ItemCategoryRead(SqlDataReader dataReader)
        {
            return new ItemCategoryModel(id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                description: dataReader["Description"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<ItemCategoryModel> IMain<ItemCategoryModel>.Search(string text)
        {
            try
            {
                List<ItemCategoryModel> itemCategories = new List<ItemCategoryModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_itemCategory_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    itemCategories.Add(this.ItemCategoryRead(dataReader));
                }
                return itemCategories;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        List<ItemCategoryModel> IMain<ItemCategoryModel>.List(string itemCategory)
        {
            try
            {
                List<ItemCategoryModel> itemCategories = new List<ItemCategoryModel>();

                SqlDataReader dataReader = this.ReadProcedure("sp_itemcategory_read");
                while (dataReader.Read())
                {
                    itemCategories.Add(this.ItemCategoryRead(dataReader));
                }
                return itemCategories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<ItemModel>.Insert(ItemModel item)
        {
            return this.RunProcedure("sp_item_insert", this.ItemInsertParameters(item), this.insertMessage);
        }

        private List<SqlParameter> ItemInsertParameters(ItemModel item)
        {
            return new List<SqlParameter>{
                new SqlParameter("@barcode", item.Barcode),
                new SqlParameter("@plumemory",item.Memory),
                new SqlParameter("@name", item.Name),
                new SqlParameter("@category", item.Category),
                new SqlParameter("@department", item.Department),
                new SqlParameter("@weighed", item.Weighed),
                new SqlParameter("@buyprice", item.BuyPrice),
                new SqlParameter("@sellprice", item.SellPrice),
                new SqlParameter("@active", item.Active)};
        }

        string IMain<ItemModel>.Update(ItemModel item)
        {
            return this.RunProcedure("sp_item_update", this.ItemInsertParameters(item).Concat(new[] { new SqlParameter("@id", item.Id) }).ToList(), this.updateMessage);
        }

        string IMain<ItemModel>.Delete(ItemModel item)
        {
            return this.RunProcedure("sp_item_delete", new List<SqlParameter> { new SqlParameter("@id", item.Id) }, this.deleteMessage);
        }

        ItemModel IMain<ItemModel>.Get(string title)
        {
            return GetItemByName(title);
        }

        private ItemModel GetItemByName(string title)
        {
            try
            {

                SqlDataReader dataReader = this.ReadProcedure("sp_item_get", new List<SqlParameter> { new SqlParameter("@name", title) });
                dataReader.Read();
                return this.ItemRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ItemModel ItemRead(SqlDataReader dataReader)
        {
            if (dataReader.HasRows)
            {
                return new ItemModel(id: Convert.ToInt32(dataReader["Id"]),
                code: this.IntChecker(dataReader, "Code"),
                barcode: dataReader["Barcode"].ToString(),
                name: dataReader["Name"].ToString(),
                department: dataReader["Department"].ToString(),
                category: dataReader["Category"].ToString(),
                buyPrice: LongChecker(dataReader, "BuyPrice"),
                sellPrice: LongChecker(dataReader, "SellPrice"),
                stock: DecimalChecker(dataReader, "Stock"),
                active: Convert.ToBoolean(dataReader["Active"]),
                weighed: Convert.ToBoolean(dataReader["Weighed"].ToString()),
                plumemory: this.IntChecker(dataReader, "Memory"));
            }
            else
                return null;
        }

        private decimal DecimalChecker(SqlDataReader dataReader, string column)
        {
            if (dataReader[column].GetType() == typeof(DBNull))
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(dataReader[column].ToString());
            }

        }

        List<ItemModel> IMain<ItemModel>.Search(string text)
        {
            try
            {
                List<ItemModel> items = new List<ItemModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_item_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    items.Add(this.ItemRead(dataReader));
                }
                this.Dispose();
                return items;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        List<ItemModel> IMain<ItemModel>.List(string item)
        {
            // try
            // {
            List<ItemModel> items = new List<ItemModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_item_read");
            while (dataReader.Read())
            {
                items.Add(this.ItemRead(dataReader));
            }
            return items;
            //  }
            //  catch (Exception)
            //  {

            //      throw;
            //  }
        }

        string IMain<PaymentMethodModel>.Insert(PaymentMethodModel paymentMethod)
        {
            return this.RunProcedure("sp_paymentmethod_insert", this.PaymentMethodInsertParameters(paymentMethod), this.insertMessage);
        }

        private List<SqlParameter> PaymentMethodInsertParameters(PaymentMethodModel paymentMethod)
        {
            return new List<SqlParameter>{  new SqlParameter("@paymentType", paymentMethod.PaymentType),
           new SqlParameter("@title", paymentMethod.Title),
           new SqlParameter("@pos", paymentMethod.Pos),
           new SqlParameter("@active", paymentMethod.Active)};
        }

        string IMain<PaymentMethodModel>.Update(PaymentMethodModel paymentMethod)
        {
            return this.RunProcedure("sp_paymentmethod_update", this.PaymentMethodInsertParameters(paymentMethod).Concat(new[] { new SqlParameter("@id", paymentMethod.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PaymentMethodModel>.Delete(PaymentMethodModel paymentMethod)
        {
            return this.RunProcedure("sp_paymentmethod_delete", new List<SqlParameter> { new SqlParameter("@id", paymentMethod.Id) }, this.deleteMessage);
        }

        PaymentMethodModel IMain<PaymentMethodModel>.Get(string title)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_paymentmethod_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return this.PaymentMethodRead(dataReader);
            }
            catch (Exception)
            {
                throw;
            }
        }

        List<PaymentMethodModel> IMain<PaymentMethodModel>.Search(string text)
        {
            try
            {
                List<PaymentMethodModel> paymentMethods = new List<PaymentMethodModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_paymentMethod_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    paymentMethods.Add(this.PaymentMethodRead(dataReader));
                }
                return paymentMethods;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private PaymentMethodModel PaymentMethodRead(SqlDataReader dataReader)
        {
            return new PaymentMethodModel(
                id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                paymentType: dataReader["PaymentType"].ToString(),
                pos: dataReader["PosTitle"].ToString(),
                posCom: IntChecker(dataReader, "PosCom"),
               active: Convert.ToBoolean(dataReader["Active"]));
        }

        private int IntChecker(SqlDataReader dataReader, string column)
        {
            if (dataReader[column].GetType() == typeof(DBNull))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(dataReader[column]);
            }
        }

        List<PaymentMethodModel> IMain<PaymentMethodModel>.List(string paymentMethod)
        {
            try
            {
                List<PaymentMethodModel> paymentMethods = new List<PaymentMethodModel>();

                SqlDataReader dataReader = this.ReadProcedure("sp_paymentmethod_read");
                while (dataReader.Read())
                {
                    paymentMethods.Add(this.PaymentMethodRead(dataReader));
                }
                return paymentMethods;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<PaymentTypeModel>.Insert(PaymentTypeModel paymentType)
        {
            return this.RunProcedure("sp_paymenttype_insert", this.PaymentTypeInsertParameters(paymentType), this.insertMessage);
        }

        private List<SqlParameter> PaymentTypeInsertParameters(PaymentTypeModel paymentType)
        {
            return new List<SqlParameter>{  new SqlParameter("@title", paymentType.Title),
           new SqlParameter("@active", paymentType.Active)};
        }

        string IMain<PaymentTypeModel>.Update(PaymentTypeModel paymentType)
        {
            return this.RunProcedure("sp_paymenttype_update", this.PaymentTypeInsertParameters(paymentType).Concat(new[] { new SqlParameter("@id", paymentType.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PaymentTypeModel>.Delete(PaymentTypeModel paymentType)
        {
            return this.RunProcedure("sp_paymenttype_delete", new List<SqlParameter> { new SqlParameter("@id", paymentType.Id) }, this.deleteMessage);
        }

        PaymentTypeModel IMain<PaymentTypeModel>.Get(string title)
        {
            try
            {

                SqlDataReader dataReader = this.ReadProcedure("sp_paymenttype_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                return this.PaymentTypeRead(dataReader);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private PaymentTypeModel PaymentTypeRead(SqlDataReader dataReader)
        {
            return new PaymentTypeModel(
                id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<PaymentTypeModel> IMain<PaymentTypeModel>.Search(string text)
        {
            try
            {
                List<PaymentTypeModel> paymentTypes = new List<PaymentTypeModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_paymentType_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    paymentTypes.Add(this.PaymentTypeRead(dataReader));
                }
                return paymentTypes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<PaymentTypeModel> IMain<PaymentTypeModel>.List(string paymentType)
        {
            try
            {
                List<PaymentTypeModel> paymentTypes = new List<PaymentTypeModel>();

                SqlDataReader dataReader = this.ReadProcedure("sp_paymenttype_read");
                while (dataReader.Read())
                {
                    paymentTypes.Add(this.PaymentTypeRead(dataReader));
                }
                return paymentTypes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<PersonGroupModel>.Insert(PersonGroupModel personGroup)
        {
            return this.RunProcedure("sp_persongroup_insert", this.PersonGroupInsertParameters(personGroup), this.insertMessage);
        }

        private List<SqlParameter> PersonGroupInsertParameters(PersonGroupModel personGroup)
        {
            return new List<SqlParameter> { new SqlParameter("@title", personGroup.Title),
            new SqlParameter("@description", personGroup.Description),
            new SqlParameter("@active", personGroup.Active)};
        }

        string IMain<PersonGroupModel>.Update(PersonGroupModel personGroup)
        {
            return this.RunProcedure("sp_paymenttype_update", this.PersonGroupInsertParameters(personGroup).Concat(new[] { new SqlParameter("@id", personGroup.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PersonGroupModel>.Delete(PersonGroupModel personGroup)
        {
            return this.RunProcedure("sp_persongroup_delete", new List<SqlParameter> { new SqlParameter("@id", personGroup.Id) }, this.deleteMessage);
        }

        PersonGroupModel IMain<PersonGroupModel>.Get(string title)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_persongroup_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return PersonGroupRead(dataReader);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private PersonGroupModel PersonGroupRead(SqlDataReader dataReader)
        {
            PersonGroupModel tmp = new PersonGroupModel(
                id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                description: dataReader["Description"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
            return tmp;
        }

        List<PersonGroupModel> IMain<PersonGroupModel>.Search(string text)
        {
            try
            {
                List<PersonGroupModel> personGroups = new List<PersonGroupModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_personGroup_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    personGroups.Add(this.PersonGroupRead(dataReader));
                }
                return personGroups;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<PersonGroupModel> IMain<PersonGroupModel>.List(string text)
        {
            try
            {
                List<PersonGroupModel> list = new List<PersonGroupModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_persongroup_read");
                while (dataReader.Read())
                {
                    list.Add(this.PersonGroupRead(dataReader));
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        string IMain<PersonModel>.Insert(PersonModel person)
        {
            return this.RunProcedure("sp_person_insert", this.PersonInsertParameters(person), this.insertMessage);
        }

        private List<SqlParameter> PersonInsertParameters(PersonModel person)
        {
            return new List<SqlParameter> {  new SqlParameter("@persongroup", person.PersonGroup),
                new SqlParameter("@name", person.Name),
                new SqlParameter("@mobilenumber", person.MobileNumber),
                new SqlParameter("@address", person.Address)};
        }

        string IMain<PersonModel>.Update(PersonModel person)
        {
            return this.RunProcedure("sp_person_update", this.PersonInsertParameters(person).Concat(new[] { new SqlParameter("@id", person.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PersonModel>.Delete(PersonModel person)
        {
            return this.RunProcedure("sp_person_delete", new List<SqlParameter> { new SqlParameter("@id", person.Id) }, this.deleteMessage);
        }

        PersonModel IMain<PersonModel>.Get(string nickname)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_person_get", new List<SqlParameter> { new SqlParameter("@nickname", nickname) });
                dataReader.Read();
                return PersonRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private PersonModel PersonRead(SqlDataReader dataReader)
        {
            return new PersonModel(
                balance: this.LongChecker(dataReader, "balance"),
                id: Convert.ToInt32(dataReader["Id"]),
                code: dataReader["Code"].ToString(),
                totalsales: this.LongChecker(dataReader, "TotalSales"),
                totalvisits: this.IntChecker(dataReader, "TotalVisits"),
                personGroup: dataReader["PersonGroup"].ToString(),
                name: dataReader["Name"].ToString(),
                mobileNumber: dataReader["MobileNumber"].ToString(),
                address: dataReader["Address"].ToString());
        }

        List<PersonModel> IMain<PersonModel>.Search(string text)
        {
            try
            {
                List<PersonModel> persons = new List<PersonModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_person_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    persons.Add(this.PersonRead(dataReader));
                }
                return persons;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<PersonModel> IMain<PersonModel>.List(string person)
        {
            try
            {
                List<PersonModel> list = new List<PersonModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_person_read");
                while (dataReader.Read())
                {
                    list.Add(this.PersonRead(dataReader));
                }
                return list;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        string IMain<PluModel>.Insert(PluModel plu)
        {
            return this.RunProcedure("sp_plu_insert", this.PluInsertParameters(plu), this.insertMessage);
        }

        private List<SqlParameter> PluInsertParameters(PluModel plu)
        {
            return new List<SqlParameter>
            {
             new  SqlParameter ("@item", plu.Item.Id),
           new SqlParameter ("@memory", plu.Memory),
           new SqlParameter ("@workstation", plu.Workstation)
            };
        }

        string IMain<PluModel>.Update(PluModel plu)
        {
            return this.RunProcedure("sp_paymenttype_update", this.PluInsertParameters(plu).Concat(new[] { new SqlParameter("@id", plu.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PluModel>.Delete(PluModel plu)
        {
            return this.RunProcedure("sp_plu_delete", new List<SqlParameter> { new SqlParameter("@workstation", plu.Workstation) }, this.deleteMessage);
        }

        PluModel IMain<PluModel>.Get(string model)
        {
            throw new NotImplementedException();
        }

        List<PluModel> IMain<PluModel>.Search(string text)
        {
            throw new NotImplementedException();
        }

        List<PluModel> IMain<PluModel>.List(string text)
        {
            try
            {
                List<PluModel> plus = new List<PluModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_plu_read", new List<SqlParameter> { new SqlParameter("@workstation", text) });
                while (dataReader.Read())
                {
                    plus.Add(this.PluRead(dataReader));
                }
                return plus;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private PluModel PluRead(SqlDataReader dataReader)
        {
            return new PluModel(id: Convert.ToInt32(dataReader["Id"]),
                item: this.GetItemByName(dataReader["Item"].ToString()),
                workstation: dataReader["Workstation"].ToString(),
                memory: this.IntChecker(dataReader, "Memory"));
        }

        string IMain<PosInfoModel>.Insert(PosInfoModel model)
        {
            return this.RunProcedure("sp_posinfo_insert", this.PosInfoInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> PosInfoInsertParameters(PosInfoModel model)
        {
            return new List<SqlParameter>
           {
              new SqlParameter ("@title", model.Title),
              new SqlParameter  ("@com", model.Com)
            };
        }

        string IMain<PosInfoModel>.Update(PosInfoModel model)
        {
            return this.RunProcedure("sp_posinfo_update", this.PosInfoInsertParameters(model).Concat(new[] { new SqlParameter("@id", model.Id) }).ToList(), this.updateMessage);
        }

        string IMain<PosInfoModel>.Delete(PosInfoModel model)
        {
            return this.RunProcedure("sp_posinfo_delete", new List<SqlParameter> { new SqlParameter("@id", model.Id) }, this.deleteMessage);
        }

        PosInfoModel IMain<PosInfoModel>.Get(string model)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_posinfo_get", new List<SqlParameter> { new SqlParameter("@title", model) });
                dataReader.Read();
                return this.PosInfoRead(dataReader);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private PosInfoModel PosInfoRead(SqlDataReader dataReader)
        {
            return new PosInfoModel(
                id: Convert.ToInt32(dataReader["Id"]),
               title: dataReader["Title"].ToString(),
               com: this.IntChecker(dataReader, "Com"));
        }

        List<PosInfoModel> IMain<PosInfoModel>.Search(string text)
        {
            try
            {
                List<PosInfoModel> posInfos = new List<PosInfoModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_posinfo_search");
                while (dataReader.Read())
                {
                    posInfos.Add(this.PosInfoRead(dataReader));
                }
                return posInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<PosInfoModel> IMain<PosInfoModel>.List(string model)
        {
            try
            {
                List<PosInfoModel> posInfos = new List<PosInfoModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_posinfo_read");
                while (dataReader.Read())
                {
                    posInfos.Add(this.PosInfoRead(dataReader));
                }
                return posInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<RegisterModel>.Insert(RegisterModel register)
        {
            return this.RunProcedure("sp_register_insert", this.RegisterInsertParameters(register), this.insertMessage);
        }

        private List<SqlParameter> RegisterInsertParameters(RegisterModel register)
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@title", register.Title),
            new SqlParameter("@computerName", register.ComputerName),
            new SqlParameter("@ipAddress", register.IpAddress),
            new SqlParameter("@mac_address", register.MacAddress),
            new SqlParameter("@description", register.Description),
            new SqlParameter("@active", register.Active)
            };
        }

        string IMain<RegisterModel>.Update(RegisterModel register)
        {
            return this.RunProcedure("sp_register_update", this.RegisterInsertParameters(register).Concat(new[] { new SqlParameter("@id", register.Id) }).ToList(), this.updateMessage);
        }

        string IMain<RegisterModel>.Delete(RegisterModel register)
        {
            return this.RunProcedure("sp_register_delete", new List<SqlParameter> { new SqlParameter("@id", register.Id) }, this.deleteMessage);
        }

        RegisterModel IMain<RegisterModel>.Get(string register)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_register_get", new List<SqlParameter> { new SqlParameter("@title", register) });
                dataReader.Read();
                return this.RegisterRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private RegisterModel RegisterRead(SqlDataReader dataReader)
        {
            return new RegisterModel(
                id: Convert.ToInt32(dataReader["Id"]),
                computerName: dataReader["ComputerName"].ToString(),
                title: dataReader["Title"].ToString(),
                ipAddress: dataReader["IpAddress"].ToString(),
                macAddress: dataReader["MacAddress"].ToString(),
                description: dataReader["Description"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<RegisterModel> IMain<RegisterModel>.Search(string text)
        {
            try
            {
                List<RegisterModel> registers = new List<RegisterModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_register_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    registers.Add(this.RegisterRead(dataReader));
                }
                return registers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<RegisterModel> IMain<RegisterModel>.List(string model)
        {
            try
            {
                List<RegisterModel> registers = new List<RegisterModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_register_read");
                while (dataReader.Read())
                {
                    registers.Add(this.RegisterRead(dataReader));
                }
                return registers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<SupplierAgentModel>.Insert(SupplierAgentModel supplierAgent)
        {
            return this.RunProcedure("sp_paymenttype_update", SupplierInsertParameters(supplierAgent), this.updateMessage);
        }

        private List<SqlParameter> SupplierInsertParameters(SupplierAgentModel supplierAgent)
        {
            return this.PersonInsertParameters(supplierAgent).Concat(new[] { new SqlParameter("@company", supplierAgent.Company) }).ToList();
        }

        string IMain<SupplierAgentModel>.Update(SupplierAgentModel supplierAgent)
        {
            return this.RunProcedure("sp_supplier_update", this.SupplierInsertParameters(supplierAgent).Concat(new[] { new SqlParameter("@id", supplierAgent.Id) }).ToList(), this.updateMessage);
        }

        string IMain<SupplierAgentModel>.Delete(SupplierAgentModel supplierAgent)
        {
            return this.RunProcedure("sp_supplier_delete", new List<SqlParameter> { new SqlParameter("@id", supplierAgent.Id) }, this.deleteMessage);
        }

        SupplierAgentModel IMain<SupplierAgentModel>.Get(string model)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_supplier_get", new List<SqlParameter> { new SqlParameter("@title", model) });
                dataReader.Read();
                return this.SupplierRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private SupplierAgentModel SupplierRead(SqlDataReader dataReader)
        {
            return new SupplierAgentModel(
                id: Convert.ToInt32(dataReader["Id"]),
                code: dataReader["Code"].ToString(),
                company: dataReader["Company"].ToString(),
                personGroup: dataReader["PersonGroup"].ToString(),
                name: dataReader["Name"].ToString(),
                mobileNumber: dataReader["MobileNumber"].ToString(),
                address: dataReader["address"].ToString(),
                balance: this.LongChecker(dataReader, "balance"));
        }

        List<SupplierAgentModel> IMain<SupplierAgentModel>.Search(string model)
        {
            try
            {
                List<SupplierAgentModel> supplierAgents = new List<SupplierAgentModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_supplier_search", new List<SqlParameter> { new SqlParameter("@text", model) });
                while (dataReader.Read())
                {
                    supplierAgents.Add(this.SupplierRead(dataReader));
                }
                return supplierAgents;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<SupplierAgentModel> IMain<SupplierAgentModel>.List(string model)
        {
            try
            {
                List<SupplierAgentModel> supplierAgents = new List<SupplierAgentModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_supplier_read");
                while (dataReader.Read())
                {
                    supplierAgents.Add(this.SupplierRead(dataReader));
                }
                return supplierAgents;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<SupplierCompanyModel>.Insert(SupplierCompanyModel supplierCompany)
        {
            return this.RunProcedure("sp_suppliercompany_insert", this.SupplierCompanyInsertParameters(supplierCompany), this.insertMessage);
        }

        private List<SqlParameter> SupplierCompanyInsertParameters(SupplierCompanyModel supplierCompany)
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@name", supplierCompany.Name),
            new SqlParameter("@active", supplierCompany.Active)
            };
        }

        string IMain<SupplierCompanyModel>.Update(SupplierCompanyModel supplierCompany)
        {
            return this.RunProcedure("sp_suppliercompany_update", this.SupplierCompanyInsertParameters(supplierCompany).Concat(new[] { new SqlParameter("@id", supplierCompany.Id) }).ToList(), this.updateMessage);
        }

        string IMain<SupplierCompanyModel>.Delete(SupplierCompanyModel supplierCompany)
        {
            return this.RunProcedure("sp_suppliercompany_delete", new List<SqlParameter> { new SqlParameter("@id", supplierCompany.Id) }, this.deleteMessage);
        }

        SupplierCompanyModel IMain<SupplierCompanyModel>.Get(string supplierCompany)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_suppliercompany_get", new List<SqlParameter> { new SqlParameter("@name", supplierCompany) });
                dataReader.Read();
                return this.SupplierCompanyRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private SupplierCompanyModel SupplierCompanyRead(SqlDataReader dataReader)
        {
            return new SupplierCompanyModel(
                id: Convert.ToInt32(dataReader["Id"]),
                name: dataReader["Name"].ToString(),
                Convert.ToBoolean(dataReader["Active"]));
        }

        List<SupplierCompanyModel> IMain<SupplierCompanyModel>.Search(string text)
        {
            try
            {
                List<SupplierCompanyModel> supplierCompanies = new List<SupplierCompanyModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_register_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    supplierCompanies.Add(this.SupplierCompanyRead(dataReader));
                }
                return supplierCompanies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<SupplierCompanyModel> IMain<SupplierCompanyModel>.List(string model)
        {
            try
            {
                List<SupplierCompanyModel> supplierCompanies = new List<SupplierCompanyModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_suppliercompany_read");
                while (dataReader.Read())
                {
                    supplierCompanies.Add(this.SupplierCompanyRead(dataReader));
                }
                return supplierCompanies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<TransactionTypeModel>.Insert(TransactionTypeModel transactionType)
        {
            return this.RunProcedure("sp_transactiontype_insert", this.TransactionTypeInsertParameters(transactionType), this.insertMessage);
        }

        private List<SqlParameter> TransactionTypeInsertParameters(TransactionTypeModel transactionType)
        {
            return new List<SqlParameter>
            {
              new SqlParameter  ("@title", transactionType.Title),
              new SqlParameter  ("@description", transactionType.Description),
              new SqlParameter ("@active", transactionType.Active)
        };
        }

        string IMain<TransactionTypeModel>.Update(TransactionTypeModel transactionType)
        {
            return this.RunProcedure("sp_transactiontype_update", this.TransactionTypeInsertParameters(transactionType).Concat(new[] { new SqlParameter("@id", transactionType.Id) }).ToList(), this.updateMessage);
        }

        string IMain<TransactionTypeModel>.Delete(TransactionTypeModel transactionType)
        {
            return this.RunProcedure("sp_transactionType_delete", new List<SqlParameter> { new SqlParameter("@id", transactionType.Id) }, this.deleteMessage);
        }

        TransactionTypeModel IMain<TransactionTypeModel>.Get(string transactionType)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_transactionType_get", new List<SqlParameter> { new SqlParameter("@title", transactionType) });
                dataReader.Read();
                return this.TransactionTypeRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private TransactionTypeModel TransactionTypeRead(SqlDataReader dataReader)
        {
            return new TransactionTypeModel(id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                description: dataReader["Description"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]));
        }

        List<TransactionTypeModel> IMain<TransactionTypeModel>.Search(string text)
        {
            try
            {
                List<TransactionTypeModel> transactionTypes = new List<TransactionTypeModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_transactionType_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    transactionTypes.Add(this.TransactionTypeRead(dataReader));
                }
                return transactionTypes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<TransactionTypeModel> IMain<TransactionTypeModel>.List(string model)
        {
            try
            {
                List<TransactionTypeModel> transactionTypes = new List<TransactionTypeModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_transactionType_read");
                while (dataReader.Read())
                {
                    transactionTypes.Add(this.TransactionTypeRead(dataReader));
                }
                return transactionTypes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<UserModel>.Insert(UserModel user)
        {
            return this.RunProcedure("sp_user_insert", this.UserInsertParameters(user), this.insertMessage);
        }

        private List<SqlParameter> UserInsertParameters(UserModel user)
        {
            return this.PersonInsertParameters(user).Concat(new[] {  new SqlParameter ("@role", user.Role),
           new SqlParameter ("@username", user.UserName),
           new SqlParameter ("@password", user.Password)}).ToList();

        }

        string IMain<UserModel>.Update(UserModel user)
        {
            return this.RunProcedure("sp_user_update", this.UserInsertParameters(user).Concat(new[] { new SqlParameter("@id", user.Id) }).ToList(), this.updateMessage);
        }

        string IMain<UserModel>.Delete(UserModel user)
        {
            return this.RunProcedure("sp_user_delete", new List<SqlParameter> { new SqlParameter("@id", user.Id) }, this.deleteMessage);
        }

        UserModel IMain<UserModel>.Get(string user)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_user_get", new List<SqlParameter> { new SqlParameter("@title", user) });
                return this.UserRead(dataReader);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private UserModel UserRead(SqlDataReader dataReader)
        {
            return new UserModel(id: Convert.ToInt32(dataReader["Id"]),
               code: dataReader["Code"].ToString(),
               name: dataReader["Name"].ToString(),
              mobileNumber: dataReader["MobileNumber"].ToString(),
              role: dataReader["Role"].ToString(),
              userName: dataReader["Username"].ToString(),
              password: dataReader["Password"].ToString(),
              balance: this.LongChecker(dataReader, "balance"),
              address: dataReader["address"].ToString());
        }

        List<UserModel> IMain<UserModel>.Search(string text)
        {
            try
            {
                List<UserModel> users = new List<UserModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_register_read");
                while (dataReader.Read())
                {
                    users.Add(this.UserRead(dataReader));
                }
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<UserModel> IMain<UserModel>.List(string model)
        {
            try
            {
                List<UserModel> users = new List<UserModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_user_read");
                while (dataReader.Read())
                {
                    users.Add(this.UserRead(dataReader));
                }
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<UserRoleModel>.Insert(UserRoleModel userRole)
        {
            return this.RunProcedure("sp_userrole_insert", this.UserRoleInsertParameters(userRole), this.insertMessage);
        }

        private List<SqlParameter> UserRoleInsertParameters(UserRoleModel userRole)
        {
            return new List<SqlParameter>
            {
                new SqlParameter("@info", userRole.Info),
            new SqlParameter("@title", userRole.Title),
            new SqlParameter("@active",userRole.Active),
            new SqlParameter("@description",userRole.Description),
            new SqlParameter("@cashierRibbon", userRole.CashierRibbon)
        };
        }

        string IMain<UserRoleModel>.Update(UserRoleModel userRole)
        {
            return this.RunProcedure("sp_userrole_update", this.UserRoleInsertParameters(userRole).Concat(new[] { new SqlParameter("@id", userRole.Id) }).ToList(), this.updateMessage);
        }

        string IMain<UserRoleModel>.Delete(UserRoleModel userRole)
        {
            return this.RunProcedure("sp_userrole_delete", new List<SqlParameter> { new SqlParameter("@id", userRole.Id) }, this.deleteMessage);
        }

        UserRoleModel IMain<UserRoleModel>.Get(string userRole)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_userrole_get", new List<SqlParameter> { new SqlParameter("@title", userRole) });
                dataReader.Read();
                return this.UserRoleRead(dataReader);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private UserRoleModel UserRoleRead(SqlDataReader dataReader)
        {
            //dataReader.Read();
            return new UserRoleModel(id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                description: dataReader["Description"].ToString(),
                info: dataReader["info"].ToString(),
                active: Convert.ToBoolean(dataReader["Active"]),
                cashierRibbon: dataReader["CashierRibbon"].ToString());
        }

        List<UserRoleModel> IMain<UserRoleModel>.Search(string model)
        {
            try
            {
                List<UserRoleModel> roles = new List<UserRoleModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_register_read");
                while (dataReader.Read())
                {
                    roles.Add(this.UserRoleRead(dataReader));
                }
                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<UserRoleModel> IMain<UserRoleModel>.List(string model)
        {
            try
            {
                List<UserRoleModel> userRoles = new List<UserRoleModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_userrole_read");
                while (dataReader.Read())
                {
                    userRoles.Add(this.UserRoleRead(dataReader));
                }
                return userRoles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IUserSettings.Insert(UserSettingsModel model)
        {
            return this.RunProcedure("sp_usersettings_insert", this.UserSettingsInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> UserSettingsInsertParameters(UserSettingsModel model)
        {
            return new List<SqlParameter>
           {
             new SqlParameter  ("@userrole", model.Role),
           new SqlParameter ("@cashierRibbon", model.CashierRibbon)
           };
        }

        UserSettingsModel IUserSettings.Get(UserSettingsModel model)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_persongroup_read", new List<SqlParameter> { new SqlParameter("@userrole", model.Role) });
                return this.UserSettingsRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }
        }

        string IMain<WorkstationModel>.Insert(WorkstationModel workstation)
        {
            return this.RunProcedure("sp_workstation_insert", this.WorkstationInsertParameters(workstation), this.insertMessage);
        }

        private List<SqlParameter> WorkstationInsertParameters(WorkstationModel workstation)
        {
            return new List<SqlParameter>
           {
               new SqlParameter("@title", workstation.Title),
            new SqlParameter("@department", workstation.Department),
            new SqlParameter("@ipAddress", workstation.IpAddress),
            new SqlParameter("@portNumber", workstation.PortNumber)
           };
        }

        string IMain<WorkstationModel>.Update(WorkstationModel workstation)
        {
            return this.RunProcedure("sp_workstation_update", this.WorkstationInsertParameters(workstation).Concat(new[] { new SqlParameter("@id", workstation.Id) }).ToList(), this.updateMessage);
        }

        string IMain<WorkstationModel>.Delete(WorkstationModel workstation)
        {
            return this.RunProcedure("sp_workstation_delete", new List<SqlParameter> { new SqlParameter("@id", workstation.Id) }, this.deleteMessage);
        }

        WorkstationModel IMain<WorkstationModel>.Get(string text)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_workstation_get", new List<SqlParameter> { new SqlParameter("@title", text) });
                dataReader.Read();
                return this.WorkstationRead(dataReader);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private WorkstationModel WorkstationRead(SqlDataReader dataReader)
        {
            return new WorkstationModel(
                id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                department: dataReader["Department"].ToString(),
                ipAddress: dataReader["IpAddress"].ToString(),
                portNumber: this.IntChecker(dataReader, "PortNumber"),
                lastTotalPrice: this.LongChecker(dataReader, "LastTotalPrice"));
        }

        List<WorkstationModel> IMain<WorkstationModel>.Search(string text)
        {
            try
            {
                List<WorkstationModel> workstations = new List<WorkstationModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_workstation_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    workstations.Add(this.WorkstationRead(dataReader));
                }
                this.Dispose();
                return workstations;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<WorkstationModel> IMain<WorkstationModel>.List(string model)
        {
            try
            {
                List<WorkstationModel> workstations = new List<WorkstationModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_workstation_read");
                while (dataReader.Read())
                {
                    workstations.Add(this.WorkstationRead(dataReader));
                }
                return workstations;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<TransactionModel> ITransaction.Read()
        {
            throw new NotImplementedException();
        }

        private List<SqlParameter> TransactionInsertParameters(TransactionModel model)
        {
            return new List<SqlParameter>
           {
             new SqlParameter  ("@batchuser", model.BatchUser),
           new SqlParameter ("@batchregister", model.BatchRegister),
           new SqlParameter  ("@io", model.Io),
           new SqlParameter ("@transactiontype", model.TransactionType),
           new SqlParameter  ("@paymentmethod", model.PaymentMethod),
           new SqlParameter ("@person", model.Person),
           new SqlParameter("total",model.TotalValue),
           new SqlParameter  ("@credit", model.Credit),
           new SqlParameter ("@paid", model.PaidValue),
           new SqlParameter("description",model.Description)
           };
        }
        List<TransactionModel> IBaseTransaction<TransactionModel>.Search(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<TransactionModel>.Insert(TransactionModel model)
        {
            return this.RunProcedure("sp_transaction_main_insert", this.TransactionInsertParameters(model), this.insertMessage);
        }


        List<PaymentTransactionModel> IBaseTransaction<PaymentTransactionModel>.Search(PaymentTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<PaymentTransactionModel>.Insert(PaymentTransactionModel model)
        {
            return this.RunProcedure("sp_transaction_payment_insert", this.PaymentTransactionInsert(model), this.insertMessage);
        }

        private List<SqlParameter> PaymentTransactionInsert(PaymentTransactionModel model)
        {
            return new List<SqlParameter>
           {
             new SqlParameter  ("@batchuser", model.BatchUser),
           new SqlParameter ("@batchregister", model.BatchRegister),
           new SqlParameter  ("@io", model.Io),
           new SqlParameter  ("@paymentmethod", model.PaymentMethod),
           new SqlParameter ("@person", model.Person),
           new SqlParameter("@total",model.Value),
           new SqlParameter("description",model.Description)
           };
        }
        List<PayoutTransactionModel> IPayoutTransaction.Read(PayoutTransactionModel payoutTransaction)
        {
            List<PayoutTransactionModel> payoutTransactions = new List<PayoutTransactionModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_transaction_payout_list", new List<SqlParameter> {
            new SqlParameter("@startdate",payoutTransaction.StartDate),
            new SqlParameter("@enddate",payoutTransaction.EndDate)});
           
            while (dataReader.Read())
            {
                payoutTransactions.Add(this.PayoutTransactionRead(dataReader));
            }
            return payoutTransactions;
        }

        private PayoutTransactionModel PayoutTransactionRead(SqlDataReader dataReader)
        {
            return new PayoutTransactionModel(id: Convert.ToInt32(dataReader["Id"]),
               batchUser: dataReader["Name"].ToString(),
               batchRegister: dataReader["BatchRegister"].ToString(),
               batch: Convert.ToInt32(dataReader["Batch"]),
               value: long.Parse(dataReader["Value"].ToString()),
               description: dataReader["Description"].ToString(),
               recordTime: Convert.ToDateTime(dataReader["RecordTime"]),
               serial: dataReader["Serial"].ToString(),
               person: dataReader["Name"].ToString()
                );
        }

        List<PayoutTransactionModel> IBaseTransaction<PayoutTransactionModel>.Search(PayoutTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<PayoutTransactionModel>.Insert(PayoutTransactionModel model)
        {
            return RunProcedure("sp_transaction_payout_insert", this.PayoutTransactionInsertParameters(model), this.insertMessage);
        }

        private List<SqlParameter> PayoutTransactionInsertParameters(PayoutTransactionModel model)
        {
            return new List<SqlParameter>
           {
             new SqlParameter  ("@batchuser", model.BatchUser),
           new SqlParameter ("@batchregister", model.BatchRegister),
           new SqlParameter ("@person", model.Person),
           new SqlParameter("description",model.Description),
           new SqlParameter("total",model.Value),
           };
        }

        List<ItemModel> IItem.FilterByDepartment(string department)
        {
            try
            {
                List<ItemModel> items = new List<ItemModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_Item_Filter_Department", new List<SqlParameter> { new SqlParameter("department", department) });
                while (dataReader.Read())
                {
                    items.Add(this.ItemRead(dataReader));
                }
                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<ItemModel> IItem.SearchFilterByDepartment(ItemModel item)
        {
            try
            {
                List<ItemModel> items = new List<ItemModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_Item_Filter_Department_search", new List<SqlParameter> { new SqlParameter("department", item.Department), new SqlParameter("@text", item.Name) });
                while (dataReader.Read())
                {
                    items.Add(this.ItemRead(dataReader));
                }
                this.Dispose();
                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        long IWorkstation.TotalReceiptAmount(string workstation)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_workstation_receipt_totalamount", new List<SqlParameter> { new SqlParameter("@workstation", workstation) });
            dataReader.Read();
            return this.LongChecker(dataReader, "total");
        }

        int IWorkstation.TotalReceiptCount(string workstation)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_workstation_receipt_totalcount", new List<SqlParameter> { new SqlParameter("@workstation", workstation) });
            dataReader.Read();
            return this.IntChecker(dataReader, "total");
        }

        long IWorkstation.TotalReceiptAmountForDate(ReceiptModel receipt)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_workstation_receipt_day_totalamount", new List<SqlParameter> { new SqlParameter("@workstation", receipt.Workstation), new SqlParameter("@date", receipt.Time) });
            dataReader.Read();
            return this.LongChecker(dataReader, "total");
        }

        int IWorkstation.TotalReceiptCountForDate(ReceiptModel receipt)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_workstation_receipt_day_totalcount", new List<SqlParameter> { new SqlParameter("@workstation", receipt.Workstation), new SqlParameter("@date", receipt.Time) });
            dataReader.Read();
            return this.IntChecker(dataReader, "total");
        }

        UserModel IAuthentication.Login(UserModel user)
        {
            UserModel loggedUser;
            SqlDataReader dataReader = this.ReadProcedure("sp_user_login", new List<SqlParameter> { new SqlParameter("@username", user.UserName) });
            dataReader.Read();
            if (!dataReader.HasRows)
            {
                throw new Exception("کاربر یافت نشد");
            }
            else
            {
                loggedUser = this.UserRead(dataReader);
                if (user.Password != loggedUser.Password)
                {
                    throw new Exception("نام کاربری یا رمز عبور نادرست است");
                }
            }
            return loggedUser;
        }

        UserSettingsModel IAuthentication.GetUserSettings(UserRoleModel userRole)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_userSettings_Read", new List<SqlParameter> { new SqlParameter("@userrole", userRole.Id) });
            dataReader.Read();
            return this.UserSettingsRead(dataReader);
        }

        private UserSettingsModel UserSettingsRead(SqlDataReader dataReader)
        {
            return new UserSettingsModel(Convert.ToInt32(dataReader["id"]),
                dataReader["UserRole"].ToString(),
                dataReader["CashierRibbon"].ToString());
        }

        string IBatchRepo.BankValueInsert(BankValueModel bankValue, string register, string user)
        {
            return this.RunProcedure("sp_batchBankValue_Insert", new List<SqlParameter> { new SqlParameter("@user", user), new SqlParameter("@register", register), new SqlParameter("@paymentmethod", bankValue.PaymentMethod), new SqlParameter("@openvalue", bankValue.OpenValue), new SqlParameter("@closevalue", bankValue.CloseValue) }, this.insertMessage);
        }

        List<BatchModel> IBatch.Getall()
        {
            List<BatchModel> batches = new List<BatchModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_batch_read");
            while (dataReader.Read())
            {
                batches.Add(this.BatchRead(dataReader));
            }
            return batches;
        }

        private BatchModel BatchRead(SqlDataReader dataReader)
        {
            return new BatchModel(
                id: IntChecker(dataReader, "Id"),
                openTime: DataTimeChecker(dataReader, "OpenningTime"),
                closeTime: DataTimeChecker(dataReader, "ClosingTime"),
                status: Convert.ToBoolean(dataReader["Status"]),
                batchUser: dataReader["Name"].ToString(),
                batchRegister: dataReader["Register"].ToString(),
                totalSell: LongChecker(dataReader, "فروش کالا"),
                totalSellWithoutCredit: LongChecker(dataReader, "فروش کل با احتساب نسیه"),
                income: LongChecker(dataReader, "شارژ حساب"),
                systemSum: LongChecker(dataReader, "مجموع سیستم"),
                storePayouts: LongChecker(dataReader, "هزینه فروشگاهی"),
                credit: LongChecker(dataReader, "نسیه"),
                totalAccountsValue: LongChecker(dataReader, "مجموع فروش حساب ها"),
                cashierSum: LongChecker(dataReader, "مجموع صندوق"),
                systemCashierVariant: LongChecker(dataReader, "اختلاف فروش و صندوق")

);
            //return new BatchModel(
            //    id: Convert.ToInt32(dataReader["Id"]),
            //    user: dataReader["User"].ToString(),
            //    register: dataReader["Register"].ToString(),
            //    status: Convert.ToBoolean(dataReader["Status"]),
            //    openTime: DataTimeChecker(dataReader, "OpenningTime"),
            //    closeTime: DataTimeChecker(dataReader, "ClosingTime"),
            //    payoutSum: LongChecker(dataReader, "payoutsum"),
            //    totalSell: LongChecker(dataReader, "totalsell"),
            //    totalVariant: LongChecker(dataReader, "totalvariant"),
            //    accountingIn: LongChecker(dataReader, "accountingin"),
            //    accountingOut: LongChecker(dataReader, "accountingout")
            //    );
        }

        private DateTime DataTimeChecker(SqlDataReader dataReader, string column)
        {
            if (dataReader[column].GetType() == typeof(DBNull))
            {
                return new DateTime();
            }
            else
            {
                return Convert.ToDateTime(dataReader[column]);
            }

        }
        private long LongChecker(SqlDataReader dataReader, string column)
        {
            if (dataReader[column].GetType() == typeof(DBNull))
            {
                return 0;
            }
            else
            {
                string s = dataReader[column].ToString();
                decimal d = decimal.Parse(s);
                return Convert.ToInt64(d);
            }

        }

        List<BankValueModel> IBatchRepo.GetBankValues(int batchid)
        {
            List<BankValueModel> batchBankValues = new List<BankValueModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_batchbankvalue_read", new List<SqlParameter> { new SqlParameter("@batchid", batchid) });
            while (dataReader.Read())
            {
                batchBankValues.Add(this.BatchBankValue(dataReader));
            }
            return batchBankValues;
        }

        private BankValueModel BatchBankValue(SqlDataReader dataReader)
        {
            return new BankValueModel(
                id: Convert.ToInt32(dataReader["Id"]),
                paymentMethod: dataReader["PaymentMethod"].ToString(),
                openValue: LongChecker(dataReader, "openvalue"),
                closeValue: LongChecker(dataReader, "closevalue"),
                total: LongChecker(dataReader, "فروش"),
                variant: LongChecker(dataReader, "اختلاف")
                );
        }

        void ITransactionRepo.InsertItem(TransactionEntryModel transactionEntry, int transaction)
        {
            try
            {
                string s = this.RunProcedure("sp_transactionEntry_insert",
                          new List<SqlParameter> { new SqlParameter("@transaction",transaction),
           new SqlParameter("@transactionType"," "),
           new SqlParameter("@item",transactionEntry.ItemId),
           new SqlParameter("@buyprice",transactionEntry.BuyPrice),
           new SqlParameter("@sellprice",transactionEntry.SellPrice),
           new SqlParameter("@amount",transactionEntry.Amount),
           new SqlParameter("@description"," ")}, this.insertMessage);
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<TransactionEntryModel> ITransactionRepo.TransactionEntriesRead(int transactionid)
        {
            throw new NotImplementedException();
        }

        bool IReceiptRepo.InsertItem(ReceiptEntryModel receiptEntry)
        {
            try
            {
                this.RunProcedure("sp_recieptDetail_Insert",
               new List<SqlParameter> { new SqlParameter("@item",receiptEntry.Item.Id),
            new SqlParameter("@amount",receiptEntry.Amount),
                new SqlParameter("@unitprice",receiptEntry.UnitPrice)}, this.insertMessage);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        List<ReceiptEntryModel> IReceiptRepo.ReceiptItemsRead(int Receipt)
        {
            List<ReceiptEntryModel> receiptEntries = new List<ReceiptEntryModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_receiptdetail_read", new List<SqlParameter> { new SqlParameter("@header", Receipt) });
            while (dataReader.Read())
            {
                receiptEntries.Add(this.ReceiptEntryRead(dataReader));
            }
            return receiptEntries;
        }

        private ReceiptEntryModel ReceiptEntryRead(SqlDataReader dataReader)
        {
            ReceiptEntryModel receiptEntry = new ReceiptEntryModel();
            if (dataReader.HasRows)
            {
                receiptEntry = new ReceiptEntryModel(id: Convert.ToInt32(dataReader["Id"]),
                item: this.GetItemByName(dataReader["Item"].ToString()),
                unitPrice: this.LongChecker(dataReader, "UnitPrice"),
                amount: this.DecimalChecker(dataReader, "Amount"));
            }
            return receiptEntry;
        }

        string IReceipt.Insert(ReceiptModel receipt)
        {
            return this.RunProcedure("sp_recieptHeader_Insert", new List<SqlParameter> { new SqlParameter("@workstation",Convert.ToInt32(receipt.Workstation)),
           new SqlParameter("@serialnumber",receipt.SerialNumber),
           new SqlParameter("@recieptnumber",receipt.ReceiptNumber),
           new SqlParameter("@time",receipt.Time),
           new SqlParameter("@department",receipt.Department),
           new SqlParameter("@total",receipt.Total)}, this.insertMessage);
        }


        ReceiptModel IReceipt.Get(string barcode)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_recieptHeader_Get", new List<SqlParameter> { new SqlParameter("barcode", barcode) });
            dataReader.Read();
            if (dataReader.HasRows)
            {
                return this.ReceiptRead(dataReader);
            }
            else
            {
                return null;
            }
        }

        private ReceiptModel ReceiptRead(SqlDataReader dataReader)
        {
            ReceiptModel receipt = new ReceiptModel();
            if (dataReader.HasRows)
            {
                receipt = new ReceiptModel(id: Convert.ToInt32(dataReader["Id"]),
               workstation: dataReader["Workstation"].ToString(),
               serialNumber: dataReader["SerialNumber"].ToString(),
               receiptNumber: dataReader["ReceiptNumber"].ToString(),
               barcode: dataReader["Barcode"].ToString(),
               department: dataReader["Department"].ToString(),
               total: long.Parse(dataReader["Total"].ToString()),
               time: DataTimeChecker(dataReader, "Time"),
               scanned: Convert.ToBoolean(dataReader["Scanned"]));
                receipt.Status = dataReader["وضعیت"].ToString();
            }
            receipt.Transaction = this.IntChecker(dataReader, "Transaction");
            return receipt;
        }

        string IOrder.Insert(OrderTransactionModel order)
        {
            return this.RunProcedure("sp_order_Insert", new List<SqlParameter> { new SqlParameter("@customer",order.Person),
                new SqlParameter("@description",order.Description),
                new SqlParameter("@amount",order.Total) }, this.insertMessage);
        }

        string IOrder.Pay(OrderTransactionModel order)
        {
            return this.RunProcedure("sp_order_Payment", new List<SqlParameter> { new SqlParameter("@ordernumber",order.Id),
               new SqlParameter("@register",order.BatchRegister),
           new SqlParameter("@user",order.BatchUser),
           new SqlParameter("@amount",order.Total),
           new SqlParameter("@paymentmethod",order.PaymentMethod)}, this.insertMessage);
        }

        List<OrderTransactionModel> IOrder.List()
        {
            throw new NotImplementedException();
        }

        string IHardwareKey.Delete(HardwareKeyModel model)
        {
            return this.RunProcedure("sp_hardwareKey_Delete", new List<SqlParameter> { new SqlParameter("@workstation", model.Workstation) }, this.deleteMessage);
        }

        string ITransaction.LastCode()
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_transaction_lastcode");
            dataReader.Read();
            return dataReader[0].ToString();
        }

        ReceiptEntryModel IItem.GetByBarcode(string barcode)
        {
            return GetItemByBarcode(barcode);
        }

        private ReceiptEntryModel GetItemByBarcode(string barcode)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_item_getbybarcode", new List<SqlParameter> { new SqlParameter("@barcode", barcode) });
            dataReader.Read();
            if (dataReader.HasRows)
            {
                return this.ReceiptEntryRead(dataReader);
            }
            else
            {
                return null;
            }
        }

        string IBaseTransaction<PayoutTransactionModel>.Delete(PayoutTransactionModel model)
        {
            return this.RunProcedure("sp_transaction_payout_delete", new List<SqlParameter> { new SqlParameter("@id", model.Id) }, this.deleteMessage);
        }

        string IBaseTransaction<PaymentTransactionModel>.Delete(PaymentTransactionModel model)
        {
            throw new NotImplementedException();
        }

        string IBaseTransaction<TransactionModel>.Delete(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        List<ReceiptModel> IReceipt.List(WorkstationReceiptFilterModel workstationReceiptFilter)
        {
            List<ReceiptModel> receipts = new List<ReceiptModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_workstationReceipt_get",
                new List<SqlParameter> {
                new SqlParameter("@workstation",workstationReceiptFilter.Workstation),
                new SqlParameter("@starttime",workstationReceiptFilter.StartTime),
                new SqlParameter("@endtime",workstationReceiptFilter.EndTime)});
            while (dataReader.Read())
            {
                receipts.Add(this.ReceiptRead(dataReader));
            }
            return receipts;
        }

        long ITransaction.LastValue()
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_transaction_lastvalue");
            dataReader.Read();
            long num = 0;
            if (dataReader.HasRows)
            {
                num = Convert.ToInt64(dataReader[0]);
            }
            return num;
        }

        List<ReceiptModel> IReceipt.CashierList()
        {
            List<ReceiptModel> receipts = new List<ReceiptModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_Receipt_get");
            while (dataReader.Read())
            {
                receipts.Add(this.ReceiptRead(dataReader));
            }
            return receipts;
        }

        string IPerson.Settle(PersonModel person)
        {
            return this.RunProcedure("sp_person_settle", new List<SqlParameter> { new SqlParameter("@personid", person.Id) }, "مشتری موردنظر تسویه و مخفی شد");
        }

        List<PersonCreditHeaderModel> IAcountingRepo.PersonCreditsList()
        {
            List<PersonCreditHeaderModel> personCreditHeaders = new List<PersonCreditHeaderModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_person_read");
            while (dataReader.Read())
            {
                personCreditHeaders.Add(this.PersonCreditRead(dataReader));
            }
            return personCreditHeaders;
        }

        private PersonCreditHeaderModel PersonCreditRead(SqlDataReader dataReader)
        {
            return new PersonCreditHeaderModel
            {
                Name = dataReader["Name"].ToString(),
                TotalValue = this.LongChecker(dataReader, "TotalSales"),
                TotalVisit = this.IntChecker(dataReader, "TotalVisits"),
                Balance = this.LongChecker(dataReader, "balance"),
            };
        }

        PersonCreditHeaderModel IAcountingRepo.PersonCreditGet(PersonModel person)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_personcredit_get");
            dataReader.Read();
            PersonCreditHeaderModel personCredit = this.PersonCreditRead(dataReader);
            return personCredit;
        }

        List<PersonCreditLogModel> IAcountingRepo.PersonCreditLogRead(string person)
        {
            List<PersonCreditLogModel> personCreditLogs = new List<PersonCreditLogModel>();
            SqlDataReader dataReader = this.ReadProcedure("sp_personcreditlog_get", new List<SqlParameter> { new SqlParameter("person", person) });
            while (dataReader.Read())
            {
                personCreditLogs.Add(this.PersonCreditLog(dataReader));
            }
            return personCreditLogs;
        }

        private PersonCreditLogModel PersonCreditLog(SqlDataReader dataReader)
        {
            return new PersonCreditLogModel
            {
                Bedehkari = this.LongChecker(dataReader, "بدهکاری"),
                Bestankari = this.LongChecker(dataReader, "بستانکاری"),
                Remain = this.LongChecker(dataReader, "Remain"),
                RecordTime = this.DataTimeChecker(dataReader, "RecordTime")
            };
        }

        List<PayoutTransactionModel> IAcountingRepo.PayoutList(DateTime date)
        {
            List<PayoutTransactionModel> payoutTransactions = new List<PayoutTransactionModel>();
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_transaction_payout_list", new List<SqlParameter> { new SqlParameter("@date", date) });
                while (dataReader.Read())
                {
                    payoutTransactions.Add(this.PayoutTransactionRead(dataReader));
                }
                return payoutTransactions;
            }
            catch (Exception e)
            {

                throw e;
            }



        }

        string IMain<DiscountModel>.Insert(DiscountModel model)
        {
            return this.RunProcedure("sp_discount_insert", this.InsertDiscountParameters(model), this.insertMessage);
        }

        private List<SqlParameter> InsertDiscountParameters(DiscountModel model)
        {
            return new List<SqlParameter>
           {
               new SqlParameter("@title",model.Title),
               new SqlParameter("@percent",model.Percent)
           };
        }

        string IMain<DiscountModel>.Update(DiscountModel model)
        {
            return this.RunProcedure("sp_update_discount", this.InsertDiscountParameters(model).Concat(new[] { new SqlParameter("@id", model.Id) }).ToList(), this.updateMessage);
        }

        string IMain<DiscountModel>.Delete(DiscountModel model)
        {
            return this.RunProcedure("sp_discount_delete", new List<SqlParameter> { new SqlParameter("@id", model.Id) }, this.deleteMessage);
        }

        DiscountModel IMain<DiscountModel>.Get(string title)
        {
            try
            {
                SqlDataReader dataReader = this.ReadProcedure("sp_discount_get", new List<SqlParameter> { new SqlParameter("@title", title) });
                dataReader.Read();
                return this.DiscountRead(dataReader);
            }
            catch (Exception)
            {

                throw;
            }

        }

        List<DiscountModel> IMain<DiscountModel>.Search(string text)
        {
            try
            {
                List<DiscountModel> discounts = new List<DiscountModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_discount_search", new List<SqlParameter> { new SqlParameter("@text", text) });
                while (dataReader.Read())
                {
                    discounts.Add(this.DiscountRead(dataReader));
                }
                return discounts;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<DiscountModel> IMain<DiscountModel>.List(string text)
        {
            try
            {
                List<DiscountModel> discounts = new List<DiscountModel>();
                SqlDataReader dataReader = this.ReadProcedure("sp_discount_read");
                while (dataReader.Read())
                {
                    discounts.Add(this.DiscountRead(dataReader));
                }
                return discounts;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DiscountModel DiscountRead(SqlDataReader dataReader)
        {
            return new DiscountModel(id: Convert.ToInt32(dataReader["Id"]),
                title: dataReader["Title"].ToString(),
                percent: Convert.ToInt32(dataReader["Percent"]));

        }

        ReceiptEntryModel IReceiptRepo.ItemByBarcode(string barcode)
        {
            return this.GetItemByBarcode(barcode);
        }

        List<PaymentTransactionModel> IPaymentTransaction.Read()
        {
            throw new NotImplementedException();
        }

        string IInventoryManagement.AddItem(InventoryLogModel itemlog)
        {
            return this.RunProcedure("sp_inventoryLog_insert", this.InventoryLogInsertParameters(itemlog), this.insertMessage);
        }

        private List<SqlParameter> InventoryLogInsertParameters(InventoryLogModel itemlog)
        {
            return new List<SqlParameter>
           {
               new SqlParameter("@item",itemlog.Item.ToInt()),
               new SqlParameter("@buyprice",itemlog.BuyPrice),
               new SqlParameter("@sellprice",itemlog.SellPrice),
               new SqlParameter("amount",itemlog.Amount)
           };
        }

        List<InventoryLogModel> IInventoryManagement.GetItemLog(ItemModel item)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_item_inventoryLog_get", new List<SqlParameter> { new SqlParameter("@item", item.Name) });
            List<InventoryLogModel> inventoryLogs = this.InventoryLogRead(dataReader);
            return inventoryLogs;
        }

        private List<InventoryLogModel> InventoryLogRead(SqlDataReader dataReader)
        {
            List<InventoryLogModel> inventoryLogs = new List<InventoryLogModel>();
            while (dataReader.Read())
            {
                inventoryLogs.Add(new InventoryLogModel(
                    id: Convert.ToInt32(dataReader["Id"]),
                   io: dataReader["Io"].ToString(),
                   inventory: dataReader["Inventory"].ToString(),
                   item: dataReader["Item"].ToString(),
                   recordTime: this.DataTimeChecker(dataReader, "RecordTime"),
                   buyPrice: this.LongChecker(dataReader, "BuyPrice"),
                   sellPrice: this.LongChecker(dataReader, "SellPrice"),
                   amount: this.DecimalChecker(dataReader, "Amount")));
            }
            return inventoryLogs;
        }

        decimal IInventoryManagement.GetItemStock(ItemModel item)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_item_stock_get", new List<SqlParameter> { new SqlParameter("@item", item.Name) });
            return this.DecimalChecker(dataReader, "stock");
        }

        void ITransactionRepo.UpdateReceiptTransaction(int receipt, int transaction)
        {
            this.RunProcedure("sp_receipt_setTransaction", new List<SqlParameter> { new SqlParameter("@receipt", receipt) }, this.insertMessage);
        }

        TransactionModel IReceiptRepo.GetTransaction(int id)
        {
            return this.GetTransaction(id);
        }

        private TransactionModel GetTransaction(int id)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_transaction_get", new List<SqlParameter> { new SqlParameter("@id", id) });
            dataReader.Read();
            TransactionModel transaction = this.TranactionRead(dataReader);
            this.Dispose();
            return transaction;
        }

        private TransactionModel TranactionRead(SqlDataReader dataReader)
        {
            if (dataReader.HasRows)
            {
                TransactionModel transaction = new TransactionModel
                {
                    Id=this.IntChecker(dataReader,"Id"),
                    Batch = this.IntChecker(dataReader, "Batch"),
                    BatchRegister = dataReader["BatchRegister"].ToString(),
                    BatchUser = dataReader["BatchUser"].ToString(),
                    RecordTime = this.DataTimeChecker(dataReader, "RecordTime"),
                    Serial = dataReader["Serial"].ToString(),
                    Io = Convert.ToBoolean(dataReader["Io"]),
                    TransactionType = dataReader["Type"].ToString(),
                    PaymentMethod = dataReader["PaymentMethod"].ToString(),
                    TotalValue = this.LongChecker(dataReader, "Value")
                };
                return transaction;
            }
            else
            {
                return new TransactionModel();
            }

        }

        List<TransactionEntryModel> IReceiptRepo.GetTransactionItems(int id)
        {
            SqlDataReader dataReader = this.ReadProcedure("sp_transactionitems_get", new List<SqlParameter> { new SqlParameter("@transaction", id) });
            List<TransactionEntryModel> transactionEntries = new List<TransactionEntryModel>();
            while (dataReader.Read())
            {
                transactionEntries.Add(this.TransactionEntryRead(dataReader));
            }
            this.Dispose();
            return transactionEntries;
        }

        private TransactionEntryModel TransactionEntryRead(SqlDataReader dataReader)
        {
            return new TransactionEntryModel
            {
                Item = dataReader["Item"].ToString(),
                Amount = this.DecimalChecker(dataReader, "Amount"),
                BuyPrice = this.LongChecker(dataReader, "BuyPrice"),
                SellPrice = this.LongChecker(dataReader, "SellPrice")
            };
        }

        TransactionModel IReceipt.GetTransaction(int id)
        {
            return this.GetTransaction(id);
        }
    }
}

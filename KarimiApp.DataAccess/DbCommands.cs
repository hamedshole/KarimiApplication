//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Runtime.InteropServices;
//using KarimiApp.Model;
//using Microsoft.Win32.SafeHandles;

//namespace KarimiApp.DataAccess
//{
//    public class DbCommands : IDbCommand
//    {
//        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
//        private bool disposed = false;
//        private SqlConnection connection;
//        private SqlCommand command;

//        void IDbCommand.CreateAndConnect()
//        {
//            this.connection = new SqlConnection
//            {
//                ConnectionString = @"Data Source=DESKTOP-DEATHLY\MSSQLSERVER2019;Initial Catalog=NewDb;Integrated Security=True",
//            };
//            this.connection.Open();
//            this.command = new SqlCommand
//            {
//                Connection = this.connection,
//            };

//        }

//        void IDbCommand.Dispose()
//        {
//            this.Dispose(true);
//            GC.SuppressFinalize(this);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            if (this.disposed)
//            {
//                return;
//            }

//            if (disposing)
//            {
//                this.handle.Dispose();
//                this.connection.Dispose();
//                this.command.Dispose();
//            }

//            this.disposed = true;
//        }

//        string IDbCommand.PersonDelete(PersonModel person)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", person.Id));
//                return $"با موفقیت حذف شد {person.Id}کاربر با شماره";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }


//        }

//        PersonModel IDbCommand.PersonGet(PersonModel person)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_get";
//                this.command.Parameters.AddWithValue("@id", person.Id);
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return PersonRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private PersonModel PersonRead(SqlDataReader dataReader)
//        {
//            return new PersonModel(id: Convert.ToInt32(dataReader["Id"]), Convert.ToInt32(dataReader["Code"]), dataReader["PersonGroup"].ToString(), dataReader["FirstName"].ToString(), dataReader["LastName"].ToString(), gender: Convert.ToInt32(dataReader["Gender"]), Convert.ToDateTime(dataReader["Birthday"]), dataReader["MobileNumber"].ToString(), dataReader["Email"].ToString());
//        }

//        string IDbCommand.PersonGroupDelete(PersonGroupModel personGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_persongroup_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", personGroup.Id));
//                return $"با موفقیت حذف شد {personGroup.Id}دسته با شماره";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        PersonGroupModel IDbCommand.PersonGroupGet(PersonGroupModel personGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_get";
//                this.command.Parameters.Add(new SqlParameter("@title", personGroup.Id));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return PersonGroupRead(dataReader);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        private PersonGroupModel PersonGroupRead(SqlDataReader dataReader)
//        {
//            PersonGroupModel tmp = new PersonGroupModel(id: Convert.ToInt32(dataReader["Id"]), title: dataReader["Title"].ToString(), description: dataReader["Description"].ToString(), Convert.ToBoolean(dataReader["Active"]));
//            return tmp;
//        }

//        string IDbCommand.PersonGroupInsert(PersonGroupModel personGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_persongroup_insert";
//                this.command.Parameters.AddWithValue("@title", personGroup.Title);
//                this.command.Parameters.AddWithValue("@description", personGroup.Description);
//                this.command.Parameters.AddWithValue("@active", personGroup.Active);
//                this.command.ExecuteNonQuery();
//                return "با موفقیت افزوده شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        List<PersonGroupModel> IDbCommand.PersonGroupList()
//        {
//            try
//            {
//                List<PersonGroupModel> list = new List<PersonGroupModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_persongroup_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    list.Add(this.PersonGroupRead(dataReader));
//                }
//                return list;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        string IDbCommand.PersonGroupUpdate(PersonGroupModel personGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_persongroup_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", personGroup.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", personGroup.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", personGroup.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {personGroup.Id}دسته با شماره";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PersonInsert(PersonModel person)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_insert";
//                this.command.Parameters.Add(new SqlParameter("@persongroup", person.PersonGroup));
//                this.command.Parameters.Add(new SqlParameter("@firstname", person.FirstName));
//                this.command.Parameters.Add(new SqlParameter("@lastname", person.LastName));
//                this.command.Parameters.Add(new SqlParameter("@gender", Convert.ToBoolean(person.Gender)));
//                this.command.Parameters.Add(new SqlParameter("@birthday", person.Birthday));
//                this.command.Parameters.Add(new SqlParameter("@mobilenumber", person.MobileNumber));
//                this.command.Parameters.Add(new SqlParameter("@email", person.Email));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت افزوده شد";
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        List<PersonModel> IDbCommand.PersonList()
//        {
//            try
//            {
//                List<PersonModel> list = new List<PersonModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    list.Add(this.PersonRead(dataReader));
//                }
//                return list;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.PersonUpdate(PersonModel person)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_person_update";
//                this.command.Parameters.Add(new SqlParameter("@id", person.Id));
//                this.command.Parameters.Add(new SqlParameter("@persongroup", person.PersonGroup));
//                this.command.Parameters.Add(new SqlParameter("@firstname", person.FirstName));
//                this.command.Parameters.Add(new SqlParameter("@lastname", person.LastName));
//                this.command.Parameters.Add(new SqlParameter("@gender", Convert.ToBoolean(person.Gender)));
//                this.command.Parameters.Add(new SqlParameter("@birthday", person.Birthday));
//                this.command.Parameters.Add(new SqlParameter("@mobilenumber", person.MobileNumber));
//                this.command.Parameters.Add(new SqlParameter("@email", person.Email));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {person.Id}دسته با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.DepartmentInsert(DepartmentModel department)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_department_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", department.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", department.Description));
//                this.command.Parameters.Add(new SqlParameter("@defaultinventory", department.DefaultInventory));
//                this.command.Parameters.Add(new SqlParameter("@active", department.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت افزوده شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.DepartmentUpdate(DepartmentModel department)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_department_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", department.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", department.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", department.Description));
//                this.command.Parameters.Add(new SqlParameter("@defaultinventory", department.DefaultInventory));
//                this.command.Parameters.Add(new SqlParameter("@active", department.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {department.Id}غرفه با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.DepartmentDelete(DepartmentModel department)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_department_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", department.Id));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت حذف شد {department.Id}غرفه با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        DepartmentModel IDbCommand.DepartmentGet(DepartmentModel department)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_department_get";
//                this.command.Parameters.Add(new SqlParameter("@title", department.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.DepartmentRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }


//        }

//        private DepartmentModel DepartmentRead(SqlDataReader dataReader)
//        {
//            return new DepartmentModel(id: Convert.ToInt32(dataReader["Id"]), title: dataReader["Title"].ToString(), dataReader["DefaultInventory"].ToString(), dataReader["Description"].ToString(), Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<DepartmentModel> IDbCommand.DepartmentList()
//        {
//            try
//            {
//                List<DepartmentModel> list = new List<DepartmentModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_department_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    list.Add(this.DepartmentRead(dataReader));
//                }
//                return list;
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//        }

//        string IDbCommand.InventoryInsert(InventoryModel inventory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", inventory.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", inventory.Description));
//                this.command.Parameters.Add(new SqlParameter("@keeper", inventory.Keeper));
//                this.command.Parameters.Add(new SqlParameter("@group", inventory.Group));
//                this.command.Parameters.Add(new SqlParameter("@active", inventory.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت افزوده شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.InventoryUpdate(InventoryModel inventory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_update";
//                this.command.Parameters.Add(new SqlParameter("@id", inventory.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", inventory.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", inventory.Description));
//                this.command.Parameters.Add(new SqlParameter("@keeper", inventory.Keeper));
//                this.command.Parameters.Add(new SqlParameter("@group", inventory.Group));
//                this.command.Parameters.Add(new SqlParameter("@active", inventory.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {inventory.Id}انبار با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.InventoryDelete(InventoryModel inventory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", inventory.Id)); ;
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت حذف شد {inventory.Id}انبار با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        InventoryModel IDbCommand.InventoryGet(InventoryModel inventory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_get";
//                this.command.Parameters.Add(new SqlParameter("@title", inventory.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.InventoryRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private InventoryModel InventoryRead(SqlDataReader dataReader)
//        {
//            return new InventoryModel(id: Convert.ToInt32(dataReader["Id"]),
//                                        title: dataReader["Title"].ToString(),
//                                        group: dataReader["Group"].ToString(),
//                                        keeper: dataReader["Keeper"].ToString(),
//                                        description: dataReader["Description"].ToString(),
//                                        active: Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<InventoryModel> IDbCommand.InventoryList()
//        {
//            try
//            {
//                List<InventoryModel> list = new List<InventoryModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    list.Add(this.InventoryRead(dataReader));
//                }
//                return list;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.InventoryGroupInsert(InventoryGroupModel inventoryGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventorygroup_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", inventoryGroup.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", inventoryGroup.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", inventoryGroup.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.InventoryGroupUpdate(InventoryGroupModel inventoryGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_update";
//                this.command.Parameters.Add(new SqlParameter("@id", inventoryGroup.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", inventoryGroup.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", inventoryGroup.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", inventoryGroup.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {inventoryGroup.Id}دسته انبار با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.InventoryGroupDelete(InventoryGroupModel inventoryGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", inventoryGroup.Id));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت حذف شد {inventoryGroup.Id}دسته انبار با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        InventoryGroupModel IDbCommand.InventoryGroupGet(InventoryGroupModel inventoryGroup)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventorygroup_get";
//                this.command.Parameters.Add(new SqlParameter("@title", inventoryGroup.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.InventoryGroupRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private InventoryGroupModel InventoryGroupRead(SqlDataReader dataReader)
//        {
//            return new InventoryGroupModel(id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                description: dataReader["Description"].ToString(),
//                Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<InventoryGroupModel> IDbCommand.InventoryGroupList()
//        {
//            try
//            {
//                List<InventoryGroupModel> inventoryGroups = new List<InventoryGroupModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventorygroup_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    inventoryGroups.Add(this.InventoryGroupRead(dataReader));
//                }
//                return inventoryGroups;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.ItemCategoryInsert(ItemCategoryModel itemCategory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_itemcategory_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", itemCategory.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", itemCategory.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", itemCategory.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ItemCategoryUpdate(ItemCategoryModel itemCategory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_itemcategory_update";
//                this.command.Parameters.Add(new SqlParameter("@id", itemCategory.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", itemCategory.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", itemCategory.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", itemCategory.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {itemCategory.Id}دسته کالا با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ItemCategoryDelete(ItemCategoryModel itemCategory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_inventory_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", itemCategory.Id));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت حذف شد {itemCategory.Id}دسته انبار با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        ItemCategoryModel IDbCommand.ItemCategoryGet(ItemCategoryModel itemCategory)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_itemcategory_get";
//                this.command.Parameters.Add(new SqlParameter("@title", itemCategory.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.ItemCategoryRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private ItemCategoryModel ItemCategoryRead(SqlDataReader dataReader)
//        {
//            return new ItemCategoryModel(id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                description: dataReader["Description"].ToString(),
//                Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<ItemCategoryModel> IDbCommand.ItemCategoryList()
//        {
//            try
//            {
//                List<ItemCategoryModel> itemCategories = new List<ItemCategoryModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_itemcategory_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    itemCategories.Add(this.ItemCategoryRead(dataReader));
//                }
//                return itemCategories;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.UserRoleInsert(UserRoleModel userRole)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_userrole_insert";
//                this.command.Parameters.Add(new SqlParameter("@info", userRole.Info));
//                this.command.Parameters.Add(new SqlParameter("@title", userRole.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", userRole.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", userRole.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.UserRoleUpdate(UserRoleModel userRole)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_userrole_update";
//                this.command.Parameters.Add(new SqlParameter("@id", userRole.Id));
//                this.command.Parameters.Add(new SqlParameter("@info", userRole.Info));
//                this.command.Parameters.Add(new SqlParameter("@title", userRole.Title));
//                this.command.Parameters.Add(new SqlParameter("@description", userRole.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", userRole.Active));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {userRole.Id}دسته کالا با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.UserRoleDelete(UserRoleModel userRole)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_userrole_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", userRole.Id));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت حذف شد {userRole.Id}نقش کاربری با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        UserRoleModel IDbCommand.UserRoleGet(UserRoleModel userRole)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_userrole_get";
//                this.command.Parameters.Add(new SqlParameter("@title", userRole.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.UserRoleRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private UserRoleModel UserRoleRead(SqlDataReader dataReader)
//        {
//            return new UserRoleModel(id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                description: dataReader["Description"].ToString(),
//                info: dataReader["info"].ToString(),
//                active: Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<UserRoleModel> IDbCommand.UserRoleList()
//        {
//            try
//            {
//                List<UserRoleModel> userRoles = new List<UserRoleModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_userrole_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    userRoles.Add(this.UserRoleRead(dataReader));
//                }
//                return userRoles;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.ItemInsert(ItemModel item)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_item_insert";
//                this.command.Parameters.Add(new SqlParameter("@barcode", item.Barcode));
//                this.command.Parameters.Add(new SqlParameter("@name", item.Name));
//                this.command.Parameters.Add(new SqlParameter("@category", item.Category));
//                this.command.Parameters.Add(new SqlParameter("@department", item.Department));
//                this.command.Parameters.Add(new SqlParameter("@weighed", item.Weighed));
//                this.command.Parameters.Add(new SqlParameter("@buyprice", item.BuyPrice));
//                this.command.Parameters.Add(new SqlParameter("@sellprice", item.SellPrice));
//                this.command.Parameters.Add(new SqlParameter("@active", item.Active));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ItemUpdate(ItemModel item)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_item_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", item.Id));
//                this.command.Parameters.Add(new SqlParameter("@barcode", item.Barcode));
//                this.command.Parameters.Add(new SqlParameter("@name", item.Name));
//                this.command.Parameters.Add(new SqlParameter("@category", item.Category));
//                this.command.Parameters.Add(new SqlParameter("@department", item.Department));
//                this.command.Parameters.Add(new SqlParameter("@weighed", item.Weighed));
//                this.command.Parameters.Add(new SqlParameter("@buyprice", item.BuyPrice));
//                this.command.Parameters.Add(new SqlParameter("@sellprice", item.SellPrice));
//                this.command.Parameters.Add(new SqlParameter("@active", item.Active)); this.command.ExecuteNonQuery();
//                return $"با موفقیت ویرایش شد {item.Id} کالا با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ItemDelete(ItemModel item)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_item_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", item.Id));
//                return $"با موفقیت حذف شد {item.Id} کالا با شماره";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }

//        }

//        ItemModel IDbCommand.ItemGet(ItemModel item)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_item_get";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                return this.ItemRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private ItemModel ItemRead(SqlDataReader dataReader)
//        {
//            return new ItemModel(id: Convert.ToInt32(dataReader["Id"]),
//                code: Convert.ToInt32(dataReader["Code"]),
//                barcode: dataReader["Barcode"].ToString(),
//                name: dataReader["Name"].ToString(),
//                department: dataReader["Department"].ToString(),
//                category: dataReader["Category"].ToString(),
//                buyPrice: long.Parse(dataReader["BuyPrice"].ToString()),
//                sellPrice: long.Parse(dataReader["SellPirice"].ToString()),
//                stock: Convert.ToDecimal(dataReader["Stock"].ToString()),
//                active: Convert.ToBoolean(dataReader["Active"]),
//                weighed: Convert.ToBoolean(dataReader["Weighed"]));
//        }

//        List<ItemModel> IDbCommand.ItemList()
//        {
//            try
//            {
//                List<ItemModel> items = new List<ItemModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_item_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    items.Add(this.ItemRead(dataReader));
//                }
//                return items;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.HardwareKeyInsert(HardwareKeyModel hardwareKey)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_hardwarekey_insert";
//                this.command.Parameters.Add(new SqlParameter("@workstation", hardwareKey.Workstation));
//                this.command.Parameters.Add(new SqlParameter("@key", hardwareKey.Key));
//                this.command.Parameters.Add(new SqlParameter("@plu", hardwareKey.Plu));
//                this.command.ExecuteNonQuery();
//                return $"با موفقیت ثبت شد {hardwareKey.Workstation} دکمه های سخت افزاری برای دستگاه";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.HardwareKeyUpdate(HardwareKeyModel hardware)
//        {
//            throw new NotImplementedException();
//        }

//        string IDbCommand.ItemDelete(HardwareKeyModel hardware)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_hardwarekey_delete";
//                this.command.Parameters.Add(new SqlParameter("@workstation", hardware.Workstation));
//                this.command.ExecuteNonQuery();
//                return "دکمه های سخت افزاری دستگاه با موفقیت حذف شدند";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        HardwareKeyModel IDbCommand.HardWareKeyGet(HardwareKeyModel item)
//        {
//            throw new NotImplementedException();
//        }

//        List<HardwareKeyModel> IDbCommand.HardwareKeyList(HardwareKeyModel hardwareKey)
//        {
//            try
//            {
//                List<HardwareKeyModel> hardwareKeys = new List<HardwareKeyModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_hardwarekey_read";
//                this.command.Parameters.Add(new SqlParameter("@workstation", hardwareKey.Workstation));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    hardwareKeys.Add(this.HardwareKeyRead(dataReader));
//                }
//                return hardwareKeys;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        private HardwareKeyModel HardwareKeyRead(SqlDataReader dataReader)
//        {
//            return new HardwareKeyModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                workstation: dataReader["Workstation"].ToString(),
//                Convert.ToInt32(dataReader["Key"]),
//                Convert.ToInt32(dataReader["Plu"]));
//        }

//        string IDbCommand.PaymentMethodInsert(PaymentMethodModel paymentMethod)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymentmethod_insert";
//                this.command.Parameters.Add(new SqlParameter("@paymentType", paymentMethod.PaymentType));
//                this.command.Parameters.Add(new SqlParameter("@title", paymentMethod.Title));
//                this.command.Parameters.Add(new SqlParameter("@pos", paymentMethod.Pos));
//                this.command.Parameters.Add(new SqlParameter("@active", paymentMethod.Active));
//                this.command.ExecuteNonQuery();
//                return "روش پرداخت با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PaymentMethodUpdate(PaymentMethodModel paymentMethod)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymentmethod_update";
//                this.command.Parameters.Add(new SqlParameter("@id", paymentMethod.Id));
//                this.command.Parameters.Add(new SqlParameter("@paymentType", paymentMethod.PaymentType));
//                this.command.Parameters.Add(new SqlParameter("@title", paymentMethod.Title));
//                this.command.Parameters.Add(new SqlParameter("@pos", paymentMethod.Pos));
//                this.command.Parameters.Add(new SqlParameter("@active", paymentMethod.Active));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PaymentMethodDelete(PaymentMethodModel paymentMethod)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "delete";
//                this.command.Parameters.Add(new SqlParameter("@id", paymentMethod.Id));
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        PaymentMethodModel IDbCommand.PaymentMethodGet(PaymentMethodModel paymentMethod)
//        {
//            try
//            {
//                PaymentMethodModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymentmethod_get";
//                this.command.Parameters.Add(new SqlParameter("@title", paymentMethod.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                res = this.PaymentMethodRead(dataReader);
//                return res;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        private PaymentMethodModel PaymentMethodRead(SqlDataReader dataReader)
//        {
//            return new PaymentMethodModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                paymentType: dataReader["PaymentType"].ToString(),
//                pos: dataReader["PosTitle"].ToString(),
//                posCom: Convert.ToInt32(dataReader["PosCom"]),
//                Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<PaymentMethodModel> IDbCommand.PaymentMethodList()
//        {
//            try
//            {
//                List<PaymentMethodModel> paymentMethods = new List<PaymentMethodModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymentmethod_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    paymentMethods.Add(this.PaymentMethodRead(dataReader));
//                }
//                return paymentMethods;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.PaymentTypeInsert(PaymentTypeModel paymentType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymenttype_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", paymentType.Title));
//                this.command.Parameters.Add(new SqlParameter("@active", paymentType.Active));
//                this.command.ExecuteNonQuery();
//                return "نوع پرداخت با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PaymentTypeUpdate(PaymentTypeModel paymentType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymenttype_update";
//                this.command.Parameters.Add(new SqlParameter("@id", paymentType.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", paymentType.Title));
//                this.command.Parameters.Add(new SqlParameter("@active", paymentType.Active));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PaymentTypeDelete(PaymentTypeModel paymentType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymenttype_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", paymentType.Id));
//                this.command.ExecuteNonQuery();
//                return "نوع پرداخت با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        PaymentTypeModel IDbCommand.PaymentTypeGet(PaymentTypeModel paymentType)
//        {
//            try
//            {
//                PaymentTypeModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymenttype_get";
//                this.command.Parameters.Add(new SqlParameter("@title", paymentType.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                res = this.PaymentTypeRead(dataReader);
//                return res;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private PaymentTypeModel PaymentTypeRead(SqlDataReader dataReader)
//        {
//            return new PaymentTypeModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                active: Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<PaymentTypeModel> IDbCommand.PaymentTypeList()
//        {
//            try
//            {
//                List<PaymentTypeModel> paymentTypes = new List<PaymentTypeModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_paymenttype_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    paymentTypes.Add(this.PaymentTypeRead(dataReader));
//                }
//                return paymentTypes;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.WorkstationInsert(WorkstationModel workstation)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_workstation_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", workstation.Title));
//                this.command.Parameters.Add(new SqlParameter("@department", workstation.Department));
//                this.command.Parameters.Add(new SqlParameter("@ipAddress", workstation.IpAddress));
//                this.command.Parameters.Add(new SqlParameter("@portNumber", workstation.PortNumber));
//                this.command.ExecuteNonQuery();
//                return "دستگاه جدید با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.WorkstationUpdate(WorkstationModel workstation)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_workstation_update";
//                this.command.Parameters.Add(new SqlParameter("@id", workstation.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", workstation.Title));
//                this.command.Parameters.Add(new SqlParameter("@department", workstation.Department));
//                this.command.Parameters.Add(new SqlParameter("@ipAddress", workstation.IpAddress));
//                this.command.Parameters.Add(new SqlParameter("@portNumber", workstation.PortNumber));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.WorkstationDelete(WorkstationModel workstation)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_workstation_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", workstation.Id));
//                this.command.ExecuteNonQuery();
//                return "دستگاه با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        WorkstationModel IDbCommand.WorkstationGet(WorkstationModel workstation)
//        {
//            try
//            {
//                WorkstationModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_workstation_get";
//                this.command.Parameters.Add(new SqlParameter("@title", workstation.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                res = this.WorkstationRead(dataReader);
//                return res;

//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private WorkstationModel WorkstationRead(SqlDataReader dataReader)
//        {
//            return new WorkstationModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                department: dataReader["Department"].ToString(),
//                ipAddress: dataReader["IpAddress"].ToString(),
//                Convert.ToInt32(dataReader["PortNumber"]),
//                lastTotalPrice: long.Parse(dataReader["LastTotalPrice"].ToString()));
//        }

//        List<WorkstationModel> IDbCommand.WorkstationList()
//        {
//            try
//            {
//                List<WorkstationModel> workstations = new List<WorkstationModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_workstation_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    workstations.Add(this.WorkstationRead(dataReader));
//                }
//                return workstations;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.RegisterInsert(RegisterModel register)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_register_insert";
//                this.command.Parameters.Add(new SqlParameter("@title", register.Title));
//                this.command.Parameters.Add(new SqlParameter("@computerName", register.ComputerName));
//                this.command.Parameters.Add(new SqlParameter("@ipAddress", register.IpAddress));
//                this.command.Parameters.Add(new SqlParameter("@mac_address", register.MacAddress));
//                this.command.Parameters.Add(new SqlParameter("@description", register.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", register.Active));
//                this.command.ExecuteNonQuery();
//                return "سیستم جدید با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.RegisterUpdate(RegisterModel register)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_register_update";
//                this.command.Parameters.Add(new SqlParameter("@id", register.Id));
//                this.command.Parameters.Add(new SqlParameter("@title", register.Title));
//                this.command.Parameters.Add(new SqlParameter("@computerName", register.ComputerName));
//                this.command.Parameters.Add(new SqlParameter("@ipAddress", register.IpAddress));
//                this.command.Parameters.Add(new SqlParameter("@mac_address", register.MacAddress));
//                this.command.Parameters.Add(new SqlParameter("@description", register.Description));
//                this.command.Parameters.Add(new SqlParameter("@active", register.Active));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.RegisterDelete(RegisterModel register)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_register_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", register.Id));
//                this.command.ExecuteNonQuery();
//                return "سیستم با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        RegisterModel IDbCommand.RegisterGet(RegisterModel register)
//        {
//            try
//            {
//                RegisterModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_register_get";
//                this.command.Parameters.Add(new SqlParameter("@title", register.Title));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                res = this.RegisterRead(dataReader);
//                return res;

//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private RegisterModel RegisterRead(SqlDataReader dataReader)
//        {
//            return new RegisterModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                computerName: dataReader["ComputerName"].ToString(),
//                title: dataReader["Title"].ToString(),
//                ipAddress: dataReader["IpAddress"].ToString(),
//                macAddress: dataReader["MacAddress"].ToString(),
//                description: dataReader["Description"].ToString(),
//                active: Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<RegisterModel> IDbCommand.RegisterList()
//        {
//            try
//            {
//                List<RegisterModel> registers = new List<RegisterModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_register_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    registers.Add(this.RegisterRead(dataReader));
//                }
//                return registers;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.ReceiptInsert(ReceiptModel receipt)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_receiptHeader_insert";
//                this.command.Parameters.Add(new SqlParameter("@workstation", receipt.Workstation));
//                this.command.Parameters.Add(new SqlParameter("@department", receipt.Department));
//                this.command.Parameters.Add(new SqlParameter("@serialnumber", receipt.SerialNumber));
//                this.command.Parameters.Add(new SqlParameter("@receiptnumber", receipt.ReceiptNumber));
//                this.command.Parameters.Add(new SqlParameter("@time", receipt.Time));
//                this.command.Parameters.Add(new SqlParameter("@total", receipt.Total));
//                this.command.ExecuteNonQuery();
//                return "فیش جدید با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ReceiptUpdate(ReceiptModel receipt)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_receiptHeader_update";
//                this.command.Parameters.Add(new SqlParameter("@id", receipt.Id));
//                this.command.Parameters.Add(new SqlParameter("@workstation", receipt.Workstation));
//                this.command.Parameters.Add(new SqlParameter("@department", receipt.Department));
//                this.command.Parameters.Add(new SqlParameter("@serialnumber", receipt.SerialNumber));
//                this.command.Parameters.Add(new SqlParameter("@receiptnumber", receipt.ReceiptNumber));
//                this.command.Parameters.Add(new SqlParameter("@time", receipt.Time));
//                this.command.Parameters.Add(new SqlParameter("@total", receipt.Total));
//                this.command.ExecuteNonQuery();
//                return "فیش جدید با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ReceiptDelete(ReceiptModel receipt)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_receiptHeader_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", receipt.Id));
//                this.command.ExecuteNonQuery();
//                return "فیش با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        ReceiptModel IDbCommand.ReceiptGet(ReceiptModel receipt)
//        {
//            try
//            {
//                ReceiptModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_recieptHeader_Get";
//                this.command.Parameters.Add(new SqlParameter("@barcode", receipt.Barcode));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                res = this.ReceiptRead(dataReader);
//                return res;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private ReceiptModel ReceiptRead(SqlDataReader dataReader)
//        {
//            return new ReceiptModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                workstation: dataReader["Workstation"].ToString(),
//                serialNumber: dataReader["SerialNumber"].ToString(),
//                receiptNumber: dataReader["ReceiptNumber"].ToString(),
//                barcode: dataReader["Barcode"].ToString(),
//                department: dataReader["Department"].ToString(),
//                scanned: Convert.ToBoolean(dataReader["Paid"]),
//                time: Convert.ToDateTime(dataReader["Time"]),
//                total: long.Parse(dataReader["Total"].ToString())
//                );
//        }

//        List<ReceiptModel> IDbCommand.ReceiptList()
//        {
//            try
//            {
//                List<ReceiptModel> receipts = new List<ReceiptModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_receiptHeader_Read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    receipts.Add(this.ReceiptRead(dataReader));
//                }
//                return receipts;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.ReceiptEntryInsert(ReceiptEntryModel receiptEntry)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_recieptDetail_Insert";
//                this.command.Parameters.Add(new SqlParameter("@item", receiptEntry.Item));
//                this.command.Parameters.Add(new SqlParameter("@amount", receiptEntry.Amount));
//                this.command.Parameters.Add(new SqlParameter("@unitprice", receiptEntry.UnitPrice));
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت قبت شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ReceiptEntryUpdate(ReceiptEntryModel receiptEntry)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_recieptDetail_Update";
//                this.command.Parameters.Add(new SqlParameter("@id", receiptEntry.Id));
//                this.command.Parameters.Add(new SqlParameter("@item", receiptEntry.Item));
//                this.command.Parameters.Add(new SqlParameter("@amount", receiptEntry.Amount));
//                this.command.Parameters.Add(new SqlParameter("@unitprice", receiptEntry.UnitPrice));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شدند";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.ReceiptEntryDelete(ReceiptEntryModel receiptEntry)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_recieptDetail_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", receiptEntry.Id));
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        ReceiptEntryModel IDbCommand.ReceiptEntryGet(ReceiptEntryModel receiptEntry)
//        {
//            throw new NotImplementedException();
//        }

//        List<ReceiptEntryModel> IDbCommand.ReceiptEntryList(ReceiptModel receipt)
//        {
//            try
//            {
//                List<ReceiptEntryModel> receiptEntries = new List<ReceiptEntryModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_recieptdetail_read";
//                this.command.Parameters.Add(new SqlParameter("@header", receipt.Id));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    receiptEntries.Add(this.ReceiptReader(dataReader));
//                }
//                return receiptEntries;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        private ReceiptEntryModel ReceiptReader(SqlDataReader dataReader)
//        {
//            return new ReceiptEntryModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                item: dataReader["Item"].ToString(),
//                long.Parse(dataReader["UnitPrice"].ToString()),
//                amount: Convert.ToDecimal(dataReader["Amount"].ToString()));
//        }

//        string IDbCommand.PosInfoInsert(PosInfoModel posInfo)
//        {
//            throw new NotImplementedException();
//        }

//        string IDbCommand.PosInfoUpdate(PosInfoModel posInfo)
//        {
//            throw new NotImplementedException();
//        }

//        string IDbCommand.PosInfoDelete(PosInfoModel posInfo)
//        {
//            throw new NotImplementedException();
//        }

//        PosInfoModel IDbCommand.PosInfoGet(PosInfoModel posInfo)
//        {
//            throw new NotImplementedException();
//        }

//        List<PosInfoModel> IDbCommand.PosInfoList()
//        {
//            throw new NotImplementedException();
//        }

//        string IDbCommand.SupplierCompanyInsert(SupplierCompanyModel supplierCompany)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplierCompany_insert";
//                this.command.Parameters.Add(new SqlParameter("@name", supplierCompany.Name));
//                this.command.Parameters.Add(new SqlParameter("@active", supplierCompany.Active));
//                this.command.ExecuteNonQuery();
//                return "شرکت با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.SupplierCompanyUpdate(SupplierCompanyModel supplierCompany)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplierCompany_update";
//                this.command.Parameters.Add(new SqlParameter("@id", supplierCompany.Id));
//                this.command.Parameters.Add(new SqlParameter("@name", supplierCompany.Name));
//                this.command.Parameters.Add(new SqlParameter("@active", supplierCompany.Active));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.SupplierCompanyDelete(SupplierCompanyModel supplierCompany)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplierCompany_delete";
//                this.command.Parameters.Add(new SqlParameter("@id", supplierCompany.Id));
//                this.command.ExecuteNonQuery();
//                return "شرکت با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        SupplierCompanyModel IDbCommand.SupplierCompanyGet(SupplierCompanyModel supplierCompany)
//        {
//            try
//            {
//                SupplierCompanyModel res;
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplierCompany_get";
//                this.command.Parameters.Add(new SqlParameter("@name", supplierCompany.Name));
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                res = this.SupplierCompanyRead(dataReader);
//                return res;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private SupplierCompanyModel SupplierCompanyRead(SqlDataReader dataReader)
//        {
//            return new SupplierCompanyModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                name: dataReader["Name"].ToString(),
//                Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<SupplierCompanyModel> IDbCommand.SupplierCompanyList()
//        {
//            try
//            {
//                List<SupplierCompanyModel> supplierCompanies = new List<SupplierCompanyModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplierCompany_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    supplierCompanies.Add(this.SupplierCompanyRead(dataReader));
//                }
//                return supplierCompanies;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.SupplierAgentInsert(SupplierAgentModel supplierAgent)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplier_insert";
//                this.command.Parameters.Add(new SqlParameter("@persongroup", supplierAgent.PersonGroup));
//                this.command.Parameters.Add(new SqlParameter("@firstname", supplierAgent.FirstName));
//                this.command.Parameters.Add(new SqlParameter("@lastname", supplierAgent.LastName));
//                this.command.Parameters.Add(new SqlParameter("@gender", (int)supplierAgent.Gender));
//                this.command.Parameters.Add(new SqlParameter("@birthday", supplierAgent.Birthday));
//                this.command.Parameters.Add(new SqlParameter("@mobilenumber", supplierAgent.MobileNumber));
//                this.command.Parameters.Add(new SqlParameter("@email", supplierAgent.Email));
//                this.command.Parameters.Add(new SqlParameter("@company", supplierAgent.Company));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.SupplierAgentUpdate(SupplierAgentModel supplierAgent)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplier_update";
//                this.command.Parameters.Add(new SqlParameter("@id", supplierAgent.Id));
//                this.command.Parameters.Add(new SqlParameter("@persongroup", supplierAgent.PersonGroup));
//                this.command.Parameters.Add(new SqlParameter("@firstname", supplierAgent.FirstName));
//                this.command.Parameters.Add(new SqlParameter("@lastname", supplierAgent.LastName));
//                this.command.Parameters.Add(new SqlParameter("@gender", (int)supplierAgent.Gender));
//                this.command.Parameters.Add(new SqlParameter("@birthday", supplierAgent.Birthday));
//                this.command.Parameters.Add(new SqlParameter("@mobilenumber", supplierAgent.MobileNumber));
//                this.command.Parameters.Add(new SqlParameter("@email", supplierAgent.Email));
//                this.command.Parameters.Add(new SqlParameter("@company", supplierAgent.Company));
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.SupplierAgentDelete(SupplierAgentModel supplierAgent)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplier_insert";
//                this.command.Parameters.Add(new SqlParameter("@id", supplierAgent.Id));
//                this.command.ExecuteNonQuery();
//                return "با موفقیت حذف شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        SupplierAgentModel IDbCommand.SupplierAgentGet(SupplierAgentModel supplierAgent)
//        {
//            throw new NotImplementedException();
//        }

//        List<SupplierAgentModel> IDbCommand.SupplierAgentList()
//        {
//            try
//            {
//                List<SupplierAgentModel> supplierAgents = new List<SupplierAgentModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_supplier_read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    supplierAgents.Add(this.SupplierRead(dataReader));
//                }
//                return supplierAgents;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private SupplierAgentModel SupplierRead(SqlDataReader dataReader)
//        {
//            return new SupplierAgentModel(
//                id: Convert.ToInt32(dataReader["Id"]),
//                code: Convert.ToInt32(dataReader["Code"]),
//                personGroup: dataReader["PersonGroup"].ToString(),
//                firstName: dataReader["FistName"].ToString(),
//                lastName: dataReader["LastName"].ToString(),
//                gender: (Genders)Convert.ToInt32(dataReader["Gender"]),
//                birthday: Convert.ToDateTime(dataReader["Birthda"]),
//                mobileNumber: dataReader["MobileNumber"].ToString(),
//                email: dataReader["Email"].ToString(),
//                company: dataReader["Company"].ToString());
//        }

//        string IDbCommand.TransactionTypeInsert(TransactionTypeModel transactionType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_transactionType_Insert";
//                this.command.Parameters.AddWithValue("@title", transactionType.Title);
//                this.command.Parameters.AddWithValue("@description", transactionType.Description);
//                this.command.Parameters.AddWithValue("@active", transactionType.Active);
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.TransactionTypeUpdate(TransactionTypeModel transactionType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_transactionType_Update";
//                this.command.Parameters.AddWithValue("@id", transactionType.Id);
//                this.command.Parameters.AddWithValue("@title", transactionType.Title);
//                this.command.Parameters.AddWithValue("@description", transactionType.Description);
//                this.command.Parameters.AddWithValue("@active", transactionType.Active);
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.TransactionTypeDelete(TransactionTypeModel transactionType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_transactionType_Delete";
//                this.command.Parameters.AddWithValue("@id", transactionType.Id);
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت ثبت شد";
//            }
//            catch (Exception e)
//            {

//                return e.Message + e.StackTrace;
//            }
//        }

//        TransactionTypeModel IDbCommand.TransactionTypeGet(TransactionTypeModel transactionType)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_transactionType_Get";
//                this.command.Parameters.AddWithValue("@title", transactionType.Title);
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                dataReader.Read();
//                return this.TransactionTypeRead(dataReader);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private TransactionTypeModel TransactionTypeRead(SqlDataReader dataReader)
//        {
//            return new TransactionTypeModel(id: Convert.ToInt32(dataReader["Id"]),
//                title: dataReader["Title"].ToString(),
//                description: dataReader["Description"].ToString(),
//                active: Convert.ToBoolean(dataReader["Active"]));
//        }

//        List<TransactionTypeModel> IDbCommand.TransactionTypeList()
//        {
//            try
//            {
//                List<TransactionTypeModel> transactionTypes = new List<TransactionTypeModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_transactionType_Read";
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    transactionTypes.Add(this.TransactionTypeRead(dataReader));
//                }
//                return transactionTypes;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        string IDbCommand.PluInsert(PluModel plu)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_Plu_Insert";
//                this.command.Parameters.AddWithValue("@item", plu.Item);
//                this.command.Parameters.AddWithValue("@memory", plu.Memory);
//                this.command.Parameters.AddWithValue("@workstation", plu.Workstation);
//                this.command.ExecuteNonQuery();
//                return "آیتم با موفقیت افزوده شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PluUpdate(PluModel plu)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_Plu_Update";
//                this.command.Parameters.AddWithValue("@id", plu.Id);
//                this.command.Parameters.AddWithValue("@item", plu.Item);
//                this.command.Parameters.AddWithValue("@memory", plu.Memory);
//                this.command.Parameters.AddWithValue("@workstation", plu.Workstation);
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        string IDbCommand.PluDelete(PluModel plu)
//        {
//            try
//            {
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_Plu_Update";
//                this.command.Parameters.AddWithValue("@id", plu.Id);
//                this.command.ExecuteNonQuery();
//                return "تغییرات با موفقیت اعمال شد";
//            }
//            catch (Exception e)
//            {
//                return e.Message + e.StackTrace;
//            }
//        }

//        PluModel IDbCommand.PluGet(PluModel plu)
//        {
//            throw new NotImplementedException();
//        }

//        List<PluModel> IDbCommand.PluList(PluModel plu)
//        {
//            try
//            {
//                List<PluModel> plus = new List<PluModel>();
//                this.command.CommandType = System.Data.CommandType.StoredProcedure;
//                this.command.CommandText = "sp_plu_Read";
//                this.command.Parameters.AddWithValue("@workstation", plu.Workstation);
//                SqlDataReader dataReader = this.command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    plus.Add(this.PluRead(dataReader));
//                }
//                return plus;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private PluModel PluRead(SqlDataReader dataReader)
//        {
//            return new PluModel(id: Convert.ToInt32(dataReader["Id"]),
//                item: dataReader["Item"].ToString(),
//                workstation: dataReader["Workstation"].ToString(),
//                memory: Convert.ToInt32(dataReader["Memory"]));
//        }
//    }
//}

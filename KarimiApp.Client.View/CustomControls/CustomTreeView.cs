using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using KarimiApp.Model;

namespace KarimiApp.Client.View.CustomControls
{
    public partial class CustomTreeView : TreeView
    {
        public CustomTreeView()
        {
            InitializeComponent();
            this.AfterCheck += TreeView1_AfterCheck;
        }

        public CustomTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode item in e.Node.Nodes)
            {
                item.Checked = e.Node.Checked;
            }
        }


        private Permission GetItemPermission(string nodeName)
        {
            Permission permission;
            TreeNode node = this.Nodes["Node" + nodeName];
            permission = new Permission(nodeName, node.Checked, node.Nodes["Node" + nodeName + "New"].Checked, node.Nodes["Node" + nodeName + "Edit"].Checked, node.Nodes["Node" + nodeName + "Delete"].Checked);
            return permission;

        }

        private Permission GetItemPermission(string nodeName, string parentNode)
        {
            Permission permission;
            TreeNode node = this.Nodes["Node" + parentNode].Nodes["Node" + nodeName];
            permission = new Permission(nodeName, node.Checked, node.Nodes["Node" + nodeName + "New"].Checked, node.Nodes["Node" + nodeName + "Edit"].Checked, node.Nodes["Node" + nodeName + "Delete"].Checked);
            return permission;
        }

        private Permission GetKartexPermission(string parentNode, string nodeName)
        {
            Permission permission;
            TreeNode node = this.Nodes["Node" + parentNode];
            permission = new Permission(nodeName, node.Nodes["Node" + nodeName].Checked);
            return permission;
        }

        public string GetPermissions()
        {
            List<Permission> permissions = new List<Permission>();
            permissions.Add(GetItemPermission("User"));
            permissions.Add(GetItemPermission("Inventory", "InventoryManagement"));
            permissions.Add(GetItemPermission("InventoryType", "InventoryManagement"));
            permissions.Add(GetItemPermission("Department", "InventoryManagement"));
            permissions.Add(GetKartexPermission("InventoryManagement", "InventoryKartex"));
            permissions.Add(GetItemPermission("ItemCategory", "InventoryManagement"));
            permissions.Add(GetItemPermission("Item", "InventoryManagement"));
            permissions.Add(GetItemPermission("PaymentType", "Accounting"));
            permissions.Add(GetItemPermission("PaymentMethod", "Accounting"));
            permissions.Add(GetItemPermission("PayReason", "Accounting"));
            permissions.Add(GetItemPermission("PayGroup", "Accounting"));
            permissions.Add(GetItemPermission("UserJob"));
            permissions.Add(GetItemPermission("UserRole"));
            permissions.Add(GetItemPermission("Customer"));
            permissions.Add(GetItemPermission("Register"));
            permissions.Add(GetItemPermission("WorkStation"));
            return JsonConvert.SerializeObject(permissions);
        }

        /// <summary>
        /// get permissins string from user role model and deserilize it to list of permissions to use in treeView.
        /// </summary>
        /// <param name="permissionsValue"></param>
        public void SetPermission(string permissionsValue)
        {
            if (!string.IsNullOrEmpty(permissionsValue))
            {
                List<Permission> permissions = JsonConvert.DeserializeObject<List<Permission>>(permissionsValue);
                SetItemPermission(permissions, "Inventory", "InventoryManagement");
                SetItemPermission(permissions, "InventoryType", "InventoryManagement");
                // SetItemPermission(permissions, "InventoryKartex", "Inventory", "InventoryManagement");
                SetKartexPermission(permissions, "InventoryKartex", "InventoryManagement");
                SetItemPermission(permissions, "Department", "InventoryManagement");
                SetItemPermission(permissions, "ItemCategory", "InventoryManagement");
                SetItemPermission(permissions, "Item", "InventoryManagement");
                SetItemPermission(permissions, "PayReason", "Accounting");
                SetItemPermission(permissions, "PayGroup", "Accounting");
                SetItemPermission(permissions, "PaymentType", "Accounting");
                SetItemPermission(permissions, "PaymentMethod", "Accounting");
                SetItemPermission(permissions, "User");
                SetItemPermission(permissions, "UserJob");
                SetItemPermission(permissions, "UserRole");
                SetItemPermission(permissions, "Customer");
                SetItemPermission(permissions, "Register");
                SetItemPermission(permissions, "WorkStation");
                SetRootPermissions();
            }
            
        }

        private void SetKartexPermission(List<Permission> permissions, string nodeName, string parentNodeName)
        {
            this.Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Checked = permissions.Find(x => x.Name == nodeName).List;
        }

        private void SetItemPermission(List<Permission> permissions, string nodeName)
        {
            this.Nodes["Node" + nodeName].Checked = permissions.Find(x => x.Name == nodeName).List;
            this.Nodes["Node" + nodeName].Nodes["Node" + nodeName + "New"].Checked = permissions.Find(x => x.Name == nodeName).Create;
            this.Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Edit"].Checked = permissions.Find(x => x.Name == nodeName).Modify;
            this.Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Delete"].Checked = permissions.Find(x => x.Name == nodeName).Remove;
        }

        private void SetItemPermission(List<Permission> permissions, string nodeName, string parentNodeName)
        {
            this.Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Checked = permissions.Find(x => x.Name == nodeName).List;
            this.Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "New"].Checked = permissions.Find(x => x.Name == nodeName).Create;
            this.Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Edit"].Checked = permissions.Find(x => x.Name == nodeName).Modify;
            this.Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Delete"].Checked = permissions.Find(x => x.Name == nodeName).Remove;
        }

        private void SetItemPermission(List<Permission> permissions, string nodeName, string parentNodeName, string parentParentNodeName)
        {
            this.Nodes["Node" + parentParentNodeName].Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "New"].Checked = permissions.Find(x => x.Name == nodeName).Create;
            this.Nodes["Node" + parentParentNodeName].Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Edit"].Checked = permissions.Find(x => x.Name == nodeName).Modify;
            this.Nodes["Node" + parentParentNodeName].Nodes["Node" + parentNodeName].Nodes["Node" + nodeName].Nodes["Node" + nodeName + "Delete"].Checked = permissions.Find(x => x.Name == nodeName).Remove;
        }
        private void SetRootPermissions()
        {
            if (GetNode("InventoryManagement", "Inventory").Checked == true ||
                GetNode("InventoryManagement", "InventoryType").Checked == true ||
                GetNode("InventoryManagement", "Department").Checked == true ||
                    GetNode("InventoryManagement", "InventoryKartex").Checked == true ||
                    GetNode("InventoryManagement", "ItemCategory").Checked == true ||
                    GetNode("InventoryManagement", "Item").Checked == true)
            {
                this.Nodes["NodeInventoryManagement"].Checked = true;
            }
            if (GetNode("Accounting", "PayGroup").Checked == true ||
               GetNode("Accounting", "PayReason").Checked == true ||
               GetNode("Accounting", "PaymentMethod").Checked == true ||
                   GetNode("Accounting", "PaymentType").Checked == true ||
                   GetNode("InventoryManagement", "ItemCategory").Checked == true ||
                   GetNode("InventoryManagement", "Item").Checked == true)
            {
                this.Nodes["NodeAccounting"].Checked = true;
            }
        }
        private TreeNode GetNode(string parent, string nodeName)
        {
            return this.Nodes["Node" + parent].Nodes["Node" + nodeName];
        }
    }
}

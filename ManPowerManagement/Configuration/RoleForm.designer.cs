namespace ManPowerManagement.Configuration
{
    partial class RoleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRoleSearch = new System.Windows.Forms.TextBox();
            this.btnRoleSearch = new System.Windows.Forms.Button();
            this.lstRole = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lRoleName
            // 
            this.lRoleName.AutoSize = true;
            this.lRoleName.Location = new System.Drawing.Point(31, 29);
            this.lRoleName.Name = "lRoleName";
            this.lRoleName.Size = new System.Drawing.Size(60, 13);
            this.lRoleName.TabIndex = 1;
            this.lRoleName.Text = "Role Name";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(112, 26);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(320, 20);
            this.txtRoleName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(195, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRoleSearch
            // 
            this.txtRoleSearch.Location = new System.Drawing.Point(34, 119);
            this.txtRoleSearch.Name = "txtRoleSearch";
            this.txtRoleSearch.Size = new System.Drawing.Size(210, 20);
            this.txtRoleSearch.TabIndex = 6;
            // 
            // btnRoleSearch
            // 
            this.btnRoleSearch.Location = new System.Drawing.Point(262, 119);
            this.btnRoleSearch.Name = "btnRoleSearch";
            this.btnRoleSearch.Size = new System.Drawing.Size(89, 23);
            this.btnRoleSearch.TabIndex = 7;
            this.btnRoleSearch.Text = "Search";
            this.btnRoleSearch.UseVisualStyleBackColor = true;
            this.btnRoleSearch.Click += new System.EventHandler(this.btnRoleSearch_Click);
            // 
            // lstRole
            // 
            this.lstRole.GridLines = true;
            this.lstRole.Location = new System.Drawing.Point(34, 158);
            this.lstRole.MultiSelect = false;
            this.lstRole.Name = "lstRole";
            this.lstRole.Size = new System.Drawing.Size(398, 163);
            this.lstRole.TabIndex = 8;
            this.lstRole.UseCompatibleStateImageBehavior = false;
            this.lstRole.View = System.Windows.Forms.View.Details;
            this.lstRole.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstRole_ItemCheck);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(357, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(357, 119);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 356);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstRole);
            this.Controls.Add(this.btnRoleSearch);
            this.Controls.Add(this.txtRoleSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lRoleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRoleSearch;
        private System.Windows.Forms.Button btnRoleSearch;
        private System.Windows.Forms.ListView lstRole;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}
namespace ManPowerManagement
{
    partial class Licence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.licenceDataGridView = new System.Windows.Forms.DataGridView();
            this.licenceNameTextBox = new System.Windows.Forms.TextBox();
            this.licenceNameLabel = new System.Windows.Forms.Label();
            this.licenceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.licenceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // licenceDataGridView
            // 
            this.licenceDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.licenceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.licenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.licenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.LicenceCode,
            this.LicenceName,
            this.EntryBy});
            this.licenceDataGridView.Location = new System.Drawing.Point(21, 122);
            this.licenceDataGridView.Name = "licenceDataGridView";
            this.licenceDataGridView.Size = new System.Drawing.Size(440, 150);
            this.licenceDataGridView.TabIndex = 28;
            // 
            // licenceNameTextBox
            // 
            this.licenceNameTextBox.Location = new System.Drawing.Point(111, 75);
            this.licenceNameTextBox.Name = "licenceNameTextBox";
            this.licenceNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.licenceNameTextBox.TabIndex = 27;
            // 
            // licenceNameLabel
            // 
            this.licenceNameLabel.AutoSize = true;
            this.licenceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenceNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.licenceNameLabel.Location = new System.Drawing.Point(18, 76);
            this.licenceNameLabel.Name = "licenceNameLabel";
            this.licenceNameLabel.Size = new System.Drawing.Size(87, 15);
            this.licenceNameLabel.TabIndex = 26;
            this.licenceNameLabel.Text = "Licence Name";
            // 
            // licenceLabel
            // 
            this.licenceLabel.AutoSize = true;
            this.licenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.licenceLabel.Location = new System.Drawing.Point(196, 15);
            this.licenceLabel.Name = "licenceLabel";
            this.licenceLabel.Size = new System.Drawing.Size(97, 29);
            this.licenceLabel.TabIndex = 25;
            this.licenceLabel.Text = "Licence";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(399, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(325, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(251, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // LicenceCode
            // 
            this.LicenceCode.HeaderText = "Licence Code";
            this.LicenceCode.Name = "LicenceCode";
            this.LicenceCode.ReadOnly = true;
            // 
            // LicenceName
            // 
            this.LicenceName.HeaderText = "Licence Name";
            this.LicenceName.Name = "LicenceName";
            this.LicenceName.ReadOnly = true;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // Licence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.licenceDataGridView);
            this.Controls.Add(this.licenceNameTextBox);
            this.Controls.Add(this.licenceNameLabel);
            this.Controls.Add(this.licenceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Licence";
            this.Text = "Licence";
            ((System.ComponentModel.ISupportInitialize)(this.licenceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView licenceDataGridView;
        private System.Windows.Forms.TextBox licenceNameTextBox;
        private System.Windows.Forms.Label licenceNameLabel;
        private System.Windows.Forms.Label licenceLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
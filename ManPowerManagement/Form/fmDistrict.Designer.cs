namespace ManPowerManagement
{
    partial class fmDistrict
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
            this.districtDataGridView = new System.Windows.Forms.DataGridView();
            this.districtNameTextBox = new System.Windows.Forms.TextBox();
            this.districtNameLabel = new System.Windows.Forms.Label();
            this.districtLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.districtDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // districtDataGridView
            // 
            this.districtDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.districtDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.districtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.districtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.DistrictCode,
            this.DistrictName,
            this.EntryBy});
            this.districtDataGridView.Location = new System.Drawing.Point(17, 122);
            this.districtDataGridView.Name = "districtDataGridView";
            this.districtDataGridView.Size = new System.Drawing.Size(440, 150);
            this.districtDataGridView.TabIndex = 35;
            // 
            // districtNameTextBox
            // 
            this.districtNameTextBox.Location = new System.Drawing.Point(107, 75);
            this.districtNameTextBox.Name = "districtNameTextBox";
            this.districtNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.districtNameTextBox.TabIndex = 34;
            // 
            // districtNameLabel
            // 
            this.districtNameLabel.AutoSize = true;
            this.districtNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.districtNameLabel.Location = new System.Drawing.Point(14, 76);
            this.districtNameLabel.Name = "districtNameLabel";
            this.districtNameLabel.Size = new System.Drawing.Size(81, 15);
            this.districtNameLabel.TabIndex = 33;
            this.districtNameLabel.Text = "District Name";
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.districtLabel.Location = new System.Drawing.Point(192, 15);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(86, 29);
            this.districtLabel.TabIndex = 32;
            this.districtLabel.Text = "District";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(395, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(321, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 37;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(247, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // DistrictCode
            // 
            this.DistrictCode.HeaderText = "District Code";
            this.DistrictCode.Name = "DistrictCode";
            this.DistrictCode.ReadOnly = true;
            // 
            // DistrictName
            // 
            this.DistrictName.HeaderText = "District Name";
            this.DistrictName.Name = "DistrictName";
            this.DistrictName.ReadOnly = true;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // District
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.districtDataGridView);
            this.Controls.Add(this.districtNameTextBox);
            this.Controls.Add(this.districtNameLabel);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "District";
            this.Text = "District";
            ((System.ComponentModel.ISupportInitialize)(this.districtDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView districtDataGridView;
        private System.Windows.Forms.TextBox districtNameTextBox;
        private System.Windows.Forms.Label districtNameLabel;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
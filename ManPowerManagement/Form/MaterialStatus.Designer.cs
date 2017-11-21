namespace ManPowerManagement
{
    partial class MaterialStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pfDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfNameTextBox = new System.Windows.Forms.TextBox();
            this.materialStatusNameLabel = new System.Windows.Forms.Label();
            this.materialStatusLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pfDataGridView
            // 
            this.pfDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.pfDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.pfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.MaterialStatusCode,
            this.MaterialStatusName,
            this.EntryBy});
            this.pfDataGridView.Location = new System.Drawing.Point(15, 122);
            this.pfDataGridView.Name = "pfDataGridView";
            this.pfDataGridView.Size = new System.Drawing.Size(487, 150);
            this.pfDataGridView.TabIndex = 28;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // MaterialStatusCode
            // 
            this.MaterialStatusCode.HeaderText = "Material Status Code";
            this.MaterialStatusCode.Name = "MaterialStatusCode";
            this.MaterialStatusCode.ReadOnly = true;
            this.MaterialStatusCode.Width = 135;
            // 
            // MaterialStatusName
            // 
            this.MaterialStatusName.HeaderText = "Material Status Name";
            this.MaterialStatusName.Name = "MaterialStatusName";
            this.MaterialStatusName.ReadOnly = true;
            this.MaterialStatusName.Width = 135;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // pfNameTextBox
            // 
            this.pfNameTextBox.Location = new System.Drawing.Point(144, 75);
            this.pfNameTextBox.Name = "pfNameTextBox";
            this.pfNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.pfNameTextBox.TabIndex = 27;
            // 
            // materialStatusNameLabel
            // 
            this.materialStatusNameLabel.AutoSize = true;
            this.materialStatusNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialStatusNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialStatusNameLabel.Location = new System.Drawing.Point(12, 76);
            this.materialStatusNameLabel.Name = "materialStatusNameLabel";
            this.materialStatusNameLabel.Size = new System.Drawing.Size(126, 15);
            this.materialStatusNameLabel.TabIndex = 26;
            this.materialStatusNameLabel.Text = "Material Status Name";
            // 
            // materialStatusLabel
            // 
            this.materialStatusLabel.AutoSize = true;
            this.materialStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialStatusLabel.Location = new System.Drawing.Point(183, 9);
            this.materialStatusLabel.Name = "materialStatusLabel";
            this.materialStatusLabel.Size = new System.Drawing.Size(171, 29);
            this.materialStatusLabel.TabIndex = 25;
            this.materialStatusLabel.Text = "Material Status";
            this.materialStatusLabel.Click += new System.EventHandler(this.materialStatusLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(432, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(358, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(284, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MaterialStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(519, 287);
            this.Controls.Add(this.pfDataGridView);
            this.Controls.Add(this.pfNameTextBox);
            this.Controls.Add(this.materialStatusNameLabel);
            this.Controls.Add(this.materialStatusLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "MaterialStatus";
            this.Text = "MaterialStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pfDataGridView;
        private System.Windows.Forms.TextBox pfNameTextBox;
        private System.Windows.Forms.Label materialStatusNameLabel;
        private System.Windows.Forms.Label materialStatusLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialStatusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
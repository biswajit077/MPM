namespace ManPowerManagement
{
    partial class MedCat
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
            this.medCatDataGridView = new System.Windows.Forms.DataGridView();
            this.medCatNameTextBox = new System.Windows.Forms.TextBox();
            this.medCatNameLabel = new System.Windows.Forms.Label();
            this.medCatLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedCatCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medCatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medCatDataGridView
            // 
            this.medCatDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.medCatDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medCatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medCatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.MedCatCode,
            this.MedCatName,
            this.EntryBy});
            this.medCatDataGridView.Location = new System.Drawing.Point(15, 122);
            this.medCatDataGridView.Name = "medCatDataGridView";
            this.medCatDataGridView.Size = new System.Drawing.Size(451, 150);
            this.medCatDataGridView.TabIndex = 28;
            // 
            // medCatNameTextBox
            // 
            this.medCatNameTextBox.Location = new System.Drawing.Point(108, 75);
            this.medCatNameTextBox.Name = "medCatNameTextBox";
            this.medCatNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.medCatNameTextBox.TabIndex = 27;
            // 
            // medCatNameLabel
            // 
            this.medCatNameLabel.AutoSize = true;
            this.medCatNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medCatNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.medCatNameLabel.Location = new System.Drawing.Point(12, 76);
            this.medCatNameLabel.Name = "medCatNameLabel";
            this.medCatNameLabel.Size = new System.Drawing.Size(90, 15);
            this.medCatNameLabel.TabIndex = 26;
            this.medCatNameLabel.Text = "Med Cat Name";
            // 
            // medCatLabel
            // 
            this.medCatLabel.AutoSize = true;
            this.medCatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medCatLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.medCatLabel.Location = new System.Drawing.Point(190, 15);
            this.medCatLabel.Name = "medCatLabel";
            this.medCatLabel.Size = new System.Drawing.Size(103, 29);
            this.medCatLabel.TabIndex = 25;
            this.medCatLabel.Text = "Med Cat";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(396, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(322, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(248, 73);
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
            // MedCatCode
            // 
            this.MedCatCode.HeaderText = "Med Cat Code";
            this.MedCatCode.Name = "MedCatCode";
            this.MedCatCode.ReadOnly = true;
            // 
            // MedCatName
            // 
            this.MedCatName.HeaderText = "Med Cat Name";
            this.MedCatName.Name = "MedCatName";
            this.MedCatName.ReadOnly = true;
            this.MedCatName.Width = 135;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // MedCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.medCatDataGridView);
            this.Controls.Add(this.medCatNameTextBox);
            this.Controls.Add(this.medCatNameLabel);
            this.Controls.Add(this.medCatLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "MedCat";
            this.Text = "MedCat";
            ((System.ComponentModel.ISupportInitialize)(this.medCatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medCatDataGridView;
        private System.Windows.Forms.TextBox medCatNameTextBox;
        private System.Windows.Forms.Label medCatNameLabel;
        private System.Windows.Forms.Label medCatLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedCatCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
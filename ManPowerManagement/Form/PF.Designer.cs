namespace ManPowerManagement
{
    partial class PF
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
            this.pfDataGridView = new System.Windows.Forms.DataGridView();
            this.pfNameTextBox = new System.Windows.Forms.TextBox();
            this.pfNameLabel = new System.Windows.Forms.Label();
            this.pfLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pfDataGridView
            // 
            this.pfDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.pfDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.PFCode,
            this.PFName,
            this.EntryBy});
            this.pfDataGridView.Location = new System.Drawing.Point(15, 122);
            this.pfDataGridView.Name = "pfDataGridView";
            this.pfDataGridView.Size = new System.Drawing.Size(440, 150);
            this.pfDataGridView.TabIndex = 21;
            // 
            // pfNameTextBox
            // 
            this.pfNameTextBox.Location = new System.Drawing.Point(91, 75);
            this.pfNameTextBox.Name = "pfNameTextBox";
            this.pfNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.pfNameTextBox.TabIndex = 20;
            // 
            // pfNameLabel
            // 
            this.pfNameLabel.AutoSize = true;
            this.pfNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pfNameLabel.Location = new System.Drawing.Point(12, 76);
            this.pfNameLabel.Name = "pfNameLabel";
            this.pfNameLabel.Size = new System.Drawing.Size(59, 15);
            this.pfNameLabel.TabIndex = 19;
            this.pfNameLabel.Text = "PF Name";
            // 
            // pfLabel
            // 
            this.pfLabel.AutoSize = true;
            this.pfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pfLabel.Location = new System.Drawing.Point(190, 15);
            this.pfLabel.Name = "pfLabel";
            this.pfLabel.Size = new System.Drawing.Size(44, 29);
            this.pfLabel.TabIndex = 18;
            this.pfLabel.Text = "PF";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(379, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(305, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(231, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // PFCode
            // 
            this.PFCode.HeaderText = "PF Code";
            this.PFCode.Name = "PFCode";
            this.PFCode.ReadOnly = true;
            // 
            // PFName
            // 
            this.PFName.HeaderText = "PF Name";
            this.PFName.Name = "PFName";
            this.PFName.ReadOnly = true;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 287);
            this.Controls.Add(this.pfDataGridView);
            this.Controls.Add(this.pfNameTextBox);
            this.Controls.Add(this.pfNameLabel);
            this.Controls.Add(this.pfLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "PF";
            this.Text = "PF";
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pfDataGridView;
        private System.Windows.Forms.TextBox pfNameTextBox;
        private System.Windows.Forms.Label pfNameLabel;
        private System.Windows.Forms.Label pfLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
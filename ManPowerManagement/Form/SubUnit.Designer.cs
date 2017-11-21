namespace ManPowerManagement
{
    partial class SubUnit
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
            this.subUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.subUnitNameTextBox = new System.Windows.Forms.TextBox();
            this.subUnitNameLabel = new System.Windows.Forms.Label();
            this.subUniTtradeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubUniteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subUnitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subUnitDataGridView
            // 
            this.subUnitDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.subUnitDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.subUnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subUnitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.SubUniteCode,
            this.SubUnitName,
            this.EntryBy});
            this.subUnitDataGridView.Location = new System.Drawing.Point(15, 125);
            this.subUnitDataGridView.Name = "subUnitDataGridView";
            this.subUnitDataGridView.Size = new System.Drawing.Size(449, 150);
            this.subUnitDataGridView.TabIndex = 14;
            // 
            // subUnitNameTextBox
            // 
            this.subUnitNameTextBox.Location = new System.Drawing.Point(106, 75);
            this.subUnitNameTextBox.Name = "subUnitNameTextBox";
            this.subUnitNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.subUnitNameTextBox.TabIndex = 13;
            // 
            // subUnitNameLabel
            // 
            this.subUnitNameLabel.AutoSize = true;
            this.subUnitNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subUnitNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subUnitNameLabel.Location = new System.Drawing.Point(12, 76);
            this.subUnitNameLabel.Name = "subUnitNameLabel";
            this.subUnitNameLabel.Size = new System.Drawing.Size(88, 15);
            this.subUnitNameLabel.TabIndex = 12;
            this.subUnitNameLabel.Text = "SubUnit Name";
            // 
            // subUniTtradeLabel
            // 
            this.subUniTtradeLabel.AutoSize = true;
            this.subUniTtradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subUniTtradeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subUniTtradeLabel.Location = new System.Drawing.Point(190, 15);
            this.subUniTtradeLabel.Name = "subUniTtradeLabel";
            this.subUniTtradeLabel.Size = new System.Drawing.Size(98, 29);
            this.subUniTtradeLabel.TabIndex = 11;
            this.subUniTtradeLabel.Text = "SubUnit";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(394, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(320, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(246, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // SubUniteCode
            // 
            this.SubUniteCode.HeaderText = "SubUnit Code";
            this.SubUniteCode.Name = "SubUniteCode";
            this.SubUniteCode.ReadOnly = true;
            // 
            // SubUnitName
            // 
            this.SubUnitName.HeaderText = "SubUnit Name";
            this.SubUnitName.Name = "SubUnitName";
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // SubUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(483, 287);
            this.Controls.Add(this.subUnitDataGridView);
            this.Controls.Add(this.subUnitNameTextBox);
            this.Controls.Add(this.subUnitNameLabel);
            this.Controls.Add(this.subUniTtradeLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "SubUnit";
            this.Text = "SubUnit";
            this.Load += new System.EventHandler(this.SubUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subUnitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subUnitDataGridView;
        private System.Windows.Forms.TextBox subUnitNameTextBox;
        private System.Windows.Forms.Label subUnitNameLabel;
        private System.Windows.Forms.Label subUniTtradeLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubUniteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
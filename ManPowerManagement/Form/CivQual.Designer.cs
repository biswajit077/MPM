namespace ManPowerManagement
{
    partial class CivQual
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
            this.civQualDataGridView = new System.Windows.Forms.DataGridView();
            this.civQualNameTextBox = new System.Windows.Forms.TextBox();
            this.civQualNameLabel = new System.Windows.Forms.Label();
            this.civQualLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CivQualCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CivQualName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.civQualDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // civQualDataGridView
            // 
            this.civQualDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.civQualDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.civQualDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.civQualDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.CivQualCode,
            this.CivQualName,
            this.EntryBy});
            this.civQualDataGridView.Location = new System.Drawing.Point(17, 122);
            this.civQualDataGridView.Name = "civQualDataGridView";
            this.civQualDataGridView.Size = new System.Drawing.Size(440, 150);
            this.civQualDataGridView.TabIndex = 42;
            // 
            // civQualNameTextBox
            // 
            this.civQualNameTextBox.Location = new System.Drawing.Point(107, 75);
            this.civQualNameTextBox.Name = "civQualNameTextBox";
            this.civQualNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.civQualNameTextBox.TabIndex = 41;
            // 
            // civQualNameLabel
            // 
            this.civQualNameLabel.AutoSize = true;
            this.civQualNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civQualNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.civQualNameLabel.Location = new System.Drawing.Point(14, 76);
            this.civQualNameLabel.Name = "civQualNameLabel";
            this.civQualNameLabel.Size = new System.Drawing.Size(89, 15);
            this.civQualNameLabel.TabIndex = 40;
            this.civQualNameLabel.Text = "Civ Qual Name";
            // 
            // civQualLabel
            // 
            this.civQualLabel.AutoSize = true;
            this.civQualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civQualLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.civQualLabel.Location = new System.Drawing.Point(192, 15);
            this.civQualLabel.Name = "civQualLabel";
            this.civQualLabel.Size = new System.Drawing.Size(104, 29);
            this.civQualLabel.TabIndex = 39;
            this.civQualLabel.Text = "Civ Qual";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(395, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(321, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 44;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(247, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // CivQualCode
            // 
            this.CivQualCode.HeaderText = "Civ Qual Code";
            this.CivQualCode.Name = "CivQualCode";
            this.CivQualCode.ReadOnly = true;
            // 
            // CivQualName
            // 
            this.CivQualName.HeaderText = "Civ Qual Name";
            this.CivQualName.Name = "CivQualName";
            this.CivQualName.ReadOnly = true;
            this.CivQualName.Width = 135;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // CivQual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(479, 287);
            this.Controls.Add(this.civQualDataGridView);
            this.Controls.Add(this.civQualNameTextBox);
            this.Controls.Add(this.civQualNameLabel);
            this.Controls.Add(this.civQualLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "CivQual";
            this.Text = "CivQual";
            ((System.ComponentModel.ISupportInitialize)(this.civQualDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView civQualDataGridView;
        private System.Windows.Forms.TextBox civQualNameTextBox;
        private System.Windows.Forms.Label civQualNameLabel;
        private System.Windows.Forms.Label civQualLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CivQualCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CivQualName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
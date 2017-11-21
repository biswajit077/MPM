namespace ManPowerManagement
{
    partial class Loc
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
            this.locDataGridView = new System.Windows.Forms.DataGridView();
            this.locNameTextBox = new System.Windows.Forms.TextBox();
            this.locNameLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.locDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locDataGridView
            // 
            this.locDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.locDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.locDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.LocCode,
            this.LocName,
            this.EntryBy});
            this.locDataGridView.Location = new System.Drawing.Point(15, 122);
            this.locDataGridView.Name = "locDataGridView";
            this.locDataGridView.Size = new System.Drawing.Size(440, 150);
            this.locDataGridView.TabIndex = 14;
            // 
            // locNameTextBox
            // 
            this.locNameTextBox.Location = new System.Drawing.Point(91, 75);
            this.locNameTextBox.Name = "locNameTextBox";
            this.locNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.locNameTextBox.TabIndex = 13;
            // 
            // locNameLabel
            // 
            this.locNameLabel.AutoSize = true;
            this.locNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.locNameLabel.Location = new System.Drawing.Point(12, 76);
            this.locNameLabel.Name = "locNameLabel";
            this.locNameLabel.Size = new System.Drawing.Size(64, 15);
            this.locNameLabel.TabIndex = 12;
            this.locNameLabel.Text = "Loc Name";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.locLabel.Location = new System.Drawing.Point(190, 15);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(52, 29);
            this.locLabel.TabIndex = 11;
            this.locLabel.Text = "Loc";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(379, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(305, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(231, 73);
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
            // LocCode
            // 
            this.LocCode.HeaderText = "Loc Code";
            this.LocCode.Name = "LocCode";
            this.LocCode.ReadOnly = true;
            // 
            // LocName
            // 
            this.LocName.HeaderText = "Loc Name";
            this.LocName.Name = "LocName";
            this.LocName.ReadOnly = true;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // Loc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 287);
            this.Controls.Add(this.locDataGridView);
            this.Controls.Add(this.locNameTextBox);
            this.Controls.Add(this.locNameLabel);
            this.Controls.Add(this.locLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Loc";
            this.Text = "Loc";
            ((System.ComponentModel.ISupportInitialize)(this.locDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView locDataGridView;
        private System.Windows.Forms.TextBox locNameTextBox;
        private System.Windows.Forms.Label locNameLabel;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
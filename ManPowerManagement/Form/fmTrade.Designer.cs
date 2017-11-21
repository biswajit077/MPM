namespace ManPowerManagement
{
    partial class fmTrade
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
            this.tradeDataGridView = new System.Windows.Forms.DataGridView();
            this.tradeNameTextBox = new System.Windows.Forms.TextBox();
            this.tradeNameLabel = new System.Windows.Forms.Label();
            this.tradeLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tradeDataGridView
            // 
            this.tradeDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.tradeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.TradeCode,
            this.TradeName,
            this.EntryBy});
            this.tradeDataGridView.Location = new System.Drawing.Point(12, 116);
            this.tradeDataGridView.Name = "tradeDataGridView";
            this.tradeDataGridView.Size = new System.Drawing.Size(440, 150);
            this.tradeDataGridView.TabIndex = 7;
            // 
            // tradeNameTextBox
            // 
            this.tradeNameTextBox.Location = new System.Drawing.Point(88, 69);
            this.tradeNameTextBox.Name = "tradeNameTextBox";
            this.tradeNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.tradeNameTextBox.TabIndex = 6;
            // 
            // tradeNameLabel
            // 
            this.tradeNameLabel.AutoSize = true;
            this.tradeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tradeNameLabel.Location = new System.Drawing.Point(9, 70);
            this.tradeNameLabel.Name = "tradeNameLabel";
            this.tradeNameLabel.Size = new System.Drawing.Size(76, 15);
            this.tradeNameLabel.TabIndex = 5;
            this.tradeNameLabel.Text = "Trade Name";
            // 
            // tradeLabel
            // 
            this.tradeLabel.AutoSize = true;
            this.tradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tradeLabel.Location = new System.Drawing.Point(187, 9);
            this.tradeLabel.Name = "tradeLabel";
            this.tradeLabel.Size = new System.Drawing.Size(78, 29);
            this.tradeLabel.TabIndex = 4;
            this.tradeLabel.Text = "Trade";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(376, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(302, 67);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(228, 67);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // TradeCode
            // 
            this.TradeCode.HeaderText = "Trade Code";
            this.TradeCode.Name = "TradeCode";
            this.TradeCode.ReadOnly = true;
            // 
            // TradeName
            // 
            this.TradeName.HeaderText = "Trade Name";
            this.TradeName.Name = "TradeName";
            this.TradeName.ReadOnly = true;
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            this.EntryBy.ReadOnly = true;
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 287);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tradeDataGridView);
            this.Controls.Add(this.tradeNameTextBox);
            this.Controls.Add(this.tradeNameLabel);
            this.Controls.Add(this.tradeLabel);
            this.Name = "Trade";
            this.Text = "Trade";
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tradeDataGridView;
        private System.Windows.Forms.TextBox tradeNameTextBox;
        private System.Windows.Forms.Label tradeNameLabel;
        private System.Windows.Forms.Label tradeLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
    }
}
namespace ManPowerManagement
{
    partial class fmRank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankNameLabel = new System.Windows.Forms.Label();
            this.rankNameTextBox = new System.Windows.Forms.TextBox();
            this.rankDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rankDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rankLabel.Location = new System.Drawing.Point(188, 9);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(68, 29);
            this.rankLabel.TabIndex = 0;
            this.rankLabel.Text = "Rank";
            // 
            // rankNameLabel
            // 
            this.rankNameLabel.AutoSize = true;
            this.rankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rankNameLabel.Location = new System.Drawing.Point(11, 69);
            this.rankNameLabel.Name = "rankNameLabel";
            this.rankNameLabel.Size = new System.Drawing.Size(73, 15);
            this.rankNameLabel.TabIndex = 1;
            this.rankNameLabel.Text = "Rank Name";
            // 
            // rankNameTextBox
            // 
            this.rankNameTextBox.Location = new System.Drawing.Point(90, 68);
            this.rankNameTextBox.Name = "rankNameTextBox";
            this.rankNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.rankNameTextBox.TabIndex = 2;
            // 
            // rankDataGridView
            // 
            this.rankDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.rankDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.rankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.RankCode,
            this.RankName,
            this.EntryBy});
            this.rankDataGridView.Location = new System.Drawing.Point(12, 117);
            this.rankDataGridView.Name = "rankDataGridView";
            this.rankDataGridView.Size = new System.Drawing.Size(440, 150);
            this.rankDataGridView.TabIndex = 3;
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // RankCode
            // 
            this.RankCode.HeaderText = "Rank Code";
            this.RankCode.Name = "RankCode";
            // 
            // RankName
            // 
            this.RankName.HeaderText = "Rank Name";
            this.RankName.Name = "RankName";
            // 
            // EntryBy
            // 
            this.EntryBy.HeaderText = "Entry By";
            this.EntryBy.Name = "EntryBy";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(230, 68);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(304, 68);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 22);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(378, 68);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 22);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 287);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rankDataGridView);
            this.Controls.Add(this.rankNameTextBox);
            this.Controls.Add(this.rankNameLabel);
            this.Controls.Add(this.rankLabel);
            this.Name = "Rank";
            this.Text = "Rank";
            ((System.ComponentModel.ISupportInitialize)(this.rankDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label rankNameLabel;
        private System.Windows.Forms.TextBox rankNameTextBox;
        private System.Windows.Forms.DataGridView rankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBy;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
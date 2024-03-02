namespace SemesterProjectTest
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adBtnInsert = new System.Windows.Forms.Button();
            this.adBtnDelete = new System.Windows.Forms.Button();
            this.adBtnUpdate = new System.Windows.Forms.Button();
            this.adBtnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adBtnInsert
            // 
            this.adBtnInsert.Location = new System.Drawing.Point(481, 41);
            this.adBtnInsert.Name = "adBtnInsert";
            this.adBtnInsert.Size = new System.Drawing.Size(89, 39);
            this.adBtnInsert.TabIndex = 1;
            this.adBtnInsert.Text = "Insert";
            this.adBtnInsert.UseVisualStyleBackColor = true;
            this.adBtnInsert.Click += new System.EventHandler(this.adBtnInsert_Click);
            // 
            // adBtnDelete
            // 
            this.adBtnDelete.Location = new System.Drawing.Point(481, 96);
            this.adBtnDelete.Name = "adBtnDelete";
            this.adBtnDelete.Size = new System.Drawing.Size(89, 39);
            this.adBtnDelete.TabIndex = 2;
            this.adBtnDelete.Text = "Delete";
            this.adBtnDelete.UseVisualStyleBackColor = true;
            this.adBtnDelete.Click += new System.EventHandler(this.adBtnDelete_Click);
            // 
            // adBtnUpdate
            // 
            this.adBtnUpdate.Location = new System.Drawing.Point(481, 154);
            this.adBtnUpdate.Name = "adBtnUpdate";
            this.adBtnUpdate.Size = new System.Drawing.Size(89, 39);
            this.adBtnUpdate.TabIndex = 3;
            this.adBtnUpdate.Text = "Update";
            this.adBtnUpdate.UseVisualStyleBackColor = true;
            this.adBtnUpdate.Click += new System.EventHandler(this.adBtnUpdate_Click);
            // 
            // adBtnDisplay
            // 
            this.adBtnDisplay.Location = new System.Drawing.Point(481, 208);
            this.adBtnDisplay.Name = "adBtnDisplay";
            this.adBtnDisplay.Size = new System.Drawing.Size(89, 39);
            this.adBtnDisplay.TabIndex = 4;
            this.adBtnDisplay.Text = "Display";
            this.adBtnDisplay.UseVisualStyleBackColor = true;
            this.adBtnDisplay.Click += new System.EventHandler(this.adBtnDisplay_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 521);
            this.Controls.Add(this.adBtnDisplay);
            this.Controls.Add(this.adBtnUpdate);
            this.Controls.Add(this.adBtnDelete);
            this.Controls.Add(this.adBtnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adBtnInsert;
        private System.Windows.Forms.Button adBtnDelete;
        private System.Windows.Forms.Button adBtnUpdate;
        private System.Windows.Forms.Button adBtnDisplay;
    }
}
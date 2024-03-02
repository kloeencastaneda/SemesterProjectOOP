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
            this.goMenu = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // goMenu
            // 
            this.goMenu.Location = new System.Drawing.Point(595, 455);
            this.goMenu.Name = "goMenu";
            this.goMenu.Size = new System.Drawing.Size(115, 35);
            this.goMenu.TabIndex = 5;
            this.goMenu.Text = "Menu Management";
            this.goMenu.UseVisualStyleBackColor = true;
            this.goMenu.Click += new System.EventHandler(this.goMenu_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(240, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(173, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(173, 218);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(240, 20);
            this.txtRole.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(121, 56);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Role";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.goMenu);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adBtnInsert;
        private System.Windows.Forms.Button adBtnDelete;
        private System.Windows.Forms.Button adBtnUpdate;
        private System.Windows.Forms.Button adBtnDisplay;
        private System.Windows.Forms.Button goMenu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
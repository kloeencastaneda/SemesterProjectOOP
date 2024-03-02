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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adBtnInsert
            // 
            this.adBtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBtnInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.adBtnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.adBtnInsert.Location = new System.Drawing.Point(630, 258);
            this.adBtnInsert.Name = "adBtnInsert";
            this.adBtnInsert.Size = new System.Drawing.Size(89, 39);
            this.adBtnInsert.TabIndex = 1;
            this.adBtnInsert.Text = "Insert";
            this.adBtnInsert.UseVisualStyleBackColor = false;
            this.adBtnInsert.Click += new System.EventHandler(this.adBtnInsert_Click);
            // 
            // adBtnDelete
            // 
            this.adBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBtnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.adBtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.adBtnDelete.Location = new System.Drawing.Point(630, 320);
            this.adBtnDelete.Name = "adBtnDelete";
            this.adBtnDelete.Size = new System.Drawing.Size(89, 39);
            this.adBtnDelete.TabIndex = 2;
            this.adBtnDelete.Text = "Delete";
            this.adBtnDelete.UseVisualStyleBackColor = false;
            this.adBtnDelete.Click += new System.EventHandler(this.adBtnDelete_Click);
            // 
            // adBtnUpdate
            // 
            this.adBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBtnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.adBtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.adBtnUpdate.Location = new System.Drawing.Point(630, 385);
            this.adBtnUpdate.Name = "adBtnUpdate";
            this.adBtnUpdate.Size = new System.Drawing.Size(89, 39);
            this.adBtnUpdate.TabIndex = 3;
            this.adBtnUpdate.Text = "Update";
            this.adBtnUpdate.UseVisualStyleBackColor = false;
            this.adBtnUpdate.Click += new System.EventHandler(this.adBtnUpdate_Click);
            // 
            // adBtnDisplay
            // 
            this.adBtnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.adBtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBtnDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.adBtnDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.adBtnDisplay.Location = new System.Drawing.Point(630, 454);
            this.adBtnDisplay.Name = "adBtnDisplay";
            this.adBtnDisplay.Size = new System.Drawing.Size(89, 39);
            this.adBtnDisplay.TabIndex = 4;
            this.adBtnDisplay.Text = "Display";
            this.adBtnDisplay.UseVisualStyleBackColor = false;
            this.adBtnDisplay.Click += new System.EventHandler(this.adBtnDisplay_Click);
            // 
            // goMenu
            // 
            this.goMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.goMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.goMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.goMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.goMenu.Location = new System.Drawing.Point(577, 73);
            this.goMenu.Name = "goMenu";
            this.goMenu.Size = new System.Drawing.Size(142, 35);
            this.goMenu.TabIndex = 5;
            this.goMenu.Text = "Go To Menu";
            this.goMenu.UseVisualStyleBackColor = false;
            this.goMenu.Click += new System.EventHandler(this.goMenu_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(94, 206);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(79, 20);
            this.txtRole.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.ID.Location = new System.Drawing.Point(32, 38);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(34, 27);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 32F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(437, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 59);
            this.label4.TabIndex = 14;
            this.label4.Text = "Manage Users";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(743, 521);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
    }
}
namespace SemesterProjectTest
{
    partial class TableDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.staffBtnInsert = new System.Windows.Forms.Button();
            this.staffBtnDelete = new System.Windows.Forms.Button();
            this.staffBtnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff Assigned:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Available?";
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(181, 36);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(100, 20);
            this.txtTableID.TabIndex = 6;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(126, 74);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 7;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(187, 110);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(164, 148);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 9;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(154, 192);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(100, 20);
            this.txtAvailability.TabIndex = 10;
            // 
            // staffBtnInsert
            // 
            this.staffBtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtnInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.staffBtnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.staffBtnInsert.Location = new System.Drawing.Point(63, 284);
            this.staffBtnInsert.Name = "staffBtnInsert";
            this.staffBtnInsert.Size = new System.Drawing.Size(89, 39);
            this.staffBtnInsert.TabIndex = 11;
            this.staffBtnInsert.Text = "Insert";
            this.staffBtnInsert.UseVisualStyleBackColor = false;
            this.staffBtnInsert.Click += new System.EventHandler(this.staffBtnInsert_Click);
            // 
            // staffBtnDelete
            // 
            this.staffBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.staffBtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.staffBtnDelete.Location = new System.Drawing.Point(63, 373);
            this.staffBtnDelete.Name = "staffBtnDelete";
            this.staffBtnDelete.Size = new System.Drawing.Size(89, 39);
            this.staffBtnDelete.TabIndex = 12;
            this.staffBtnDelete.Text = "Delete";
            this.staffBtnDelete.UseVisualStyleBackColor = false;
            this.staffBtnDelete.Click += new System.EventHandler(this.staffBtnDelete_Click);
            // 
            // staffBtnUpdate
            // 
            this.staffBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.staffBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.staffBtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.staffBtnUpdate.Location = new System.Drawing.Point(198, 329);
            this.staffBtnUpdate.Name = "staffBtnUpdate";
            this.staffBtnUpdate.Size = new System.Drawing.Size(89, 39);
            this.staffBtnUpdate.TabIndex = 13;
            this.staffBtnUpdate.Text = "Update";
            this.staffBtnUpdate.UseVisualStyleBackColor = false;
            this.staffBtnUpdate.Click += new System.EventHandler(this.staffBtnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(485, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Table Details";
            // 
            // TableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.staffBtnUpdate);
            this.Controls.Add(this.staffBtnDelete);
            this.Controls.Add(this.staffBtnInsert);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TableDetails";
            this.Text = "TableDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Button staffBtnInsert;
        private System.Windows.Forms.Button staffBtnDelete;
        private System.Windows.Forms.Button staffBtnUpdate;
        private System.Windows.Forms.Label label6;
    }
}
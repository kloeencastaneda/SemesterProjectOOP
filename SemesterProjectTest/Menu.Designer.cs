namespace SemesterProjectTest
{
    partial class Menu
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
            this.menuBtnAdd = new System.Windows.Forms.Button();
            this.menuUpdateBtn = new System.Windows.Forms.Button();
            this.menuDelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuBtnAdd
            // 
            this.menuBtnAdd.Location = new System.Drawing.Point(555, 22);
            this.menuBtnAdd.Name = "menuBtnAdd";
            this.menuBtnAdd.Size = new System.Drawing.Size(121, 41);
            this.menuBtnAdd.TabIndex = 1;
            this.menuBtnAdd.Text = "Add Item";
            this.menuBtnAdd.UseVisualStyleBackColor = true;
            // 
            // menuUpdateBtn
            // 
            this.menuUpdateBtn.Location = new System.Drawing.Point(555, 138);
            this.menuUpdateBtn.Name = "menuUpdateBtn";
            this.menuUpdateBtn.Size = new System.Drawing.Size(121, 41);
            this.menuUpdateBtn.TabIndex = 2;
            this.menuUpdateBtn.Text = "Update Item";
            this.menuUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // menuDelBtn
            // 
            this.menuDelBtn.Location = new System.Drawing.Point(555, 78);
            this.menuDelBtn.Name = "menuDelBtn";
            this.menuDelBtn.Size = new System.Drawing.Size(121, 41);
            this.menuDelBtn.TabIndex = 3;
            this.menuDelBtn.Text = "Remove Item";
            this.menuDelBtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuDelBtn);
            this.Controls.Add(this.menuUpdateBtn);
            this.Controls.Add(this.menuBtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button menuBtnAdd;
        private System.Windows.Forms.Button menuUpdateBtn;
        private System.Windows.Forms.Button menuDelBtn;
    }
}
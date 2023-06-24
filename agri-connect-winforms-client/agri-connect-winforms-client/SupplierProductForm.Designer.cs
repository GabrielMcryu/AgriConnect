
namespace agri_connect_winforms_client
{
    partial class SupplierProductForm
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
            this.idField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addSupplierProductButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateSupplierProductButton = new System.Windows.Forms.Button();
            this.deleteSupplierProductButton = new System.Windows.Forms.Button();
            this.GetSupplierProductButton = new System.Windows.Forms.Button();
            this.GetAllSupplierProductsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 158);
            this.dataGridView1.TabIndex = 3;
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(119, 52);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 23);
            this.idField.TabIndex = 4;
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(119, 89);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 23);
            this.nameField.TabIndex = 5;
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceField.Location = new System.Drawing.Point(119, 127);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(100, 23);
            this.priceField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price:";
            // 
            // addSupplierProductButton
            // 
            this.addSupplierProductButton.Location = new System.Drawing.Point(27, 186);
            this.addSupplierProductButton.Name = "addSupplierProductButton";
            this.addSupplierProductButton.Size = new System.Drawing.Size(75, 23);
            this.addSupplierProductButton.TabIndex = 10;
            this.addSupplierProductButton.Text = "Add Product";
            this.addSupplierProductButton.UseVisualStyleBackColor = true;
            this.addSupplierProductButton.Click += new System.EventHandler(this.addSupplierProductButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier Product Board";
            // 
            // updateSupplierProductButton
            // 
            this.updateSupplierProductButton.Location = new System.Drawing.Point(119, 186);
            this.updateSupplierProductButton.Name = "updateSupplierProductButton";
            this.updateSupplierProductButton.Size = new System.Drawing.Size(90, 23);
            this.updateSupplierProductButton.TabIndex = 12;
            this.updateSupplierProductButton.Text = "Update Product";
            this.updateSupplierProductButton.UseVisualStyleBackColor = true;
            this.updateSupplierProductButton.Click += new System.EventHandler(this.updateSupplierProductButton_Click);
            // 
            // deleteSupplierProductButton
            // 
            this.deleteSupplierProductButton.Location = new System.Drawing.Point(234, 185);
            this.deleteSupplierProductButton.Name = "deleteSupplierProductButton";
            this.deleteSupplierProductButton.Size = new System.Drawing.Size(88, 23);
            this.deleteSupplierProductButton.TabIndex = 13;
            this.deleteSupplierProductButton.Text = "Delete Product";
            this.deleteSupplierProductButton.UseVisualStyleBackColor = true;
            this.deleteSupplierProductButton.Click += new System.EventHandler(this.deleteSupplierProductButton_Click);
            // 
            // GetSupplierProductButton
            // 
            this.GetSupplierProductButton.Location = new System.Drawing.Point(27, 215);
            this.GetSupplierProductButton.Name = "GetSupplierProductButton";
            this.GetSupplierProductButton.Size = new System.Drawing.Size(75, 23);
            this.GetSupplierProductButton.TabIndex = 14;
            this.GetSupplierProductButton.Text = "Get Product";
            this.GetSupplierProductButton.UseVisualStyleBackColor = true;
            this.GetSupplierProductButton.Click += new System.EventHandler(this.GetSupplierProductButton_Click);
            // 
            // GetAllSupplierProductsButton
            // 
            this.GetAllSupplierProductsButton.Location = new System.Drawing.Point(119, 214);
            this.GetAllSupplierProductsButton.Name = "GetAllSupplierProductsButton";
            this.GetAllSupplierProductsButton.Size = new System.Drawing.Size(100, 23);
            this.GetAllSupplierProductsButton.TabIndex = 15;
            this.GetAllSupplierProductsButton.Text = "Get All Products";
            this.GetAllSupplierProductsButton.UseVisualStyleBackColor = true;
            this.GetAllSupplierProductsButton.Click += new System.EventHandler(this.GetAllSupplierProductsButton_Click);
            // 
            // SupplierProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAllSupplierProductsButton);
            this.Controls.Add(this.GetSupplierProductButton);
            this.Controls.Add(this.deleteSupplierProductButton);
            this.Controls.Add(this.updateSupplierProductButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addSupplierProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierProductForm";
            this.Text = "SupplierProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupplierProductForm_FormClosing);
            this.Load += new System.EventHandler(this.SupplierProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSupplierProductButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateSupplierProductButton;
        private System.Windows.Forms.Button deleteSupplierProductButton;
        private System.Windows.Forms.Button GetSupplierProductButton;
        private System.Windows.Forms.Button GetAllSupplierProductsButton;
    }
}
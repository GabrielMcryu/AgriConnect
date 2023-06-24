
namespace agri_connect_winforms_client
{
    partial class VendorProductForm
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
            this.GetAllVendorProductsButton = new System.Windows.Forms.Button();
            this.GetVendorProductButton = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.AddVendorProductButton = new System.Windows.Forms.Button();
            this.UpdateVendorProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // GetAllVendorProductsButton
            // 
            this.GetAllVendorProductsButton.Location = new System.Drawing.Point(333, 185);
            this.GetAllVendorProductsButton.Name = "GetAllVendorProductsButton";
            this.GetAllVendorProductsButton.Size = new System.Drawing.Size(102, 23);
            this.GetAllVendorProductsButton.TabIndex = 1;
            this.GetAllVendorProductsButton.Text = "Get All Products";
            this.GetAllVendorProductsButton.UseVisualStyleBackColor = true;
            this.GetAllVendorProductsButton.Click += new System.EventHandler(this.GetAllVendorProductsButton_Click);
            // 
            // GetVendorProductButton
            // 
            this.GetVendorProductButton.Location = new System.Drawing.Point(230, 185);
            this.GetVendorProductButton.Name = "GetVendorProductButton";
            this.GetVendorProductButton.Size = new System.Drawing.Size(75, 23);
            this.GetVendorProductButton.TabIndex = 2;
            this.GetVendorProductButton.Text = "Get Product";
            this.GetVendorProductButton.UseVisualStyleBackColor = true;
            this.GetVendorProductButton.Click += new System.EventHandler(this.GetVendorProductButton_Click);
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(104, 43);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 23);
            this.idField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(104, 84);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 23);
            this.nameField.TabIndex = 7;
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceField.Location = new System.Drawing.Point(104, 121);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(100, 23);
            this.priceField.TabIndex = 8;
            // 
            // AddVendorProductButton
            // 
            this.AddVendorProductButton.Location = new System.Drawing.Point(116, 184);
            this.AddVendorProductButton.Name = "AddVendorProductButton";
            this.AddVendorProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddVendorProductButton.TabIndex = 9;
            this.AddVendorProductButton.Text = "Add Product";
            this.AddVendorProductButton.UseVisualStyleBackColor = true;
            this.AddVendorProductButton.Click += new System.EventHandler(this.AddVendorProductButton_Click);
            // 
            // UpdateVendorProductButton
            // 
            this.UpdateVendorProductButton.Location = new System.Drawing.Point(116, 229);
            this.UpdateVendorProductButton.Name = "UpdateVendorProductButton";
            this.UpdateVendorProductButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateVendorProductButton.TabIndex = 10;
            this.UpdateVendorProductButton.Text = "Update Product";
            this.UpdateVendorProductButton.UseVisualStyleBackColor = true;
            this.UpdateVendorProductButton.Click += new System.EventHandler(this.UpdateVendorProductButton_Click);
            // 
            // VendorProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateVendorProductButton);
            this.Controls.Add(this.AddVendorProductButton);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.GetVendorProductButton);
            this.Controls.Add(this.GetAllVendorProductsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VendorProductForm";
            this.Text = "VendorProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorProductForm_FormClosing);
            this.Load += new System.EventHandler(this.VendorProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetAllVendorProductsButton;
        private System.Windows.Forms.Button GetVendorProductButton;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Button AddVendorProductButton;
        private System.Windows.Forms.Button UpdateVendorProductButton;
    }
}
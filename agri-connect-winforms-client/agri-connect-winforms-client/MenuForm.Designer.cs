﻿
namespace agri_connect_winforms_client
{
    partial class MenuForm
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
            this.sp_button = new System.Windows.Forms.Button();
            this.st_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sp_button
            // 
            this.sp_button.Location = new System.Drawing.Point(116, 69);
            this.sp_button.Name = "sp_button";
            this.sp_button.Size = new System.Drawing.Size(129, 23);
            this.sp_button.TabIndex = 0;
            this.sp_button.Text = "Supplier Product";
            this.sp_button.UseVisualStyleBackColor = true;
            this.sp_button.Click += new System.EventHandler(this.sp_button_Click);
            // 
            // st_button
            // 
            this.st_button.Location = new System.Drawing.Point(116, 140);
            this.st_button.Name = "st_button";
            this.st_button.Size = new System.Drawing.Size(129, 23);
            this.st_button.TabIndex = 1;
            this.st_button.Text = "Supplier Transaction";
            this.st_button.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vendor Product";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Vendor Trnasaction";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.st_button);
            this.Controls.Add(this.sp_button);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sp_button;
        private System.Windows.Forms.Button st_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
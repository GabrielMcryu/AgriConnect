
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
            this.vp_button = new System.Windows.Forms.Button();
            this.vt_button = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
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
            this.st_button.Click += new System.EventHandler(this.st_button_Click);
            // 
            // vp_button
            // 
            this.vp_button.Location = new System.Drawing.Point(116, 204);
            this.vp_button.Name = "vp_button";
            this.vp_button.Size = new System.Drawing.Size(129, 23);
            this.vp_button.TabIndex = 2;
            this.vp_button.Text = "Vendor Product";
            this.vp_button.UseVisualStyleBackColor = true;
            this.vp_button.Click += new System.EventHandler(this.vp_button_Click);
            // 
            // vt_button
            // 
            this.vt_button.Location = new System.Drawing.Point(116, 270);
            this.vt_button.Name = "vt_button";
            this.vt_button.Size = new System.Drawing.Size(129, 23);
            this.vt_button.TabIndex = 3;
            this.vt_button.Text = "Vendor Transaction";
            this.vt_button.UseVisualStyleBackColor = true;
            this.vt_button.Click += new System.EventHandler(this.vt_button_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(116, 329);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(129, 23);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 417);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.vt_button);
            this.Controls.Add(this.vp_button);
            this.Controls.Add(this.st_button);
            this.Controls.Add(this.sp_button);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Shown += new System.EventHandler(this.MenuForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sp_button;
        private System.Windows.Forms.Button st_button;
        private System.Windows.Forms.Button vp_button;
        private System.Windows.Forms.Button vt_button;
        private System.Windows.Forms.Button userButton;
    }
}
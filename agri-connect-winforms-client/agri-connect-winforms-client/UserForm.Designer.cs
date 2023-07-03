
namespace agri_connect_winforms_client
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetUserByIdButton = new System.Windows.Forms.Button();
            this.GetUsersByUsernameButton = new System.Windows.Forms.Button();
            this.GetUsersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(158, 44);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(139, 23);
            this.idField.TabIndex = 2;
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(158, 86);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(139, 23);
            this.usernameField.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // GetUserByIdButton
            // 
            this.GetUserByIdButton.Location = new System.Drawing.Point(43, 159);
            this.GetUserByIdButton.Name = "GetUserByIdButton";
            this.GetUserByIdButton.Size = new System.Drawing.Size(75, 23);
            this.GetUserByIdButton.TabIndex = 5;
            this.GetUserByIdButton.Text = "Get User";
            this.GetUserByIdButton.UseVisualStyleBackColor = true;
            this.GetUserByIdButton.Click += new System.EventHandler(this.GetUserByIdButton_Click);
            // 
            // GetUsersByUsernameButton
            // 
            this.GetUsersByUsernameButton.Location = new System.Drawing.Point(147, 159);
            this.GetUsersByUsernameButton.Name = "GetUsersByUsernameButton";
            this.GetUsersByUsernameButton.Size = new System.Drawing.Size(133, 23);
            this.GetUsersByUsernameButton.TabIndex = 6;
            this.GetUsersByUsernameButton.Text = "Get By Username";
            this.GetUsersByUsernameButton.UseVisualStyleBackColor = true;
            this.GetUsersByUsernameButton.Click += new System.EventHandler(this.GetUsersByUsernameButton_Click);
            // 
            // GetUsersButton
            // 
            this.GetUsersButton.Location = new System.Drawing.Point(308, 159);
            this.GetUsersButton.Name = "GetUsersButton";
            this.GetUsersButton.Size = new System.Drawing.Size(99, 23);
            this.GetUsersButton.TabIndex = 7;
            this.GetUsersButton.Text = "Get All Users";
            this.GetUsersButton.UseVisualStyleBackColor = true;
            this.GetUsersButton.Click += new System.EventHandler(this.GetUsersButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetUsersButton);
            this.Controls.Add(this.GetUsersByUsernameButton);
            this.Controls.Add(this.GetUserByIdButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetUserByIdButton;
        private System.Windows.Forms.Button GetUsersByUsernameButton;
        private System.Windows.Forms.Button GetUsersButton;
    }
}
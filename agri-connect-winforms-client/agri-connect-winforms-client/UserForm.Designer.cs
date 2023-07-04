
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(158, 24);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(139, 23);
            this.idField.TabIndex = 2;
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(158, 58);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(139, 23);
            this.usernameField.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 164);
            this.dataGridView1.TabIndex = 4;
            // 
            // GetUserByIdButton
            // 
            this.GetUserByIdButton.Location = new System.Drawing.Point(404, 99);
            this.GetUserByIdButton.Name = "GetUserByIdButton";
            this.GetUserByIdButton.Size = new System.Drawing.Size(75, 23);
            this.GetUserByIdButton.TabIndex = 5;
            this.GetUserByIdButton.Text = "Get User";
            this.GetUserByIdButton.UseVisualStyleBackColor = true;
            this.GetUserByIdButton.Click += new System.EventHandler(this.GetUserByIdButton_Click);
            // 
            // GetUsersByUsernameButton
            // 
            this.GetUsersByUsernameButton.Location = new System.Drawing.Point(404, 61);
            this.GetUsersByUsernameButton.Name = "GetUsersByUsernameButton";
            this.GetUsersByUsernameButton.Size = new System.Drawing.Size(133, 23);
            this.GetUsersByUsernameButton.TabIndex = 6;
            this.GetUsersByUsernameButton.Text = "Get By Username";
            this.GetUsersByUsernameButton.UseVisualStyleBackColor = true;
            this.GetUsersByUsernameButton.Click += new System.EventHandler(this.GetUsersByUsernameButton_Click);
            // 
            // GetUsersButton
            // 
            this.GetUsersButton.Location = new System.Drawing.Point(404, 21);
            this.GetUsersButton.Name = "GetUsersButton";
            this.GetUsersButton.Size = new System.Drawing.Size(99, 23);
            this.GetUsersButton.TabIndex = 7;
            this.GetUsersButton.Text = "Get All Users";
            this.GetUsersButton.UseVisualStyleBackColor = true;
            this.GetUsersButton.Click += new System.EventHandler(this.GetUsersButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FirstName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "LastName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password:";
            // 
            // firstNameField
            // 
            this.firstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameField.Location = new System.Drawing.Point(158, 96);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(139, 23);
            this.firstNameField.TabIndex = 13;
            // 
            // lastNameField
            // 
            this.lastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameField.Location = new System.Drawing.Point(158, 132);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(139, 23);
            this.lastNameField.TabIndex = 14;
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(158, 175);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(139, 23);
            this.emailField.TabIndex = 15;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(158, 213);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(139, 23);
            this.passwordField.TabIndex = 16;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(404, 147);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(99, 23);
            this.createUserButton.TabIndex = 17;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button createUserButton;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using shared_interfaces;
using shared_interfaces.DTO;


namespace agri_connect_winforms_client
{
    public partial class UserForm : Form
    {
        private IUser iUser;
        private DataTable usersTable;
        private TcpChannel channel;

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            iUser = (IUser)Activator.GetObject(
                typeof(IUser), "tcp://localhost:12345/User");

            ListUsers();
        }

        private void ListUsers()
        {
            usersTable = new DataTable();
            usersTable.Columns.Add("ID", typeof(int));
            usersTable.Columns.Add("First Name", typeof(string));
            usersTable.Columns.Add("Last Name", typeof(string));
            usersTable.Columns.Add("Username", typeof(string));
            usersTable.Columns.Add("Role", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));

            List<UserDto> users = iUser.GetUsers();
            foreach (var user in users)
            {
                usersTable.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Role, user.Email);
            }

            dataGridView1.DataSource = usersTable;
        }

        private void ListUsersById(int id)
        {
            usersTable = new DataTable();
            usersTable.Columns.Add("ID", typeof(int));
            usersTable.Columns.Add("First Name", typeof(string));
            usersTable.Columns.Add("Last Name", typeof(string));
            usersTable.Columns.Add("Username", typeof(string));
            usersTable.Columns.Add("Role", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));

            UserDto user = iUser.GetUserById(id);

            usersTable.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Role, user.Email);

            dataGridView1.DataSource = usersTable;
        }

        private void ListUsersByUsername(string username)
        {
            usersTable = new DataTable();
            usersTable.Columns.Add("ID", typeof(int));
            usersTable.Columns.Add("First Name", typeof(string));
            usersTable.Columns.Add("Last Name", typeof(string));
            usersTable.Columns.Add("Username", typeof(string));
            usersTable.Columns.Add("Role", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));

            UserDto user = iUser.GetUserByUsername(username);

            usersTable.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Role, user.Email);

            dataGridView1.DataSource = usersTable;
        }

        private void GetUserByIdButton_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(idField.Text);
            ListUsersById(userId);
        }

        private void GetUsersByUsernameButton_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            ListUsersByUsername(username);
        }

        private void GetUsersButton_Click(object sender, EventArgs e)
        {
            ListUsers();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChannelServices.UnregisterChannel(channel);
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            UserDto user = new UserDto();

            user.FirstName = firstNameField.Text;
            user.LastName = lastNameField.Text;
            user.Username = usernameField.Text;
            user.Password = passwordField.Text;
            user.Email = emailField.Text;

            iUser.CreateUser(user);

            MessageBox.Show("User successfully created");

            ListUsers();
        }
    }
}

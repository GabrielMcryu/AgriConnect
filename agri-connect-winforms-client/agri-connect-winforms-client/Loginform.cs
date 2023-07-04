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
    public partial class Loginform : Form
    {
        private IUser iUser;
        private TcpChannel channel;

        public Loginform()
        {
            InitializeComponent();

            Shown += Loginform_Shown;
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            iUser = (IUser)Activator.GetObject(
                typeof(IUser), "tcp://localhost:12345/User");
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            passwordField.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;

            bool isAuthenticated = iUser.AuthenticateUser(username, password);
            
            if (isAuthenticated)
            {
                MessageBox.Show("Login Success");
                ChannelServices.UnregisterChannel(channel);
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }

        }

        private void Loginform_Shown(object sender, EventArgs e)
        {
            
        }

        private void Loginform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

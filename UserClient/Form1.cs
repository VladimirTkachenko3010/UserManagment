using System;
using System.Windows.Forms;
using UserClient.ServiceReference1;

namespace UserClient
{
    public partial class Form1 : Form
    {
        private UserServiceClient client; // WCF client

        public Form1()
        {
            InitializeComponent();
            client = new UserServiceClient(); // Initializing the WCF client
            LoadUsers();

            // Connecting event handlers
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
        }

        // Loading a list of users from WCF into a DataGridView
        private void LoadUsers()
        {
            try
            {
                var users = client.GetUsers();
                dataGridViewUsers.DataSource = users;
                dataGridViewUsers.Columns["Id"].Visible = false; // Hide ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add button handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                client.AddUser(userForm.User);
                LoadUsers(); // Update the list after adding
            }
        }

        // Edit button handler
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUser = (UserDto)dataGridViewUsers.SelectedRows[0].DataBoundItem;
            var userForm = new UserForm(selectedUser);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                client.UpdateUser(userForm.User);
                LoadUsers(); // Refreshing the list after editing
            }
        }
    }
}

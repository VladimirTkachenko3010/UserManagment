using System;
using System.Windows.Forms;
using UserClient.ServiceReference1;


namespace UserClient
{
    public partial class UserForm : Form
    {
        public UserDto User { get; private set; }

        public UserForm(UserDto user = null)
        {
            InitializeComponent();
            User = user ?? new UserDto();

            if (user != null) // If we edit, fill in the fields
            {
                txtFullName.Text = user.FullName;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                txtIdentification.Text = user.IdentificationNumber;
            }

            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            User.FullName = txtFullName.Text;
            User.Email = txtEmail.Text;
            User.Phone = txtPhone.Text;
            User.IdentificationNumber = txtIdentification.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

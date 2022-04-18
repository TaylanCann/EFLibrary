using EFLibrary.Data;
using EFLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFLibrary.Forms
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
        }

        LibraryDbContext context = new LibraryDbContext();

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = txtName.Text,
                Surname = txtSurname.Text
            };

            context.Users.Add(user);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
            getUsers();
        }

        void getUsers()
        {
            var users = context.Users.ToList();
            dataGridView1.DataSource = users;
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            getUsers();
        }
    }
}

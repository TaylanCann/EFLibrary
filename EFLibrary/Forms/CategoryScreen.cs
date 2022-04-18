using EFLibrary.Data;
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
    public partial class CategoryScreen : Form
    {
        public CategoryScreen()
        {
            InitializeComponent();
        }
        LibraryDbContext context = new LibraryDbContext();

        private void CategoryScreen_Load(object sender, EventArgs e)
        {
            getCategories();
        }

        void getCategories()
        {
            var categories = context.Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category 
            {
                Name = txtCatName.Text
            };
        }
    }
}

using EFLibrary.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            LibraryDbContext libraryDbContext = new LibraryDbContext();
            libraryDbContext.Database.EnsureCreated();

            var allContext = libraryDbContext.Books.Include(b=>b.Author)
                                                     .Include(b=>b.BookCategories)
                                                     .ThenInclude(b=>b.Category);

            var data = allContext.Select(b => new 
            {
                bookName = b.Name,
                authorName = b.Author.Name,
                category = b.BookCategories.Select(c => c.BookId==b.Id).ToList()
            });

            var list = data.ToList();
            dataGridView1.DataSource = list;

        }
    }
}

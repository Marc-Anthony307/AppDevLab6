using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBooks
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookDataSet);

        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.bookDataSet.Book);

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Search
{
    public partial class ProductSearchForm : Form
    {
        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.SearchDesc(
                this.productDataSet.Product, searchTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }
    }
}

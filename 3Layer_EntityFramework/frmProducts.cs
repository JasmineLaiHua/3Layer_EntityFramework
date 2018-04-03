using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace _3Layer_EntityFramework
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        ProductsBUS proBUS = new ProductsBUS();
        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<SanPham> list = proBUS.GetProduct();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = list;
        }

        //click on product
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string prodImg = @"..\.." + dgvProducts.Rows[row].Cells[5].Value.ToString();
            txtId.Text = dgvProducts.Rows[row].Cells[0].Value.ToString();
            txtProName.Text = dgvProducts.Rows[row].Cells[1].Value.ToString();
            txtUnit.Text = dgvProducts.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[row].Cells[3].Value.ToString();
            txtType.Text = dgvProducts.Rows[row].Cells[4].Value.ToString();
            picProduct.ImageLocation = prodImg;
        }

        //Remove button
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}

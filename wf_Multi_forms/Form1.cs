using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Multi_forms
{
    public partial class Form1 : Form
    {
        public List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            Update();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductInfo productInfo = new ProductInfo(product, false);
            if (productInfo.ShowDialog() == DialogResult.OK)
            {
                products.Add(product);
                Update();
            }
        }
        public void Update()
        {
            productsList.DataSource = null;
            productsList.DataSource = products;
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedIndex==-1)
            {
                return;
            }
            products.Remove((Product)productsList.SelectedItem);
            Update();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Product product = this.productsList.SelectedItem as Product;
            ProductInfo productInfo = new ProductInfo(product,false);
            if (productInfo.ShowDialog() == DialogResult.OK)
            {
                Update();
            }

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Product product = this.productsList.SelectedItem as Product;
            ProductInfo productInfo = new ProductInfo(product, true);
            productInfo.ShowDialog();
        }
    }
}

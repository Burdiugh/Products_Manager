using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace wf_Multi_forms
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        BinaryFormatter objBinaryFormatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "All files(*.*)|*.*";
            saveFileDialog1.Filter = "All files(*.*)|*.*";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductInfo productInfo = new ProductInfo(product, true);
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
            ProductInfo productInfo = new ProductInfo(product,true);
            if (productInfo.ShowDialog() == DialogResult.OK)
            {
                Update();
            }

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Product product = this.productsList.SelectedItem as Product;
            ProductInfo productInfo = new ProductInfo(product, false);
            productInfo.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            using (Stream obj = new FileStream(filename, FileMode.OpenOrCreate))
            {
                objBinaryFormatter.Serialize(obj, products);
            }
            MessageBox.Show("File saved", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                products = (List<Product>)objBinaryFormatter.Deserialize(fs);
            }
            Update();
            MessageBox.Show("File is open","Info!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

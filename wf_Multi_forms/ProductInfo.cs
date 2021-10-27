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
    public partial class ProductInfo : Form
    {
        Product product;
        public ProductInfo()
        {
            InitializeComponent();
        }
        public ProductInfo(Product pr,bool IsRead)
        {
            InitializeComponent();
            product = pr;
            this.nameBox.Text= product.Name;
            this.priceNumeric.Value= product.Price;
            this.countryBox.Text = product.Country;
            this.valueNumeric.Value = product.Value;
            this.discountNUmeric.Value = product.Value;
           
            if (IsRead)
            {
                this.nameBox.ReadOnly=true;
                this.priceNumeric.ReadOnly = true;
                this.countryBox.Enabled = false;
                this.valueNumeric.ReadOnly = true;
                this.discountNUmeric.ReadOnly = true;
            }
        }

        
        private void doneBtn_Click(object sender, EventArgs e)
        {
            product.Name = nameBox.Text;
            product.Price = priceNumeric.Value;
            product.Country = countryBox.Text;
            product.Value = valueNumeric.Value;
            product.Discount = discountNUmeric.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
       
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

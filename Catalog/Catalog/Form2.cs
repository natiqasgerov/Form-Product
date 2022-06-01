using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            
            if (Form1.Temp == false)
            {
                
                foreach (var item in Form1.products)
                {
                    if(item == Form1.Find)
                    {
                        item.Name = textBoxName.Text;
                        item.Country = textBoxCountry.Text;
                        item.Cost = textBoxCost.Text;
                    }
                }          
            }
            else
            {
                Product product = new();
                product.Name = textBoxName.Text;
                product.Country = textBoxCountry.Text;
                product.Cost = textBoxCost.Text;
                Form1.products.Add(product);   
                
            }
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(textBoxName.Text);
            if (match.Success)
            {
                textBoxName.ForeColor = Color.Red;
                MessageBox.Show("You don't write number");
            }  
            else
                textBoxName.ForeColor = Color.Black;
        }

        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(textBoxCountry.Text);
            if (match.Success)
            {
                textBoxCountry.ForeColor = Color.Red;
                MessageBox.Show("You don't write number");
            }
            else
                textBoxCountry.ForeColor = Color.Black;
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(textBoxCost.Text);
            if (!match.Success)
            {
                textBoxCost.ForeColor = Color.Red;
                MessageBox.Show("You don't write character");               
            }
            else
                textBoxCost.ForeColor = Color.Black;            
        }
    }
}

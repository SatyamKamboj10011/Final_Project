using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loading
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        int itemsOrdered;
        const int numberOfProducts = 10;
        Product[] products = new Product[numberOfProducts];

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            products[0] = new Product("Woolen HandBags", 15);
            products[1] = new Product("Jewellery", 15);
            products[2] = new Product("Jewellery", 15);
            products[3] = new Product("Decorative Items", 15);
            products[4] = new Product("Bags", 15);

            for (int i = 0; i < 5; i++)
            {
                dudProducts.Items.Add(products[i].Description);
            }
            dudProducts.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderAddress.Text = "";
            itemsOrdered = 0;
            lblltemsOrdered.Text = "Items Ordered: 0";

            for (int i = 0; i < numberOfProducts; i++)
            {
                if (products[i] != null)
                {
                    products[i].NumberOrdered = 0;
                }
            }
            dudProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            lblTotalCost.Text = "Total Cost";
            txtMailingLabel.Text = "";
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            products[dudProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            lblltemsOrdered.Text = "Items Ordered: " + itemsOrdered.ToString();
        }

        private void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabOrderForm.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {
                        MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabOrderForm.SelectedIndex = 0;
                    }
                    else
                    {
                        Double totalCost = 0;
                        lstProducts.Items.Clear();
                        for (int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i] != null && products[i].NumberOrdered != 0)
                            {
                                lstProducts.Items.Add(products[i].NumberOrdered.ToString() + "" + products[i].Description);
                                totalCost += products[i].Cost * products[i].NumberOrdered;
                            }
                        }
                        lblTotalCost.Text = "Total Cost: $" + string.Format("{0:f2}", totalCost);
                    }
                    break;
                    case 2:
                    if (txtOrderAddress.Text == "")
                    {
                       MessageBox.Show("No address was entered", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabOrderForm.SelectedIndex = 0;
                        txtOrderAddress.Focus();
                    }
                    else
                    {
                        string address = txtOrderAddress.Text;
                        txtMailingLabel.Text = address;
                    }
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment1 paymentForm = new Payment1();
            paymentForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Pharmacy_Application : Form
    {
        public Pharmacy_Application()
        {
            InitializeComponent();
        }
        List<CartItems> obj = new List<CartItems>();
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Pharmacy_Application_Load(object sender, EventArgs e)
        {
        }
        private void CartItems_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                CartItems cart = new CartItems()
                {
                    Items = comboBox.Text.ToString(),
                    Quantity = Convert.ToInt32(QuantityTextBox.Text.ToString()),
                    Price = Convert.ToDecimal(PriceTextBox.Text.ToString()),
                    TotalAmount = (Convert.ToInt32(QuantityTextBox.Text.ToString()) + Convert.ToDecimal(PriceTextBox.Text.ToString()))
                };
                decimal totalAmount = obj.Sum(x => x.Price);
                textBox3.Text = totalAmount.ToString();

                decimal sales = (16 * totalAmount) / 100;
                textBox4.Text = sales.ToString();

                decimal totalPay = totalAmount + sales;
                textBox5.Text = totalPay.ToString();
                obj.Add(cart);
                PharmacyGridView.DataSource = obj;
                PharmacyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                PharmacyGridView.MultiSelect = false;
            }
        }
        private bool isValid()
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a cart item:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            if (PriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Price is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTextBox.Focus();
                return false;
            }
            else
            {
                decimal price;
                bool Price = decimal.TryParse(PriceTextBox.Text.Trim(), out price);
                if (!Price)
                {
                    MessageBox.Show("Price should be an numeric term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PriceTextBox.Focus();
                    return false;
                }
            }
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Focus();
                return false;
            }
            else
            {
                decimal qty;
                bool quantity = decimal.TryParse(PriceTextBox.Text.Trim(), out qty);

                if (!quantity)
                {
                    MessageBox.Show("Quantity should be an numeric term!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Focus();
                    return false;
                }
            }
            return true;
        }
        private void groupBox_Enter(object sender, EventArgs e)
        {
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = true;
            comboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            PriceTextBox.Clear();
            CartItems.Enabled = true;
            PrintOrder.Enabled = true;
            PrintPreview.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = false;
            CartItems.Enabled = false;
            PrintOrder.Enabled = false;
            PrintPreview.Enabled = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class CartItems
    {
        public string Items;
        public int Quantity;
        public decimal Price;
        public decimal TotalAmount;
    }
}
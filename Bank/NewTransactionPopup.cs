using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class NewTransactionPopup : Form
    {
        public NewTransactionPopup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewTransactionPopup_Load(object sender, EventArgs e)
        {
            
            Dropdown_From_Account.Items.Clear();
            foreach (string items in User.Current_Bank_Account_Name)
            {
                Dropdown_From_Account.Items.Add(items);
            }
            foreach (string items in User.Global_Bank_Account_Id)
            {
                Dropdown_To_Account.Items.Add(items);
            }
        }
    }
}

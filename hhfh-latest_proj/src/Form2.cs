using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HiT_Hi_FiT_Hai
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string serverAddress = addressText.Text.Trim();
            Form3 LatestEntries = new Form3();
            LatestEntries.serverAddress = serverAddress;            
            System.Int32.TryParse(SetLimitTextBox.Text, out LatestEntries.limit);
            this.Hide();
            LatestEntries.ShowDialog();
            this.Close();
        }
    }
}

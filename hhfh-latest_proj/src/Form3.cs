using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace HiT_Hi_FiT_Hai
{
    public partial class Form3 : Form
    {
        public String serverAddress;
        public int limit;
        //public static DataTable dtEntry;
        private static string[] rowSelected;
        public static string jsonStr;
        public Form3()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

            extraComponents();            
            
            string []drRows;            
            

            try
            {
                var jsonArr = JArray.Parse(@jsonStr);
                drRows = new string[5];
                foreach (JObject token in jsonArr)
                { 
                    drRows[0]=token["id"].ToString();
                    drRows[1]=token["ctg"].ToString();
                    drRows[2]=token["msg"].ToString();
                    drRows[3]=token["nick"].ToString();
                    drRows[4] = token["date"].ToString();
                    drRows[2] = Regex.Replace(drRows[2], "\\[[^\\]]+\\]", "").Trim();
                    Entries.Rows.Add(drRows);
                }
                
                
            }
            catch (Exception sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void RadioButton_CheckedChanged(object sender)
        {
            RadioButton radio = (RadioButton)sender;
            string[] drRows=new String[5];
            Entries.Rows.Clear();
            var jsonArr = JArray.Parse(@jsonStr);
            foreach (JObject token in jsonArr)
            {
                if ((token["ctg"].ToString().Equals(radio.Text))||(radio.Text=="all"))
                {
                    drRows[0] = token["id"].ToString();
                    drRows[1] = token["ctg"].ToString();
                    drRows[2] = token["msg"].ToString();
                    drRows[3] = token["nick"].ToString();
                    drRows[4] = token["date"].ToString();
                    drRows[2] = Regex.Replace(drRows[2], "\\[[^\\]]+\\]", "").Trim();
                    Entries.Rows.Add(drRows);
                }

            }
            
        }

        private void RadioButton0_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton_CheckedChanged(sender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void MoreInfo_Click(object sender, EventArgs e)
        {
            rowSelected = new string[5];
            Entries.SelectedRows.CopyTo(rowSelected,0);
        }
        
    }
}

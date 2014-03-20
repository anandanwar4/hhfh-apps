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
//using MySql.Data.MySqlClient;

namespace HiT_Hi_FiT_Hai
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Server = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Category = new System.Windows.Forms.TabPage();
            this.Entries = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Server.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Entries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Server);
            this.tabControl1.Controls.Add(this.Category);
            this.tabControl1.Location = new System.Drawing.Point(28, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(153, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.Controls.Add(this.radioButton1);
            this.Server.Location = new System.Drawing.Point(4, 22);
            this.Server.Name = "Server";
            this.Server.Padding = new System.Windows.Forms.Padding(3);
            this.Server.Size = new System.Drawing.Size(145, 599);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(4, 22);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(3);
            this.Category.Size = new System.Drawing.Size(145, 599);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = true;
            // 
            // Entries
            // 
            this.Entries.AllowUserToAddRows = false;
            this.Entries.AllowUserToDeleteRows = false;
            this.Entries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.ctg,
            this.msg,
            this.nick,
            this.date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Entries.DefaultCellStyle = dataGridViewCellStyle2;
            this.Entries.Location = new System.Drawing.Point(187, 13);
            this.Entries.MultiSelect = false;
            this.Entries.Name = "Entries";
            this.Entries.ReadOnly = true;
            this.Entries.RowHeadersVisible = false;
            this.Entries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Entries.Size = new System.Drawing.Size(1024, 625);
            this.Entries.TabIndex = 1;
            this.Entries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EID
            // 
            this.EID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EID.Frozen = true;
            this.EID.HeaderText = "ID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            this.EID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EID.Width = 60;
            // 
            // ctg
            // 
            this.ctg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ctg.Frozen = true;
            this.ctg.HeaderText = "Category";
            this.ctg.Name = "ctg";
            this.ctg.ReadOnly = true;
            this.ctg.Width = 75;
            // 
            // msg
            // 
            this.msg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msg.HeaderText = "Name";
            this.msg.Name = "msg";
            this.msg.ReadOnly = true;
            // 
            // nick
            // 
            this.nick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nick.HeaderText = "Added By";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Width = 128;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 140;
            // 
            // MoreInfo
            // 
            this.MoreInfo.Location = new System.Drawing.Point(1136, 646);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.Size = new System.Drawing.Size(75, 23);
            this.MoreInfo.TabIndex = 2;
            this.MoreInfo.Text = "More Info";
            this.MoreInfo.UseVisualStyleBackColor = true;
            this.MoreInfo.Click += new System.EventHandler(this.MoreInfo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.Entries);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.Server.ResumeLayout(false);
            this.Server.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Entries)).EndInit();
            this.ResumeLayout(false);

        }

        private void extraComponents()
        {
            
            int counter = 0, flag=0;
            
            string[] radioStr;
            
            this.Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Entries)).BeginInit();
            string urlrequest = "http://10.109.1.9/cms/api/latest.php?lim=" + limit.ToString();
            HttpWebRequest request = WebRequest.Create(urlrequest) as HttpWebRequest;
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
            radioStr = new string[limit];
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    jsonStr = (new StreamReader(response.GetResponseStream())).ReadToEnd();
                    var jsonarr = JArray.Parse(@jsonStr);
                    foreach (JObject token in jsonarr)
                    {
                        
                        //MessageBox.Show("reached");
                        for (int i = 0; i < counter; i++)
                        {
                                //MessageBox.Show("reached");
                                if (radioStr[i] == token["ctg"].ToString())
                                {
                                    flag = 1;
                                    break;
                                }                           
                     
                        }
                        if (flag == 1)
                        {
                            flag = 0;
                            continue;
                        }                  
                        
                        radioStr[counter] = token["ctg"].ToString();
                        counter++;
                        flag = 0;
                        
                    }
                    //MessageBox.Show("reached");
                    counter--;
                    int j = 0;
                    RadioButtonArr = new System.Windows.Forms.RadioButton[counter + 2];
                    RadioButtonArr[j] = new RadioButton();
                    RadioButtonArr[j].AutoSize = true;
                    RadioButtonArr[j].Name = "RadioButtonArr" + j.ToString();
                    RadioButtonArr[j].Text = "all";
                    RadioButtonArr[j].Location = new System.Drawing.Point(6, (6 + (j * 23)));
                    RadioButtonArr[j].Size = new System.Drawing.Size(((RadioButtonArr[j].Text.Length) * 14), 17);
                    RadioButtonArr[j].CheckedChanged += new System.EventHandler(this.RadioButton0_CheckedChanged);
                    this.Category.Controls.Add(this.RadioButtonArr[j]);

                    for (j = 1; j <= (counter+1); j++)
                    {
                        //MessageBox.Show("reached");
                        RadioButtonArr[j] = new RadioButton();
                        RadioButtonArr[j].AutoSize = true;
                        RadioButtonArr[j].Name = "RadioButtonArr" + j.ToString();
                        RadioButtonArr[j].Text = radioStr[j-1].ToString();
                        RadioButtonArr[j].Location = new System.Drawing.Point(6, (6 + (j * 23)));
                        RadioButtonArr[j].Size = new System.Drawing.Size(((radioStr[j-1].Length) * 14), 17);
                        RadioButtonArr[j].CheckedChanged += new System.EventHandler(this.RadioButton0_CheckedChanged);
                        this.Category.Controls.Add(this.RadioButtonArr[j]);
                    }
                }
                this.Category.ResumeLayout();
                this.Category.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.Entries)).EndInit();
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Server;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.DataGridView Entries;
        private System.Windows.Forms.Button MoreInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctg;
        private System.Windows.Forms.DataGridViewTextBoxColumn msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.RadioButton[] RadioButtonArr;
        private RadioButton radioButton1;
        //public static System.Windows.Forms.DataGridView EntriesPub;
        /*void funcInit()
        {
            EntriesPub = Entries;
        }*/
    }
}
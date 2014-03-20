namespace HiT_Hi_FiT_Hai
{
    partial class Form2
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
            this.srvrVars = new System.Windows.Forms.GroupBox();
            this.connect = new System.Windows.Forms.Button();
            this.addressText = new System.Windows.Forms.TextBox();
            this.prefix = new System.Windows.Forms.Label();
            this.SetLimitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srvrVars.SuspendLayout();
            this.SuspendLayout();
            // 
            // srvrVars
            // 
            this.srvrVars.Controls.Add(this.label2);
            this.srvrVars.Controls.Add(this.SetLimitTextBox);
            this.srvrVars.Controls.Add(this.connect);
            this.srvrVars.Controls.Add(this.addressText);
            this.srvrVars.Controls.Add(this.prefix);
            this.srvrVars.Location = new System.Drawing.Point(10, 21);
            this.srvrVars.Margin = new System.Windows.Forms.Padding(1);
            this.srvrVars.Name = "srvrVars";
            this.srvrVars.Size = new System.Drawing.Size(750, 80);
            this.srvrVars.TabIndex = 3;
            this.srvrVars.TabStop = false;
            this.srvrVars.Text = "Server Variables";
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.connect.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.connect.FlatAppearance.BorderSize = 3;
            this.connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.connect.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connect.Location = new System.Drawing.Point(575, 12);
            this.connect.Margin = new System.Windows.Forms.Padding(0);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(150, 30);
            this.connect.TabIndex = 2;
            this.connect.Text = "Fetch";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(250, 16);
            this.addressText.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.addressText.MinimumSize = new System.Drawing.Size(4, 25);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(262, 23);
            this.addressText.TabIndex = 1;
            this.addressText.Text = "10.109.1.9";
            // 
            // prefix
            // 
            this.prefix.AutoSize = true;
            this.prefix.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.prefix.Location = new System.Drawing.Point(60, 20);
            this.prefix.Margin = new System.Windows.Forms.Padding(2);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(174, 16);
            this.prefix.TabIndex = 1;
            this.prefix.Text = "Server Address (Just the IP):";
            // 
            // SetLimitTextBox
            // 
            this.SetLimitTextBox.Location = new System.Drawing.Point(250, 43);
            this.SetLimitTextBox.Name = "SetLimitTextBox";
            this.SetLimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.SetLimitTextBox.TabIndex = 4;
            this.SetLimitTextBox.Text = "220";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set Maximum Limit";
            // 
            // Form2
            // 
            this.AcceptButton = this.connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 111);
            this.Controls.Add(this.srvrVars);
            this.Name = "Form2";
            this.Text = "Form2";
            this.srvrVars.ResumeLayout(false);
            this.srvrVars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox srvrVars;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label prefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetLimitTextBox;
    }
}

namespace RESTAURANT
{
    partial class AddNewCustomer
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
            this.custphone_label = new System.Windows.Forms.TextBox();
            this.custname_label = new System.Windows.Forms.TextBox();
            this.custcity_label = new System.Windows.Forms.TextBox();
            this.custstreet_label = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.custname_textbox = new System.Windows.Forms.TextBox();
            this.custadd_textbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addcust_btn = new System.Windows.Forms.Button();
            this.wel_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custphone_label
            // 
            this.custphone_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.custphone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custphone_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.custphone_label.Location = new System.Drawing.Point(25, 98);
            this.custphone_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custphone_label.Name = "custphone_label";
            this.custphone_label.Size = new System.Drawing.Size(384, 30);
            this.custphone_label.TabIndex = 12;
            this.custphone_label.Text = "ENTER CUSTOMER PHONE NUMBER";
            this.custphone_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custname_label
            // 
            this.custname_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.custname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custname_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.custname_label.Location = new System.Drawing.Point(25, 178);
            this.custname_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custname_label.Name = "custname_label";
            this.custname_label.Size = new System.Drawing.Size(384, 30);
            this.custname_label.TabIndex = 13;
            this.custname_label.Text = "ENTER CUSTOMER NAME\r\n";
            this.custname_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custcity_label
            // 
            this.custcity_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.custcity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custcity_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.custcity_label.Location = new System.Drawing.Point(25, 259);
            this.custcity_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custcity_label.Name = "custcity_label";
            this.custcity_label.Size = new System.Drawing.Size(384, 30);
            this.custcity_label.TabIndex = 14;
            this.custcity_label.Text = "CHOOSE CITY\r\n";
            this.custcity_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custstreet_label
            // 
            this.custstreet_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.custstreet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custstreet_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.custstreet_label.Location = new System.Drawing.Point(25, 336);
            this.custstreet_label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custstreet_label.Name = "custstreet_label";
            this.custstreet_label.Size = new System.Drawing.Size(384, 30);
            this.custstreet_label.TabIndex = 15;
            this.custstreet_label.Text = "ENTER CUSTOMER ADDRESS\r\n";
            this.custstreet_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phone_textbox
            // 
            this.phone_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.phone_textbox.Location = new System.Drawing.Point(431, 102);
            this.phone_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(337, 26);
            this.phone_textbox.TabIndex = 16;
            this.phone_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textbox_KeyPress);
            // 
            // custname_textbox
            // 
            this.custname_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.custname_textbox.Location = new System.Drawing.Point(431, 178);
            this.custname_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custname_textbox.Name = "custname_textbox";
            this.custname_textbox.Size = new System.Drawing.Size(337, 26);
            this.custname_textbox.TabIndex = 17;
            this.custname_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custname_textbox_KeyPress);
            // 
            // custadd_textbox
            // 
            this.custadd_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.custadd_textbox.Location = new System.Drawing.Point(431, 340);
            this.custadd_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custadd_textbox.Name = "custadd_textbox";
            this.custadd_textbox.Size = new System.Drawing.Size(346, 26);
            this.custadd_textbox.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cairo",
            "Alex",
            "Giza"});
            this.comboBox1.Location = new System.Drawing.Point(431, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // addcust_btn
            // 
            this.addcust_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.addcust_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcust_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addcust_btn.Location = new System.Drawing.Point(283, 391);
            this.addcust_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addcust_btn.Name = "addcust_btn";
            this.addcust_btn.Size = new System.Drawing.Size(230, 45);
            this.addcust_btn.TabIndex = 20;
            this.addcust_btn.Text = "ADD CUSTOMER";
            this.addcust_btn.UseVisualStyleBackColor = false;
            this.addcust_btn.Click += new System.EventHandler(this.addcust_btn_Click);
            // 
            // wel_label
            // 
            this.wel_label.AutoSize = true;
            this.wel_label.BackColor = System.Drawing.Color.Maroon;
            this.wel_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wel_label.ForeColor = System.Drawing.Color.MistyRose;
            this.wel_label.Location = new System.Drawing.Point(166, 35);
            this.wel_label.Name = "wel_label";
            this.wel_label.Size = new System.Drawing.Size(478, 32);
            this.wel_label.TabIndex = 21;
            this.wel_label.Text = "PLEASE ENTER CUSTOMER INFO";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(13, 382);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 54);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.wel_label);
            this.Controls.Add(this.addcust_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.custadd_textbox);
            this.Controls.Add(this.custname_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.custstreet_label);
            this.Controls.Add(this.custcity_label);
            this.Controls.Add(this.custname_label);
            this.Controls.Add(this.custphone_label);
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox custphone_label;
        private System.Windows.Forms.TextBox custname_label;
        private System.Windows.Forms.TextBox custcity_label;
        private System.Windows.Forms.TextBox custstreet_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox custname_textbox;
        private System.Windows.Forms.TextBox custadd_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addcust_btn;
        private System.Windows.Forms.Label wel_label;
        private System.Windows.Forms.Button back_btn;
    }
}
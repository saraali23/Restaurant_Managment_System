
namespace RESTAURANT
{
    partial class Customer_Info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewcustomer_btn = new System.Windows.Forms.Button();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addnewcust_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(222, 205);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(650, 169);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // viewcustomer_btn
            // 
            this.viewcustomer_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.viewcustomer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewcustomer_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewcustomer_btn.Location = new System.Drawing.Point(414, 86);
            this.viewcustomer_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewcustomer_btn.Name = "viewcustomer_btn";
            this.viewcustomer_btn.Size = new System.Drawing.Size(230, 45);
            this.viewcustomer_btn.TabIndex = 13;
            this.viewcustomer_btn.Text = "VIEW CUSTOMER";
            this.viewcustomer_btn.UseVisualStyleBackColor = false;
            this.viewcustomer_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // phone_textbox
            // 
            this.phone_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.phone_textbox.Location = new System.Drawing.Point(549, 32);
            this.phone_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(337, 26);
            this.phone_textbox.TabIndex = 12;
            this.phone_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textbox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(118, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 30);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "ENTER CUSROMER PHONE NUMBER";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addnewcust_btn
            // 
            this.addnewcust_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.addnewcust_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewcust_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addnewcust_btn.Location = new System.Drawing.Point(364, 384);
            this.addnewcust_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addnewcust_btn.Name = "addnewcust_btn";
            this.addnewcust_btn.Size = new System.Drawing.Size(323, 61);
            this.addnewcust_btn.TabIndex = 16;
            this.addnewcust_btn.Text = "ADD NEW CUSTOMER";
            this.addnewcust_btn.UseVisualStyleBackColor = false;
            this.addnewcust_btn.Click += new System.EventHandler(this.addnewcust_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(13, 462);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 54);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Customer_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(912, 582);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.addnewcust_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewcustomer_btn);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.textBox1);
            this.Name = "Customer_Info";
            this.Text = "EDIT_Customer_Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewcustomer_btn;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addnewcust_btn;
        private System.Windows.Forms.Button back_btn;
    }
}

namespace RESTAURANT
{
    partial class ViewOrderBy
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
            this.searchbydate_btn = new System.Windows.Forms.Button();
            this.searchbyphone_btn = new System.Windows.Forms.Button();
            this.searchbyord_btn = new System.Windows.Forms.Button();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ordertype_combo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbydate_btn
            // 
            this.searchbydate_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.searchbydate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbydate_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbydate_btn.Location = new System.Drawing.Point(41, 37);
            this.searchbydate_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbydate_btn.Name = "searchbydate_btn";
            this.searchbydate_btn.Size = new System.Drawing.Size(235, 67);
            this.searchbydate_btn.TabIndex = 18;
            this.searchbydate_btn.Text = "SEARCH BY DATE";
            this.searchbydate_btn.UseVisualStyleBackColor = false;
            this.searchbydate_btn.Click += new System.EventHandler(this.searchbydate_btn_Click);
            // 
            // searchbyphone_btn
            // 
            this.searchbyphone_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.searchbyphone_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyphone_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbyphone_btn.Location = new System.Drawing.Point(284, 37);
            this.searchbyphone_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbyphone_btn.Name = "searchbyphone_btn";
            this.searchbyphone_btn.Size = new System.Drawing.Size(216, 67);
            this.searchbyphone_btn.TabIndex = 19;
            this.searchbyphone_btn.Text = "SEARCH BY CUSTOMER PHONE";
            this.searchbyphone_btn.UseVisualStyleBackColor = false;
            this.searchbyphone_btn.Click += new System.EventHandler(this.searchbyphone_btn_Click);
            // 
            // searchbyord_btn
            // 
            this.searchbyord_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.searchbyord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyord_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbyord_btn.Location = new System.Drawing.Point(508, 37);
            this.searchbyord_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbyord_btn.Name = "searchbyord_btn";
            this.searchbyord_btn.Size = new System.Drawing.Size(235, 67);
            this.searchbyord_btn.TabIndex = 20;
            this.searchbyord_btn.Text = "SEARCH BY ORDER TYPE";
            this.searchbyord_btn.UseVisualStyleBackColor = false;
            this.searchbyord_btn.Click += new System.EventHandler(this.searchbyord_btn_Click);
            // 
            // phone_textbox
            // 
            this.phone_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.phone_textbox.Location = new System.Drawing.Point(284, 114);
            this.phone_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(216, 26);
            this.phone_textbox.TabIndex = 21;
            this.phone_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textbox_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // Ordertype_combo
            // 
            this.Ordertype_combo.FormattingEnabled = true;
            this.Ordertype_combo.Items.AddRange(new object[] {
            "Normal",
            "Delivery",
            "Online"});
            this.Ordertype_combo.Location = new System.Drawing.Point(508, 112);
            this.Ordertype_combo.Name = "Ordertype_combo";
            this.Ordertype_combo.Size = new System.Drawing.Size(236, 28);
            this.Ordertype_combo.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(57, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Location = new System.Drawing.Point(311, 174);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(143, 38);
            this.search_btn.TabIndex = 25;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
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
            this.back_btn.TabIndex = 26;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ViewOrderBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ordertype_combo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.searchbyord_btn);
            this.Controls.Add(this.searchbyphone_btn);
            this.Controls.Add(this.searchbydate_btn);
            this.Name = "ViewOrderBy";
            this.Text = "ViewOrderBy";
            this.Load += new System.EventHandler(this.ViewOrderBy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbydate_btn;
        private System.Windows.Forms.Button searchbyphone_btn;
        private System.Windows.Forms.Button searchbyord_btn;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Ordertype_combo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
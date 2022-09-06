
namespace RESTAURANT
{
    partial class Admin
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
            this.txt_admin_name = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.meal_type = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.meal_name_label = new System.Windows.Forms.Label();
            this.meal_price = new System.Windows.Forms.TextBox();
            this.meal_name_cmb = new System.Windows.Forms.ComboBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.show_price = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_admin_id = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_admin_name
            // 
            this.txt_admin_name.Location = new System.Drawing.Point(161, 78);
            this.txt_admin_name.Name = "txt_admin_name";
            this.txt_admin_name.Size = new System.Drawing.Size(100, 20);
            this.txt_admin_name.TabIndex = 27;
            this.txt_admin_name.TextChanged += new System.EventHandler(this.txt_admin_name_TextChanged);
            // 
            // type_txt
            // 
            this.type_txt.Location = new System.Drawing.Point(358, 245);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(121, 20);
            this.type_txt.TabIndex = 26;
            this.type_txt.TextChanged += new System.EventHandler(this.type_txt_TextChanged);
            // 
            // meal_type
            // 
            this.meal_type.AutoSize = true;
            this.meal_type.BackColor = System.Drawing.Color.PapayaWhip;
            this.meal_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_type.ForeColor = System.Drawing.Color.SaddleBrown;
            this.meal_type.Location = new System.Drawing.Point(232, 245);
            this.meal_type.Name = "meal_type";
            this.meal_type.Size = new System.Drawing.Size(96, 25);
            this.meal_type.TabIndex = 25;
            this.meal_type.Text = "meal type";
            this.meal_type.Click += new System.EventHandler(this.meal_type_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.price_label.Location = new System.Drawing.Point(232, 202);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(101, 25);
            this.price_label.TabIndex = 24;
            this.price_label.Text = "meal price";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // meal_name_label
            // 
            this.meal_name_label.AutoSize = true;
            this.meal_name_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.meal_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_name_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.meal_name_label.Location = new System.Drawing.Point(232, 157);
            this.meal_name_label.Name = "meal_name_label";
            this.meal_name_label.Size = new System.Drawing.Size(108, 25);
            this.meal_name_label.TabIndex = 23;
            this.meal_name_label.Text = "meal name";
            this.meal_name_label.Click += new System.EventHandler(this.meal_name_label_Click);
            // 
            // meal_price
            // 
            this.meal_price.Location = new System.Drawing.Point(358, 202);
            this.meal_price.Name = "meal_price";
            this.meal_price.Size = new System.Drawing.Size(121, 20);
            this.meal_price.TabIndex = 22;
            this.meal_price.TextChanged += new System.EventHandler(this.meal_price_TextChanged);
            // 
            // meal_name_cmb
            // 
            this.meal_name_cmb.FormattingEnabled = true;
            this.meal_name_cmb.Location = new System.Drawing.Point(358, 157);
            this.meal_name_cmb.Name = "meal_name_cmb";
            this.meal_name_cmb.Size = new System.Drawing.Size(121, 21);
            this.meal_name_cmb.TabIndex = 21;
            this.meal_name_cmb.SelectedIndexChanged += new System.EventHandler(this.meal_name_cmb_SelectedIndexChanged);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insert_btn.Location = new System.Drawing.Point(237, 286);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(78, 50);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "Insert Meal";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // show_price
            // 
            this.show_price.BackColor = System.Drawing.Color.SaddleBrown;
            this.show_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_price.Location = new System.Drawing.Point(380, 286);
            this.show_price.Name = "show_price";
            this.show_price.Size = new System.Drawing.Size(99, 50);
            this.show_price.TabIndex = 19;
            this.show_price.Text = "Show Meal Price";
            this.show_price.UseVisualStyleBackColor = false;
            this.show_price.Click += new System.EventHandler(this.show_price_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Admin_name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Admin_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_admin_id
            // 
            this.txt_admin_id.Location = new System.Drawing.Point(161, 31);
            this.txt_admin_id.Name = "txt_admin_id";
            this.txt_admin_id.Size = new System.Drawing.Size(100, 20);
            this.txt_admin_id.TabIndex = 16;
            this.txt_admin_id.TextChanged += new System.EventHandler(this.txt_admin_id_TextChanged);
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_btn.Location = new System.Drawing.Point(288, 31);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 67);
            this.check_btn.TabIndex = 15;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.istockphoto_1045891638_612x612;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_admin_name);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.meal_type);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.meal_name_label);
            this.Controls.Add(this.meal_price);
            this.Controls.Add(this.meal_name_cmb);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.show_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_admin_id);
            this.Controls.Add(this.check_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_admin_name;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.Label meal_type;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label meal_name_label;
        private System.Windows.Forms.TextBox meal_price;
        private System.Windows.Forms.ComboBox meal_name_cmb;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button show_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_admin_id;
        private System.Windows.Forms.Button check_btn;
    }
}
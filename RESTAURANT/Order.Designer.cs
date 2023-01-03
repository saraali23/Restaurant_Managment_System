
namespace RESTAURANT
{
    partial class Order
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
            this.MealTypesBox = new System.Windows.Forms.GroupBox();
            this.all_btn = new System.Windows.Forms.RadioButton();
            this.drinks_btn = new System.Windows.Forms.RadioButton();
            this.lunch_btn = new System.Windows.Forms.RadioButton();
            this.dinner_btn = new System.Windows.Forms.RadioButton();
            this.break_btn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show_menu_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.MealTypesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MealTypesBox
            // 
            this.MealTypesBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.MealTypesBox.Controls.Add(this.all_btn);
            this.MealTypesBox.Controls.Add(this.drinks_btn);
            this.MealTypesBox.Controls.Add(this.lunch_btn);
            this.MealTypesBox.Controls.Add(this.dinner_btn);
            this.MealTypesBox.Controls.Add(this.break_btn);
            this.MealTypesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealTypesBox.Location = new System.Drawing.Point(401, 111);
            this.MealTypesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MealTypesBox.Name = "MealTypesBox";
            this.MealTypesBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MealTypesBox.Size = new System.Drawing.Size(664, 122);
            this.MealTypesBox.TabIndex = 2;
            this.MealTypesBox.TabStop = false;
            this.MealTypesBox.Text = "MEALS TYPE";
            // 
            // all_btn
            // 
            this.all_btn.AutoSize = true;
            this.all_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.all_btn.Location = new System.Drawing.Point(544, 65);
            this.all_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(59, 29);
            this.all_btn.TabIndex = 4;
            this.all_btn.TabStop = true;
            this.all_btn.Text = "All";
            this.all_btn.UseVisualStyleBackColor = true;
            // 
            // drinks_btn
            // 
            this.drinks_btn.AutoSize = true;
            this.drinks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinks_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.drinks_btn.Location = new System.Drawing.Point(402, 65);
            this.drinks_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinks_btn.Name = "drinks_btn";
            this.drinks_btn.Size = new System.Drawing.Size(92, 29);
            this.drinks_btn.TabIndex = 3;
            this.drinks_btn.TabStop = true;
            this.drinks_btn.Text = "Drinks";
            this.drinks_btn.UseVisualStyleBackColor = true;
            // 
            // lunch_btn
            // 
            this.lunch_btn.AutoSize = true;
            this.lunch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunch_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lunch_btn.Location = new System.Drawing.Point(153, 65);
            this.lunch_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lunch_btn.Name = "lunch_btn";
            this.lunch_btn.Size = new System.Drawing.Size(91, 29);
            this.lunch_btn.TabIndex = 2;
            this.lunch_btn.TabStop = true;
            this.lunch_btn.Text = "Lunch";
            this.lunch_btn.UseVisualStyleBackColor = true;
            // 
            // dinner_btn
            // 
            this.dinner_btn.AutoSize = true;
            this.dinner_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinner_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dinner_btn.Location = new System.Drawing.Point(272, 65);
            this.dinner_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dinner_btn.Name = "dinner_btn";
            this.dinner_btn.Size = new System.Drawing.Size(94, 29);
            this.dinner_btn.TabIndex = 1;
            this.dinner_btn.TabStop = true;
            this.dinner_btn.Text = "Dinner\r\n";
            this.dinner_btn.UseVisualStyleBackColor = true;
            // 
            // break_btn
            // 
            this.break_btn.AutoSize = true;
            this.break_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.break_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.break_btn.Location = new System.Drawing.Point(8, 65);
            this.break_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.break_btn.Name = "break_btn";
            this.break_btn.Size = new System.Drawing.Size(119, 29);
            this.break_btn.TabIndex = 0;
            this.break_btn.TabStop = true;
            this.break_btn.Text = "Breakfast";
            this.break_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(537, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 41);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "SELECT YOUR MEAL TYPE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // show_menu_btn
            // 
            this.show_menu_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.show_menu_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_menu_btn.Location = new System.Drawing.Point(612, 243);
            this.show_menu_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_menu_btn.Name = "show_menu_btn";
            this.show_menu_btn.Size = new System.Drawing.Size(292, 52);
            this.show_menu_btn.TabIndex = 4;
            this.show_menu_btn.Text = "SHOW MENU";
            this.show_menu_btn.UseVisualStyleBackColor = false;
            this.show_menu_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(409, 305);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(722, 181);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.order_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.order_btn.Location = new System.Drawing.Point(683, 494);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(151, 57);
            this.order_btn.TabIndex = 6;
            this.order_btn.Text = "ORDER";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(23, 493);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 54);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(1262, 563);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_menu_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MealTypesBox);
            this.Name = "Order";
            this.Text = "USER_FORM";
            this.Load += new System.EventHandler(this.Order_Load);
            this.MealTypesBox.ResumeLayout(false);
            this.MealTypesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MealTypesBox;
        private System.Windows.Forms.RadioButton lunch_btn;
        private System.Windows.Forms.RadioButton dinner_btn;
        private System.Windows.Forms.RadioButton break_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button show_menu_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.RadioButton drinks_btn;
        private System.Windows.Forms.RadioButton all_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
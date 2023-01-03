
namespace RESTAURANT
{
    partial class ManageMeals
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
            this.MealDescLabel = new System.Windows.Forms.Label();
            this.meal_type_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.meal_name_label = new System.Windows.Forms.Label();
            this.meal_price = new System.Windows.Forms.TextBox();
            this.meal_name_cmb = new System.Windows.Forms.ComboBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.AddMealBtn = new System.Windows.Forms.Button();
            this.RemoveMealBtn = new System.Windows.Forms.Button();
            this.EditMealBtn = new System.Windows.Forms.Button();
            this.mealDexcBox = new System.Windows.Forms.RichTextBox();
            this.mealType_list = new System.Windows.Forms.ComboBox();
            this.MealNameBox = new System.Windows.Forms.TextBox();
            this.deleteMeal_btn = new System.Windows.Forms.Button();
            this.editMeal_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MealDescLabel
            // 
            this.MealDescLabel.AutoSize = true;
            this.MealDescLabel.BackColor = System.Drawing.Color.PapayaWhip;
            this.MealDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealDescLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MealDescLabel.Location = new System.Drawing.Point(350, 335);
            this.MealDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MealDescLabel.Name = "MealDescLabel";
            this.MealDescLabel.Size = new System.Drawing.Size(227, 36);
            this.MealDescLabel.TabIndex = 31;
            this.MealDescLabel.Text = "Meal Desciption";
            // 
            // meal_type_label
            // 
            this.meal_type_label.AutoSize = true;
            this.meal_type_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.meal_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_type_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.meal_type_label.Location = new System.Drawing.Point(350, 289);
            this.meal_type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meal_type_label.Name = "meal_type_label";
            this.meal_type_label.Size = new System.Drawing.Size(143, 36);
            this.meal_type_label.TabIndex = 25;
            this.meal_type_label.Text = "Meal type";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.price_label.Location = new System.Drawing.Point(350, 242);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(150, 36);
            this.price_label.TabIndex = 24;
            this.price_label.Text = "meal price";
            // 
            // meal_name_label
            // 
            this.meal_name_label.AutoSize = true;
            this.meal_name_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.meal_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meal_name_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.meal_name_label.Location = new System.Drawing.Point(350, 187);
            this.meal_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meal_name_label.Name = "meal_name_label";
            this.meal_name_label.Size = new System.Drawing.Size(157, 36);
            this.meal_name_label.TabIndex = 23;
            this.meal_name_label.Text = "meal name";
            // 
            // meal_price
            // 
            this.meal_price.Location = new System.Drawing.Point(537, 242);
            this.meal_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meal_price.Name = "meal_price";
            this.meal_price.Size = new System.Drawing.Size(180, 26);
            this.meal_price.TabIndex = 22;
            this.meal_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meal_price_KeyPress);
            // 
            // meal_name_cmb
            // 
            this.meal_name_cmb.FormattingEnabled = true;
            this.meal_name_cmb.Location = new System.Drawing.Point(556, 185);
            this.meal_name_cmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meal_name_cmb.Name = "meal_name_cmb";
            this.meal_name_cmb.Size = new System.Drawing.Size(180, 28);
            this.meal_name_cmb.TabIndex = 21;
            this.meal_name_cmb.SelectedValueChanged += new System.EventHandler(this.meal_name_cmb_SelectedValueChanged);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insert_btn.Location = new System.Drawing.Point(356, 440);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(117, 77);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "Insert Meal";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // AddMealBtn
            // 
            this.AddMealBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddMealBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMealBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddMealBtn.Location = new System.Drawing.Point(335, 35);
            this.AddMealBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddMealBtn.Name = "AddMealBtn";
            this.AddMealBtn.Size = new System.Drawing.Size(116, 66);
            this.AddMealBtn.TabIndex = 28;
            this.AddMealBtn.Text = "Add Meal";
            this.AddMealBtn.UseVisualStyleBackColor = false;
            this.AddMealBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveMealBtn
            // 
            this.RemoveMealBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.RemoveMealBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMealBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveMealBtn.Location = new System.Drawing.Point(482, 35);
            this.RemoveMealBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveMealBtn.Name = "RemoveMealBtn";
            this.RemoveMealBtn.Size = new System.Drawing.Size(116, 66);
            this.RemoveMealBtn.TabIndex = 29;
            this.RemoveMealBtn.Text = "Remove Meal";
            this.RemoveMealBtn.UseVisualStyleBackColor = false;
            this.RemoveMealBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditMealBtn
            // 
            this.EditMealBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.EditMealBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMealBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditMealBtn.Location = new System.Drawing.Point(631, 35);
            this.EditMealBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditMealBtn.Name = "EditMealBtn";
            this.EditMealBtn.Size = new System.Drawing.Size(116, 66);
            this.EditMealBtn.TabIndex = 30;
            this.EditMealBtn.Text = "Edit Meal";
            this.EditMealBtn.UseVisualStyleBackColor = false;
            this.EditMealBtn.Click += new System.EventHandler(this.EditMealBtn_Click);
            // 
            // mealDexcBox
            // 
            this.mealDexcBox.Location = new System.Drawing.Point(594, 336);
            this.mealDexcBox.Name = "mealDexcBox";
            this.mealDexcBox.Size = new System.Drawing.Size(263, 96);
            this.mealDexcBox.TabIndex = 32;
            this.mealDexcBox.Text = "";
            // 
            // mealType_list
            // 
            this.mealType_list.FormattingEnabled = true;
            this.mealType_list.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Drinks"});
            this.mealType_list.Location = new System.Drawing.Point(538, 278);
            this.mealType_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mealType_list.Name = "mealType_list";
            this.mealType_list.Size = new System.Drawing.Size(180, 28);
            this.mealType_list.TabIndex = 33;
            // 
            // MealNameBox
            // 
            this.MealNameBox.Location = new System.Drawing.Point(537, 187);
            this.MealNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MealNameBox.Name = "MealNameBox";
            this.MealNameBox.Size = new System.Drawing.Size(180, 26);
            this.MealNameBox.TabIndex = 34;
            // 
            // deleteMeal_btn
            // 
            this.deleteMeal_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.deleteMeal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMeal_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteMeal_btn.Location = new System.Drawing.Point(390, 440);
            this.deleteMeal_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteMeal_btn.Name = "deleteMeal_btn";
            this.deleteMeal_btn.Size = new System.Drawing.Size(117, 77);
            this.deleteMeal_btn.TabIndex = 35;
            this.deleteMeal_btn.Text = "Delete Meal Meal";
            this.deleteMeal_btn.UseVisualStyleBackColor = false;
            this.deleteMeal_btn.Click += new System.EventHandler(this.deleteMeal_btn_Click);
            // 
            // editMeal_btn
            // 
            this.editMeal_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.editMeal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMeal_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editMeal_btn.Location = new System.Drawing.Point(411, 440);
            this.editMeal_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editMeal_btn.Name = "editMeal_btn";
            this.editMeal_btn.Size = new System.Drawing.Size(117, 77);
            this.editMeal_btn.TabIndex = 36;
            this.editMeal_btn.Text = "Edit Meal";
            this.editMeal_btn.UseVisualStyleBackColor = false;
            this.editMeal_btn.Click += new System.EventHandler(this.editMeal_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(13, 475);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 54);
            this.back_btn.TabIndex = 37;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ManageMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.editMeal_btn);
            this.Controls.Add(this.deleteMeal_btn);
            this.Controls.Add(this.MealNameBox);
            this.Controls.Add(this.mealType_list);
            this.Controls.Add(this.mealDexcBox);
            this.Controls.Add(this.MealDescLabel);
            this.Controls.Add(this.EditMealBtn);
            this.Controls.Add(this.RemoveMealBtn);
            this.Controls.Add(this.AddMealBtn);
            this.Controls.Add(this.meal_type_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.meal_name_label);
            this.Controls.Add(this.meal_price);
            this.Controls.Add(this.meal_name_cmb);
            this.Controls.Add(this.insert_btn);
            this.Name = "ManageMeals";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label meal_type_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label meal_name_label;
        private System.Windows.Forms.TextBox meal_price;
        private System.Windows.Forms.ComboBox meal_name_cmb;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button AddMealBtn;
        private System.Windows.Forms.Button RemoveMealBtn;
        private System.Windows.Forms.Button EditMealBtn;
        private System.Windows.Forms.RichTextBox mealDexcBox;
        private System.Windows.Forms.ComboBox mealType_list;
        private System.Windows.Forms.TextBox MealNameBox;
        private System.Windows.Forms.Label MealDescLabel;
        private System.Windows.Forms.Button deleteMeal_btn;
        private System.Windows.Forms.Button editMeal_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
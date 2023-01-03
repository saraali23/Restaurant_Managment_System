
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
            this.managemeals_btn = new System.Windows.Forms.Button();
            this.managestaff_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managemeals_btn
            // 
            this.managemeals_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.managemeals_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managemeals_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.managemeals_btn.Location = new System.Drawing.Point(417, 100);
            this.managemeals_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.managemeals_btn.Name = "managemeals_btn";
            this.managemeals_btn.Size = new System.Drawing.Size(255, 90);
            this.managemeals_btn.TabIndex = 21;
            this.managemeals_btn.Text = "MANAGE MEALS";
            this.managemeals_btn.UseVisualStyleBackColor = false;
            this.managemeals_btn.Click += new System.EventHandler(this.managemeals_btn_Click);
            // 
            // managestaff_btn
            // 
            this.managestaff_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.managestaff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managestaff_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.managestaff_btn.Location = new System.Drawing.Point(417, 225);
            this.managestaff_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.managestaff_btn.Name = "managestaff_btn";
            this.managestaff_btn.Size = new System.Drawing.Size(255, 90);
            this.managestaff_btn.TabIndex = 22;
            this.managestaff_btn.Text = "MANAGE STAFF";
            this.managestaff_btn.UseVisualStyleBackColor = false;
            this.managestaff_btn.Click += new System.EventHandler(this.managestaff_btn_Click);
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
            this.back_btn.TabIndex = 23;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.managestaff_btn);
            this.Controls.Add(this.managemeals_btn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managemeals_btn;
        private System.Windows.Forms.Button managestaff_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
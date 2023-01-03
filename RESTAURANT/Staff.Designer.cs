
namespace RESTAURANT
{
    partial class Staff
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
            this.check_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_btn.Location = new System.Drawing.Point(465, 138);
            this.check_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(272, 111);
            this.check_btn.TabIndex = 16;
            this.check_btn.Text = "TAKE ORDER";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(465, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 109);
            this.button1.TabIndex = 17;
            this.button1.Text = "VIEW ORDERS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(33, 425);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(146, 67);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_btn);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_btn;
    }
}
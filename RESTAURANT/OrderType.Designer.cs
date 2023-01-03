
namespace RESTAURANT
{
    partial class OrderType
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
            this.normalorder_btn = new System.Windows.Forms.Button();
            this.deliveryorder_btn = new System.Windows.Forms.Button();
            this.onlineorder_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // normalorder_btn
            // 
            this.normalorder_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.normalorder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalorder_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.normalorder_btn.Location = new System.Drawing.Point(389, 67);
            this.normalorder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normalorder_btn.Name = "normalorder_btn";
            this.normalorder_btn.Size = new System.Drawing.Size(333, 108);
            this.normalorder_btn.TabIndex = 17;
            this.normalorder_btn.Text = "NORMAL ORDER";
            this.normalorder_btn.UseVisualStyleBackColor = false;
            this.normalorder_btn.Click += new System.EventHandler(this.normalorder_btn_Click);
            // 
            // deliveryorder_btn
            // 
            this.deliveryorder_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.deliveryorder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryorder_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deliveryorder_btn.Location = new System.Drawing.Point(389, 185);
            this.deliveryorder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deliveryorder_btn.Name = "deliveryorder_btn";
            this.deliveryorder_btn.Size = new System.Drawing.Size(333, 108);
            this.deliveryorder_btn.TabIndex = 18;
            this.deliveryorder_btn.Text = "DELIVERY ORDER";
            this.deliveryorder_btn.UseVisualStyleBackColor = false;
            this.deliveryorder_btn.Click += new System.EventHandler(this.deliveryorder_btn_Click);
            // 
            // onlineorder_btn
            // 
            this.onlineorder_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.onlineorder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineorder_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onlineorder_btn.Location = new System.Drawing.Point(389, 303);
            this.onlineorder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onlineorder_btn.Name = "onlineorder_btn";
            this.onlineorder_btn.Size = new System.Drawing.Size(333, 108);
            this.onlineorder_btn.TabIndex = 19;
            this.onlineorder_btn.Text = "ONLINE ORDER";
            this.onlineorder_btn.UseVisualStyleBackColor = false;
            this.onlineorder_btn.Click += new System.EventHandler(this.onlineorder_btn_Click);
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
            this.back_btn.TabIndex = 20;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // OrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.onlineorder_btn);
            this.Controls.Add(this.deliveryorder_btn);
            this.Controls.Add(this.normalorder_btn);
            this.Name = "OrderType";
            this.Text = "OrderType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button normalorder_btn;
        private System.Windows.Forms.Button deliveryorder_btn;
        private System.Windows.Forms.Button onlineorder_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
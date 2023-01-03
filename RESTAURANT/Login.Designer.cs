
namespace RESTAURANT
{
    partial class Login
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
            this.staff_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // staff_btn
            // 
            this.staff_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.staff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staff_btn.Location = new System.Drawing.Point(568, 350);
            this.staff_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(211, 119);
            this.staff_btn.TabIndex = 17;
            this.staff_btn.Text = "LOGIN";
            this.staff_btn.UseVisualStyleBackColor = false;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(337, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(337, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "PASSWORD";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(568, 150);
            this.username_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(286, 26);
            this.username_box.TabIndex = 20;
            this.username_box.Text = "sara";
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(568, 215);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(286, 26);
            this.pass_box.TabIndex = 28;
            this.pass_box.Text = "1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staff_btn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox pass_box;
    }
}
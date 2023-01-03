
namespace RESTAURANT
{
    partial class ManageStaff
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
            this.staffname_box = new System.Windows.Forms.TextBox();
            this.RemoveStaffBtn = new System.Windows.Forms.Button();
            this.AddSatffBtn = new System.Windows.Forms.Button();
            this.staffpass_label = new System.Windows.Forms.Label();
            this.staff_name_label = new System.Windows.Forms.Label();
            this.staffpass_box = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffname_box
            // 
            this.staffname_box.Location = new System.Drawing.Point(368, 182);
            this.staffname_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffname_box.Name = "staffname_box";
            this.staffname_box.Size = new System.Drawing.Size(180, 26);
            this.staffname_box.TabIndex = 54;
            this.staffname_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffname_box_KeyPress);
            // 
            // RemoveStaffBtn
            // 
            this.RemoveStaffBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.RemoveStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStaffBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveStaffBtn.Location = new System.Drawing.Point(629, 44);
            this.RemoveStaffBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveStaffBtn.Name = "RemoveStaffBtn";
            this.RemoveStaffBtn.Size = new System.Drawing.Size(182, 66);
            this.RemoveStaffBtn.TabIndex = 49;
            this.RemoveStaffBtn.Text = "REMOVE STAFF";
            this.RemoveStaffBtn.UseVisualStyleBackColor = false;
            this.RemoveStaffBtn.Click += new System.EventHandler(this.RemoveStaffBtn_Click);
            // 
            // AddSatffBtn
            // 
            this.AddSatffBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddSatffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSatffBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddSatffBtn.Location = new System.Drawing.Point(378, 44);
            this.AddSatffBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSatffBtn.Name = "AddSatffBtn";
            this.AddSatffBtn.Size = new System.Drawing.Size(184, 66);
            this.AddSatffBtn.TabIndex = 48;
            this.AddSatffBtn.Text = "ADD STAFF";
            this.AddSatffBtn.UseVisualStyleBackColor = false;
            this.AddSatffBtn.Click += new System.EventHandler(this.AddSatffBtn_Click);
            // 
            // staffpass_label
            // 
            this.staffpass_label.AutoSize = true;
            this.staffpass_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.staffpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpass_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.staffpass_label.Location = new System.Drawing.Point(32, 295);
            this.staffpass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffpass_label.Name = "staffpass_label";
            this.staffpass_label.Size = new System.Drawing.Size(293, 36);
            this.staffpass_label.TabIndex = 45;
            this.staffpass_label.Text = "STAFF PASSWORD";
            // 
            // staff_name_label
            // 
            this.staff_name_label.AutoSize = true;
            this.staff_name_label.BackColor = System.Drawing.Color.PapayaWhip;
            this.staff_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_name_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this.staff_name_label.Location = new System.Drawing.Point(32, 182);
            this.staff_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staff_name_label.Name = "staff_name_label";
            this.staff_name_label.Size = new System.Drawing.Size(206, 36);
            this.staff_name_label.TabIndex = 44;
            this.staff_name_label.Text = "STAFF NAME";
            // 
            // staffpass_box
            // 
            this.staffpass_box.Location = new System.Drawing.Point(368, 295);
            this.staffpass_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffpass_box.Name = "staffpass_box";
            this.staffpass_box.Size = new System.Drawing.Size(180, 26);
            this.staffpass_box.TabIndex = 43;
            this.staffpass_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffpass_box_KeyPress);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_btn.Location = new System.Drawing.Point(489, 380);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(117, 77);
            this.ok_btn.TabIndex = 41;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.StaffPassword});
            this.dataGridView1.Location = new System.Drawing.Point(298, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 177);
            this.dataGridView1.TabIndex = 55;
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.MinimumWidth = 8;
            this.StaffID.Name = "StaffID";
            this.StaffID.Width = 150;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Staff Name";
            this.StaffName.MinimumWidth = 8;
            this.StaffName.Name = "StaffName";
            this.StaffName.Width = 150;
            // 
            // StaffPassword
            // 
            this.StaffPassword.HeaderText = "Staff Password";
            this.StaffPassword.MinimumWidth = 8;
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.Width = 150;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Snow;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Maroon;
            this.back_btn.Location = new System.Drawing.Point(13, 452);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 54);
            this.back_btn.TabIndex = 56;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RESTAURANT.Properties.Resources.assortment_take_out_delivery_foods_top_view_double_side_border_white_wood_banner_background_pizza_hamburgers_fried_190066121;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.staffname_box);
            this.Controls.Add(this.RemoveStaffBtn);
            this.Controls.Add(this.AddSatffBtn);
            this.Controls.Add(this.staffpass_label);
            this.Controls.Add(this.staff_name_label);
            this.Controls.Add(this.staffpass_box);
            this.Controls.Add(this.ok_btn);
            this.Name = "ManageStaff";
            this.Text = "ManageStaff";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox staffname_box;
        private System.Windows.Forms.Button RemoveStaffBtn;
        private System.Windows.Forms.Button AddSatffBtn;
        private System.Windows.Forms.Label staffpass_label;
        private System.Windows.Forms.Label staff_name_label;
        private System.Windows.Forms.TextBox staffpass_box;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPassword;
        private System.Windows.Forms.Button back_btn;
    }
}
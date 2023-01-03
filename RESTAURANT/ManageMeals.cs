using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace RESTAURANT
{
    public partial class ManageMeals : Form
    {
        int check = 0;
        DataTable table;
        AdminClass admin;
        public ManageMeals(AdminClass ad)
        {
            admin = ad;
            InitializeComponent();
        }
        private void hideElements()
        {
            editMeal_btn.Hide();
            deleteMeal_btn.Hide();
            meal_name_cmb.Hide();
            meal_price.Hide();
            meal_name_label.Hide();
            price_label.Hide();
            insert_btn.Hide();
            meal_type_label.Hide();
            mealDexcBox.Hide();
            MealNameBox.Hide();
            MealDescLabel.Hide();
            mealType_list.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            hideElements();
            
          
        }
      
        private void insert_btn_Click(object sender, EventArgs e)
        {

            string mealname = MealNameBox.Text;
            int price = Convert.ToInt32( meal_price.Text);
            string mealtype = mealType_list.SelectedItem.ToString().Trim();
            string descs = mealDexcBox.Text;

            mealItem meal = new mealItem(mealname, mealtype, price, descs);

            check = admin.AddMeal(meal);
            if (check == 1)
                System.Windows.Forms.MessageBox.Show("Meal Successfully Inserted!");
            else if(check==0)
                System.Windows.Forms.MessageBox.Show("Meal Name Already Exitsts!");

        }

       

        private void button1_Click(object sender, EventArgs e)//add meal
        {
            //hide unneeded elemnts
            hideElements();
            //show needed elemnts
            meal_name_label.Show();
            MealNameBox.Show();//textbox

            price_label.Show();
            meal_price.Show();//text box

            meal_type_label.Show();
            mealType_list.Show();

            MealDescLabel.Show();
            mealDexcBox.Show();       

            insert_btn.Show();


        }
        //remove meal
        private void button2_Click(object sender, EventArgs e)
        {
            //hide unneeded elemnts
            hideElements();
            //show needed elemnts
            meal_name_label.Show();
            deleteMeal_btn.Show();
            //clear box from old values
            meal_name_cmb.Items.Clear();
            
            //get meal info
            table = getAllMeals();
            for (int i = 0; i < table.Rows.Count; i++)
                meal_name_cmb.Items.Add(table.Rows[i].ItemArray[0]);
            meal_name_cmb.Show();

        }

        private void meal_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteMeal_btn_Click(object sender, EventArgs e)
        {
            //get selected meal name
            var meals = meal_name_cmb.SelectedItem; 
            string mealname = meals.ToString();
            if (mealname != null)
            {
                //If a meal is selected then remove from database
                mealItem meal = new mealItem();
                meal.mealName = mealname;
                int check=admin.RemoveMeal(meal);
                if (check == 1) //removed correctly
                {
                    System.Windows.Forms.MessageBox.Show("Meal Successfully Removed!");
                    meal_name_cmb.Items.Remove(meals); //remove from combo box

                }
                else if (check == 0) //error happend
                    System.Windows.Forms.MessageBox.Show("There seems to be a problem!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please Select an Item!");
            }

        }

        private void EditMealBtn_Click(object sender, EventArgs e)
        {
            //hide unneeded elemnts
            hideElements();
            meal_name_label.Show();
            editMeal_btn.Show();
            meal_name_cmb.Items.Clear();

            //get meal info
            table = new DataTable();
            table=getAllMeals();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                meal_name_cmb.Items.Add(table.Rows[i].ItemArray[0]);
            }

            meal_name_cmb.Show();

            price_label.Show();
            meal_price.Show();//text box

            meal_type_label.Show();
            mealType_list.Show();

            MealDescLabel.Show();
            mealDexcBox.Show();


        }
        private DataTable getAllMeals()
        {
            DataTable table = new DataTable();
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from showAllMeals";
            table.Load(cmd.ExecuteReader());
            conn.Close();
            return table;
                     

        }
        private void editMeal_btn_Click(object sender, EventArgs e)
        {
            //get input values
            string mealname = meal_name_cmb.SelectedItem.ToString().Trim();
            int price = Convert.ToInt32(meal_price.Text);
            string mealtype = mealType_list.SelectedItem.ToString().Trim();
            string descs = mealDexcBox.Text;
            mealItem meal = new mealItem(mealname, mealtype, price, descs);

            //edit item in database
            int check=admin.EditMeal(meal);
            if (check == 1)
                System.Windows.Forms.MessageBox.Show("Meal Successfully Updated!");
            else if (check == 0)
                System.Windows.Forms.MessageBox.Show("There are some problems!");

        }
        private void meal_name_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            //each time an meal name is selected, get its info from the table
            int item = meal_name_cmb.SelectedIndex;
            meal_price.Text = table.Rows[item].ItemArray[2].ToString();
            mealType_list.Text = table.Rows[item].ItemArray[1].ToString();
            mealDexcBox.Text = table.Rows[item].ItemArray[3].ToString();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

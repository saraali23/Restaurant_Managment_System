using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RESTAURANT

{
    //class database
    //
    //public class NormalPayment
    //{
    //    public OrderClass Order;
    //    public string PaymentMethod;//visa or cash
    //    public NormalPayment(){}
       

    //}
    //public class VisaOffline: NormalPayment
    //{
    //    public string CardNumber;
    //    public VisaOffline(OrderClass ord,string card)
    //    {
    //        PaymentMethod = "Visa";
    //        Order = ord; //re-check if this works 
    //        CardNumber = card;
    //    }

    //}
    //public class VisaOnline : NormalPayment
    //{
    //    public Customer Cust;
    //    public string CardNumber;
    //    public VisaOnline(SpecialOrder ord, string card )
    //    {
    //        PaymentMethod = "Visa";
    //       // Order = new SpecialOrder(ord.phone,ord.OrdDate,"Online");//
    //        Order = ord;
    //        Cust = ord.cust;
    //        CardNumber = card;
    //    }
    //}
    public class mealItem
    {
        public string mealName;
        public int quantity;
        public int mealPrice;
        public string desc;
        public string type;
        public mealItem()
        {

        }
        public mealItem(string meal, int quan, int pri)
        {
            this.mealName = meal;
            this.quantity = quan;
            this.mealPrice = pri;
        }
        public mealItem(string meal,string mealTy, int pri,string des)
        {
            this.mealName = meal;
            this.type = mealTy;
            this.mealPrice = pri;
            this.desc = des;
        }


    }
    public class OrderClass
    {

        public int id;
        public int totalPrice;
        public List<mealItem> items;
        public string OrdDate;
        public StaffClass OrdStaff;
        public string PaymentMethod;//Cash or Visa
        

        public OrderClass()
        {
            items = new List<mealItem>();
        }
        
        public void CalcTotalPrice()
        {
            totalPrice = 0;
            for (int i = 0; i < items.Count; i++)
                totalPrice += items[i].mealPrice * items[i].quantity;
        }
        public int InsertMealsIntoOrder()
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);

            conn.Open();
            SqlCommand cmd;
            int check = 0;
            for (int i = 0; i < this.items.Count(); i++)
            {
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "addOrderMeal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@orderId", this.id);
                cmd.Parameters.Add("@mealname", this.items.ElementAt(i).mealName);
                cmd.Parameters.Add("@quant", this.items.ElementAt(i).quantity);
                cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
                if (check == 0) break;
            }

            return check;
        }
        public string PrintReciept()
        {
            string messege = "Order completed sucessfuly:" + System.Environment.NewLine;
            for (int i = 0; i < this.items.Count(); i++)
            {
                messege += " Item: " + this.items.ElementAt(i).mealName + " Quantity: " + this.items.ElementAt(i).quantity + " ,Price per one item: " + this.items.ElementAt(i).mealPrice + System.Environment.NewLine;
            }
            messege += " Total Price: " + this.totalPrice;
            return messege;

        }
       
        
    }
   
    public class SpecialOrder : OrderClass
    {
        public string phone;
        public Customer cust;
        public string type;//Delivery,Online
        public SpecialOrder(string ph, string dat, string type)
        {
            this.phone = ph;
            this.OrdDate = dat;
            this.type = type;
        }
        
    } 
    public class Employee
    {
        public int Id;
        public string Name;
        public int Password;
    }
    public class StaffClass:Employee
    {
      
        public StaffClass()
        {

        }
        public StaffClass(int id,string nam,int pass)
        {
            this.Id = id;
            this.Name = nam;
            this.Password = pass;
        }
        public StaffClass( string nam, int pass)
        {
            this.Name = nam;
            this.Password = pass;
        }
        public int AddNewCust(Customer cust)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "addCustomer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@phone", cust.phone);
            cmd.Parameters.Add("@name", cust.name);
            cmd.Parameters.Add("@city", cust.city);
            cmd.Parameters.Add("@street", cust.street);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            conn.Close();
            return check;

        }
        public void GetOrdersByDate(string date,DataTable ords)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from searchOrderByDate('" + date + "')";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            ords.Load(cmd.ExecuteReader());
            conn.Close();

        }
        public void GetOrdersByCust(string custPh, DataTable ords)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from searchOrderByPhone('" + custPh + "')";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            ords.Load(cmd.ExecuteReader());
            conn.Close();
        }
        public void GetOrdersByOrdType(string type, DataTable ords)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from searchOrderByType('" + type + "')";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            ords.Load(cmd.ExecuteReader());
            conn.Close();
        }
        public int AddAnOrd(OrderClass ord)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            SqlCommand cmd =new SqlCommand();
            cmd.Connection = conn;
            ord.CalcTotalPrice();
             cmd.CommandText = "addnormalorder";       
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@totalprice", ord.totalPrice);
            cmd.Parameters.Add("@staffID", ord.OrdStaff.Id);
            cmd.Parameters.Add("@pay", ord.PaymentMethod);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            ord.id = check;
            check = ord.InsertMealsIntoOrder();//add meals
            conn.Close();
            return check;

        }
        public  int AddAnOrd(SpecialOrder ord)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            SqlCommand cmd;
            ord.CalcTotalPrice();
            cmd = new SqlCommand();
            cmd.Connection = conn;

            if (ord.type == "Online")
                cmd.CommandText = "addOnlineOrder";

            else if (ord.type == "Delivery")
                cmd.CommandText = "addDeliveryOrder";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustPhone", ord.phone);
            cmd.Parameters.Add("@totalprice", ord.totalPrice);
            cmd.Parameters.Add("@staffID", ord.OrdStaff.Id);
            cmd.Parameters.Add("@pay", ord.PaymentMethod);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            ord.id = check;
            check = ord.InsertMealsIntoOrder();//add meals
            conn.Close();
            return check;

        }
        //public void geNormaltPayment(NormalPayment pay)
        //{
        //    string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
        //    SqlConnection conn = new SqlConnection(sqldb);
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable table = new DataTable();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "insert into PaymentMethod(PaymentMethod,OrderID) values('"+pay.PaymentMethod+"',"+pay.Order.id+"); ";
        //    cmd.CommandType = CommandType.Text;
        //    conn.Open();
        //    cmd.ExecuteReader();
        //    conn.Close();
        //}
        //public void geVisatPayment(VisaOffline pay)
        //{
        //    string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
        //    SqlConnection conn = new SqlConnection(sqldb);
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable table = new DataTable();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "insert into PaymentMethod(PaymentMethod,OrderID) values('" + pay.PaymentMethod + "'," + pay.Order.id + "); ";
        //    cmd.CommandType = CommandType.Text;
        //    conn.Open();
        //    cmd.ExecuteReader();
        //    cmd.CommandText = "insert into PaymentVisa(PaymentID,CardNumber) values('" + pay.PaymentMethod + "'," + pay.Order.id + "); ";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.ExecuteReader();
        //    conn.Close();
        //}


    }


    public class Customer
    {
        public string phone;
        public string name;
        public int id;
        public string city;
        public string street;
        public Customer()
        {

        }
    }
    public class AdminClass: Employee
    {
        public AdminClass()
        {

        }
        public int  AddMeal(mealItem meal)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn=new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "insert_meal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mealname", meal.mealName);
            cmd.Parameters.Add("@mealType", meal.type);
            cmd.Parameters.Add("@price", meal.mealPrice);
            cmd.Parameters.Add("@desc", meal.desc);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            conn.Close();
            return check;

        }
        public int RemoveMeal(mealItem meal)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "remove_meal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@mealname", meal.mealName);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            conn.Close();
            return check;
           
        }
        public int EditMeal(mealItem meal)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update_meal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mealname", meal.mealName);
            cmd.Parameters.Add("@mealType", meal.type);
            cmd.Parameters.Add("@price", meal.mealPrice);
            cmd.Parameters.Add("@desc", meal.desc);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());
            conn.Close();
            return check;
          
        }
        public int AddStaff(StaffClass staf)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);

            conn.Open();
            SqlCommand cmd;
            int check = -1;
         
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "addStaff";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", staf.Name);
            cmd.Parameters.Add("@password", staf.Password);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());              

            return check; //if check =-1  fail

        }
        public int RemoveStaff(StaffClass staf)
        {
            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);

            conn.Open();
            SqlCommand cmd;
            int check = -1;

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "removeStaff";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", staf.Name);
            cmd.Parameters.Add("@password", staf.Password);
            cmd.Parameters.Add("@y", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            check = Convert.ToInt32(cmd.Parameters["@y"].Value.ToString());

            return check; //if check =0  fail

        }
        public int GetAllStaff(List<StaffClass> st)
        {
            int check = 0;
            
            StaffClass temp;


            string sqldb = "Data Source=localhost;Initial Catalog=restaurant;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(sqldb);
           
            SqlCommand cmd= new SqlCommand();        
            DataTable table = new DataTable();
                cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from Staff";
            cmd.CommandType = CommandType.Text;
            table.Load(cmd.ExecuteReader());
            for(int i=0;i< table.Rows.Count; i++)
            {
                temp = new StaffClass(int.Parse(table.Rows[i].ItemArray[0].ToString())
                    , table.Rows[i].ItemArray[1].ToString(), int.Parse(table.Rows[i].ItemArray[2].ToString()));

                st.Add(temp);
            }
            check = 1;
            return check; //if check =0  fail

        }
    }
}

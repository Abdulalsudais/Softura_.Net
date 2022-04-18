using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataC
{
    class Toughest
    {
     public void NewCust()
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Activity; user id = sa; password = P@ssword");
            string CName, Gen, Cno, MailId, City;
            string Dob;
            Console.WriteLine("Enter your Name : ");
            CName = Console.ReadLine();
            Console.WriteLine("Enter your Gen : ");
            Gen = Console.ReadLine();
            Console.WriteLine("Enter your Cno : ");
            Cno = Console.ReadLine();
            Console.WriteLine("Enter your Dob : yyyy-mm-dd ");
            Dob = Console.ReadLine();
            Console.WriteLine("Enter your MailId : ");
            MailId = Console.ReadLine();
            Console.WriteLine("Choose from the cities Below: GOA,MUMBAI,CHENNAI,KARNATAKA.....");
            City = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("Insert tbl_Customer Values('" + CName + "','" + Gen + "','" + Cno + "','" + Dob + "','" + MailId + "','" + City + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Success!!!!!!");
            Toughest obj = new Toughest();
            obj.ProductList();
            obj.ProductDisplay();
       }
        public void ProductList()
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Activity; user id = sa; password = P@ssword");
            string prolist = "Select *from tbl_Product";
            SqlCommand cmd = new SqlCommand(prolist, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProdID : " + dr[0] + " " + "ProdName : " + dr[1] + "  " + "Price : " + dr[2] + "  " + "MFD : " + dr[3] + "  " + "ExpiryDate : " + dr[4]);
            }
        }
        public void ProductDisplay()
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374; database = Activity;user id = sa; password = P@ssword ");
            Console.WriteLine("Enter the CustomerID:");
            string cus = Console.ReadLine();
            Console.WriteLine("Enter the ProductID:");
            string pur = Console.ReadLine();
            Console.WriteLine("Enter the Quantity:");
            int unit = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("select ProductPrice* " + unit + " ,ProductId,ProductName,ProductPrice from tbl_Product where ProductId = " + pur + "", con);
            //SqlCommand cmd = new SqlCommand(pl, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                int Total = Convert.ToInt32(dr[0]);
                Console.WriteLine("ProdID : " + dr[1] + " " + "   ProdName : " + dr[2] + "  " + "  Price : " + dr[3] + "  Total Amount :  " + Total);
                string purins = "insert tbl_Purchase (CustomerID,ProductId,Quantity,TotalAmt) values (" + cus + "," + pur + "," + unit + "," + Total + ")";
                SqlConnection con1 = new SqlConnection("data source = ABDUL3374; database = Activity;user id = sa; password = P@ssword ");
                SqlCommand cmd1 = new SqlCommand(purins, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                Console.WriteLine("Thank You!!!!!");
                //Console.WriteLine("purchase Details Inserted");
                con1.Close();
            }
            con.Close();

        }
            public void ViewPurchase()
            {
                Console.WriteLine();
                Console.WriteLine("Enter your CustomerId To see Your Purchase:");
                string cuss = Console.ReadLine();
                SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Activity; user id = sa; password = P@ssword");
                string purch = "select  ptt.CustomerID,pt.ProductId,ProductName,ProductPrice,ptt.Quantity,TotalAmt from tbl_Product pt join tbl_Purchase ptt on pt.ProductId = ptt.ProductId where CustomerId = '" + cuss + "'";
                SqlCommand cmd = new SqlCommand(purch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine(" Purchased Details ");
                while (dr.Read())
                {

                    Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
                }
                con.Close();
            }
            public void PDate()
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Date:");
                var Date = Convert.ToString(Console.ReadLine());
                SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Activity; user id = sa; password = P@ssword");
                string purch = "select  ptt.CustomerID,pt.ProductId,ProductName,ProductPrice,ptt.Quantity,TotalAmt from tbl_Product pt join tbl_Purchase ptt on pt.ProductId = ptt.ProductId where PurchasedDate =' " + Date + "'";
                SqlCommand cmd = new SqlCommand(purch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine(" Purchased Details Using Date ");
                while (dr.Read())
                {

                    Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
                }
                con.Close();
            }
            public static void Main()
            {
                Console.WriteLine("Enter your CustId : ");

                Toughest obj = new Toughest();
                int CustomerId = Convert.ToInt32(Console.ReadLine());
                if (CustomerId >= 1 && CustomerId <= 4)
                {
                    Console.WriteLine("Your are Already a Customer");

                Console.WriteLine("(Willing to Continue - (Y or N))");
               
                   
                    //pobj.ProductDisplay();
                   
                    string Cond = Console.ReadLine();
                    if (Cond == "Y")
                    {                   
                    Console.WriteLine(" Choose any Product ");
                    obj.ProductList();
                    obj.ProductDisplay();

                }
                    else
                    {
                        Console.WriteLine("Thank you for Visiting !!!!");
                    }
                }
                else
                {
                    Console.WriteLine(" Your Id doesnot Exists,Enter your Deatails to be a New Customer ");

                    obj.NewCust();
                }

                obj.ViewPurchase();
                obj.PDate();



            }


        }


    }

      


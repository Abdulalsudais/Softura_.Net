using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Day27task
{
    class task27
    {
        public void createtable()
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Sql1; user id = sa; password = P@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table newTaskTest (sno int, StuName varchar(20))", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created");
            con.Close();
        }
        public void insert(int sno, string StuName)
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Sql1; user id = sa; password = P@ssword");
            SqlCommand cmd = new SqlCommand("sp_insTask", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(int sno, string StuName)
        {

            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Sql1; user id = sa; password = P@ssword");
            SqlCommand cmd = new SqlCommand("upd_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(int sno)
        {
            SqlConnection con = new SqlConnection("data source = ABDUL3374 ; database =  Sql1; user id = sa; password = P@ssword");
            SqlCommand cmd = new SqlCommand("del_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void Main()
        {
            task27 nobj = new task27();
            nobj.createtable();
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadLine();
            Console.WriteLine("Enter serialNo");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Topic");
            string tpic = Console.ReadLine();
            nobj.insert(N, tpic);
            nobj.Update(N,tpic);
            nobj.delete(N);

        }
    }
}


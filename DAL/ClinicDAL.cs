using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using ClinicManagement.Models;
using System.Data;

namespace ClinicManagement.DAL
{
    public class ClinicDAL
    {
        public string cnn = "";


        public ClinicDAL()
        {

            var builder = new ConfigurationBuilder().SetBasePath
                    (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public int CheckUser(Users chk)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("ChkUsr", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", chk.UserName);
            cmd.Parameters.AddWithValue("@Password", chk.Password);
            con.Open();
            IDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return (1);

            con.Close();
            return (0);
        }

        public int AddDoctors(Doctor doc)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("AddDoctors", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", doc.FirstName);
            cmd.Parameters.AddWithValue("@lname", doc.LastName);
            cmd.Parameters.AddWithValue("@gen", doc.Sex);
            cmd.Parameters.AddWithValue("@spec", doc.Specialization);
            cmd.Parameters.AddWithValue("@vis", doc.VisitingHours);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int AddPatient(Patient pat)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("AddPatients", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", pat.FirstName);
            cmd.Parameters.AddWithValue("@lname", pat.LastName);
            cmd.Parameters.AddWithValue("@sex", pat.Sex);
            cmd.Parameters.AddWithValue("@age", pat.Age);
            cmd.Parameters.AddWithValue("@dob", pat.DateofBirth);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public List<Doctor> ViewDoctor(Doctor doct)
        {
            List<Doctor> listdoctors = new List<Doctor>();
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Viewdoc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@spec", doct.Specialization);
            con.Open();
            IDataReader read = cmd.ExecuteReader();
            while (read.Read())
                listdoctors.Add(new Doctor()
                {
                    FirstName = read["FirstName"].ToString(),
                    LastName = read["LastName"].ToString()
                });
            return listdoctors;


        }
        //public int CheckUser(Users chk)
        //{
        //    SqlConnection con = new SqlConnection(cnn);
        //    SqlCommand cmd = new SqlCommand("ChkUsr", con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Username", chk.UserName);
        //    cmd.Parameters.AddWithValue("@Password", chk.Password);
        //    con.Open();
        //    IDataReader reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //        return (1);

        //    con.Close();
        //    return (0);
        //}
        public int Addappoint(Schedules Sch)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Addschedule", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@spec", Sch.Specializations);
            cmd.Parameters.AddWithValue("@Doc", Sch.DoctorName);
            cmd.Parameters.AddWithValue("@pat", Sch.patientName);
            cmd.Parameters.AddWithValue("@visit", Sch.VisitDate);
            cmd.Parameters.AddWithValue("@app", Sch.AppointmentTime);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public List<Schedules> Getappointments()
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Getapps", con);
            con.Open();
            IDataReader read = cmd.ExecuteReader();
            List<Schedules> lschedules = new List<Schedules>();
            while (read.Read())
            {
                lschedules.Add(new Schedules()
                {
                    AppointmentID = int.Parse(read["AppointmentId"].ToString()),
                    DoctorName = read["DoctorName"].ToString(),
                    patientName = read["patientName"].ToString(),
                    Specializations = read["Specializations"].ToString(),
                    VisitDate = read["VisitDate"].ToString(),
                    AppointmentTime = read["AppointmentTime"].ToString()

                });

            }
            return lschedules;
        }
        public int DelSchedule(int id)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Delschedule", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@app", id);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;



        }

    }
}
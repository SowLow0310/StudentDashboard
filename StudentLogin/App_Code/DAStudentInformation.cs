using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAStudentInformation
/// </summary>
public class DAStudentInformation
{
    SqlConnection sqlCon = null;
    String SqlconString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
    public DAStudentInformation()
    {
        
    }

    public void AddStudent(StudentEntity student)
    {
        using (sqlCon = new SqlConnection(SqlconString))
        {
            sqlCon.Open();
            string ProcedureName = "spAddStudentInformation";
            SqlCommand sql_cmnd = new SqlCommand(ProcedureName, sqlCon);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.CommandText = ProcedureName;
            sql_cmnd.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = student.StudentFirstName;
            sql_cmnd.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = student.StudentLastName;
            sql_cmnd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = student.StudentDOB;
            sql_cmnd.Parameters.AddWithValue("@CourseCode", SqlDbType.NVarChar).Value = student.CourseCode;
            sql_cmnd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = student.StudentAddress;
            sql_cmnd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = student.StudentContact;
            sql_cmnd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }

    public DataTable CourseList()
    {
        DataTable dataTable = new DataTable();
        using (sqlCon = new SqlConnection(SqlconString))
        {
            sqlCon.Open();
            string ProcedureName = "spGetCourseList";
            SqlCommand sql_cmnd = new SqlCommand(ProcedureName, sqlCon);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.CommandText = ProcedureName;
            SqlDataAdapter adpt = new SqlDataAdapter(sql_cmnd.CommandText, sqlCon);
            adpt.Fill(dataTable);

            sqlCon.Close();
        }

        return dataTable;
    }

    public DataTable StudentList()
    {
        DataTable dataTable = new DataTable();
        using (sqlCon = new SqlConnection(SqlconString))
        {
            sqlCon.Open();
            string ProcedureName = "spGetStudentList";
            SqlCommand sql_cmnd = new SqlCommand(ProcedureName, sqlCon);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.CommandText = ProcedureName;
            SqlDataAdapter adpt = new SqlDataAdapter(sql_cmnd.CommandText, sqlCon);
            adpt.Fill(dataTable);

            sqlCon.Close();
        }

        return dataTable;
    }
}
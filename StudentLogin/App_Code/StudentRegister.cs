using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentRegister
/// </summary>
public class StudentRegister
{
    public StudentRegister()
    {
        
    }

    public DataTable CourseList()
    {
        DataTable dataTable = new DataTable();
        DAStudentInformation studentInformation = new DAStudentInformation();
        dataTable = studentInformation.CourseList();

        return dataTable;
    }

    public DataTable StudentList()
    {
        DataTable dataTable = new DataTable();
        DAStudentInformation studentInformation = new DAStudentInformation();
        dataTable = studentInformation.StudentList();

        return dataTable;
    }

    public void AddStudent(StudentEntity student)
    {
        DAStudentInformation dAStudentInformation = new DAStudentInformation();
        dAStudentInformation.AddStudent(student);
    }
}
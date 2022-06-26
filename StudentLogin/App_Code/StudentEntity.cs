using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentEntity
/// </summary>
public class StudentEntity
{
    public StudentEntity()
    {
        
    }
    public int StudentID { get; set; }
    public string StudentFirstName { get; set; }

    public string StudentLastName { get; set; }

    public string CourseCode { get; set; }

    public DateTime StudentDOB { get; set; }

    public string StudentAddress { get; set; }

    public int StudentContact { get; set; }

}
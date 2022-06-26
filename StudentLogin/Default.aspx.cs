using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    StudentRegister studentRegister = new StudentRegister();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DataTable data = studentRegister.CourseList();

            ddlCourseList.DataSource = data;
            ddlCourseList.DataTextField = "CourseCode";
            ddlCourseList.DataValueField = "CourseCode";
            ddlCourseList.DataBind();
        }

        BindStudentGrid();
    }

    protected void btnAddStudent_Click(object sender, EventArgs e)
    {
        StudentEntity student = new StudentEntity();
        student.StudentFirstName = stdFName.Text.Trim();
        student.StudentLastName = stdLName.Text.Trim();
        student.StudentDOB = stdDateEdit.SelectedDate;
        student.CourseCode = ddlCourseList.SelectedValue;
        student.StudentContact = Convert.ToInt32(stdContact.Text.Trim());
        student.StudentAddress = stdAddress.Text.Trim();

        studentRegister.AddStudent(student);

        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Student data inserted successfully!');", true);

        BindStudentGrid();
        ResetControls();
    }

    protected void BindStudentGrid()
    {
        DataTable dtStudent = studentRegister.StudentList();

        gridStudentInfo.DataSource = dtStudent;
        gridStudentInfo.DataBind();
    }

    protected void ResetControls()
    {
        stdFName.Text = String.Empty;
        stdLName.Text = String.Empty;
        stdDateEdit.SelectedDate = DateTime.Today;
        ddlCourseList.SelectedIndex = -1;
        stdContact.Text = String.Empty;
        stdAddress.Text = String.Empty;
    }
}
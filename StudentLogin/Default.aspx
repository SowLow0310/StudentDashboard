<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <div style="font-size:x-large" align="center">Student Information Portal</div>
       <br />

       <table class="nav-justified">
           <tr>
               <td class="modal-sm" style="width: 322px; height: 24px"></td>
               <td style="width: 196px; height: 24px">Student ID</td>
               <td style="height: 24px">
                   <asp:TextBox ID="stdID" runat="server" Font-Size="Medium" Enabled="false"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px; height: 20px"></td>
               <td style="width: 196px; height: 20px">First Name</td>
               <td style="height: 20px">
                   <asp:TextBox ID="stdFName" runat="server" Font-Size="Medium"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px; height: 20px"></td>
               <td style="width: 196px; height: 20px">Last Name</td>
               <td style="height: 20px">
                   <asp:TextBox ID="stdLName" runat="server" Font-Size="Medium"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px">&nbsp;</td>
               <td style="width: 196px">Course Code</td>
               <td>
                   <asp:DropDownList ID="ddlCourseList" runat="server">
                   </asp:DropDownList>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px; height: 24px"></td>
               <td style="width: 196px; height: 24px">Date of Birth</td>
               <td style="height: 24px">
                   <asp:Calendar ID="stdDateEdit" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                       <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                       <DayStyle BackColor="#CCCCCC" />
                       <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                       <OtherMonthDayStyle ForeColor="#999999" />
                       <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                       <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                       <TodayDayStyle BackColor="#999999" ForeColor="White" />
                   </asp:Calendar>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px; height: 20px"></td>
               <td style="width: 196px; height: 20px">Address</td>
               <td style="height: 20px">
                   <asp:TextBox ID="stdAddress" runat="server" Font-Size="Medium"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px; height: 20px"></td>
               <td style="width: 196px; height: 20px">Contact</td>
               <td style="height: 20px">
                   <asp:TextBox ID="stdContact" runat="server" Font-Size="Medium"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px">&nbsp;</td>
               <td style="width: 196px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px">&nbsp;</td>
               <td style="width: 196px">&nbsp;</td>
               <td>
                   <asp:Button ID="btnAddStudent" runat="server" BackColor="#99CCFF" Font-Size="Medium" OnClick="btnAddStudent_Click" Text="Add Student" Width="101px" />
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px">&nbsp;</td>
               <td style="width: 196px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 322px">&nbsp;</td>
               <td style="width: 196px">&nbsp;</td>
               <td>
                   <asp:GridView ID="gridStudentInfo" runat="server" Width="499px">
                   </asp:GridView>
               </td>
           </tr>
       </table>

   </div>
</asp:Content>

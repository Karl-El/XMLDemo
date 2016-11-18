using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

namespace XMLDemo
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridStudent();
            }
        }

        protected void _btnInsert_Click(object sender, EventArgs e)
        {
            string FileName = Server.MapPath("StudentData.xml");
            if (File.Exists(FileName) == true)
            {
                XmlDocument XDoc = new XmlDocument();
                XDoc.Load(Server.MapPath("StudentData.xml"));
                XmlElement student = XDoc.CreateElement("student");

                XmlElement id = XDoc.CreateElement("id");
                XmlText xmlid = XDoc.CreateTextNode(_txtID.Text.Trim());
                XmlElement firstname = XDoc.CreateElement("firstname");
                XmlText xmlfirstname = XDoc.CreateTextNode(_txtFirstName.Text.Trim());
                XmlElement lastname = XDoc.CreateElement("lastname");
                XmlText xmllastname = XDoc.CreateTextNode(_txtLastName.Text.Trim());
                XmlElement city = XDoc.CreateElement("city");
                XmlText xmlcity = XDoc.CreateTextNode(_drpdwnlstCity.SelectedItem.Text);
                XmlElement gender = XDoc.CreateElement("gender");
                XmlText xmlgender = XDoc.CreateTextNode(_rdbtnlstGender.SelectedItem.Text);
                XmlElement postalcode = XDoc.CreateElement("postalcode");
                XmlText xmlpostalcode = XDoc.CreateTextNode(_txtPostalCode.Text.Trim());
                XmlElement mobileno = XDoc.CreateElement("mobileno");
                XmlText xmlmobileno = XDoc.CreateTextNode(_txtMobileNo.Text.Trim());

                id.AppendChild(xmlid);
                firstname.AppendChild(xmlfirstname);
                lastname.AppendChild(xmllastname);
                city.AppendChild(xmlcity);
                gender.AppendChild(xmlgender);
                postalcode.AppendChild(xmlpostalcode);
                mobileno.AppendChild(xmlmobileno);

                student.AppendChild(id);
                student.AppendChild(firstname);
                student.AppendChild(lastname);
                student.AppendChild(city);
                student.AppendChild(gender);
                student.AppendChild(postalcode);
                student.AppendChild(mobileno);

                XDoc.DocumentElement.AppendChild(student);
                XDoc.Save(Server.MapPath("StudentData.xml")); Response.Redirect(Request.Url.PathAndQuery, true);
            }
            else
            {
                XmlTextWriter XTW = new XmlTextWriter(FileName, null);

                XTW.WriteStartDocument();
                XTW.WriteStartElement("students");
                XTW.WriteStartElement("student");

                XTW.WriteElementString("id", _txtID.Text.Trim());
                XTW.WriteElementString("firstname", _txtFirstName.Text.Trim());
                XTW.WriteElementString("lastname", _txtLastName.Text.Trim());
                XTW.WriteElementString("city", _drpdwnlstCity.SelectedItem.Text);
                XTW.WriteElementString("gender", _rdbtnlstGender.SelectedItem.Text);
                XTW.WriteElementString("postalcode", _txtPostalCode.Text.Trim());
                XTW.WriteElementString("mobileno", _txtMobileNo.Text.Trim());

                XTW.WriteEndElement();
                XTW.WriteEndElement();
                XTW.WriteEndDocument();
                XTW.Close();
            }

        }

        public void BindGridStudent()
        {
            System.Data.DataSet DS = new System.Data.DataSet();
            DS.ReadXml(Server.MapPath("StudentData.xml"));

            _grdvwStudent.DataSource = DS;
            _grdvwStudent.DataBind();
        }

        protected void _grdvwStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            _grdvwStudent.EditIndex = e.NewEditIndex;
            BindGridStudent();
        }

        protected void _grdvwStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            _grdvwStudent.EditIndex = -1;
            BindGridStudent();
        }

        protected void _grdvwStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label _lblID = (Label)_grdvwStudent.Rows[e.RowIndex].FindControl("_lblID");
            TextBox _txtFirstName = (TextBox)_grdvwStudent.Rows[e.RowIndex].FindControl("_txtFirstName");
            TextBox _txtLastName = (TextBox)_grdvwStudent.Rows[e.RowIndex].FindControl("_txtLastName");
            DropDownList _drpdwnlstCity = (DropDownList)_grdvwStudent.Rows[e.RowIndex].FindControl("_drpdwnlstCity");
            RadioButtonList _rdbtnlstGender = (RadioButtonList)_grdvwStudent.Rows[e.RowIndex].FindControl("_rdbtnlstGender");
            TextBox _txtPostCode = (TextBox)_grdvwStudent.Rows[e.RowIndex].FindControl("_txtPostCode");
            TextBox _txtMobileNo = (TextBox)_grdvwStudent.Rows[e.RowIndex].FindControl("_txtMobileNo");

            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(Server.MapPath("StudentData.xml"));

            XmlNodeList NodeList = XDoc.SelectNodes("/students/student");

            foreach (XmlNode item in NodeList)
            {
                if (item.ChildNodes[0].InnerText == _lblID.Text)
                {
                    item.ChildNodes[1].InnerText = _txtFirstName.Text.Trim();
                    item.ChildNodes[2].InnerText = _txtLastName.Text.Trim();
                    item.ChildNodes[3].InnerText = _drpdwnlstCity.SelectedItem.Text;
                    item.ChildNodes[4].InnerText = _rdbtnlstGender.SelectedItem.Text;
                    item.ChildNodes[5].InnerText = _txtPostCode.Text.Trim();
                    item.ChildNodes[6].InnerText = _txtMobileNo.Text.Trim();
                }
            }

            XDoc.Save(Server.MapPath("StudentData.xml"));
            _grdvwStudent.EditIndex = -1;
            BindGridStudent();
        }

        protected void _grdvwStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label _lblID = (Label)_grdvwStudent.Rows[e.RowIndex].FindControl("_lblID");
            XmlDocument XDoc = new XmlDocument();
            XDoc.Load(Server.MapPath("StudentData.xml"));

            XmlNodeList NodeList = XDoc.SelectNodes("/students/student");

            foreach (XmlNode item in NodeList)
            {
                if (item.ChildNodes[0].InnerText == _lblID.Text)
                {
                    item.ParentNode.RemoveChild(item);
                }
            }

            XDoc.Save(Server.MapPath("StudentData.xml"));
            BindGridStudent();
        }
    }
}
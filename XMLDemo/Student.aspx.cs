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

        }

        protected void _btnInsert_Click(object sender, EventArgs e)
        {
            string FileName = Server.MapPath("StudentData.xml");
            if (File.Exists(FileName) == true)
            {
                XmlDocument XDoc = new XmlDocument();

            }
            else
            //11.18.16.11.36.AM //XMLDemo
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
    }
}
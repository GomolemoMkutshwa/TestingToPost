using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace TroyeComputerSolutions
{
    public partial class Register : MyBasePage
    {
  IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xPHpLFIEZB9ZPxEGOavaiYwfG0nzMRoMf4LuCVQ5",
            BasePath = "https://troyecomputersolutions.firebaseio.com/"
        };

        IFirebaseClient client;
       
        protected void Page_Load(object sender, EventArgs e)
 {
            client = new FireSharp.FirebaseClient(config);
            this.AsyncMode = true;
        }
        protected async void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSection.aspx");


            var data = new Data
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Id = txtId,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Province = txtProvince.Text,
                Phone = txtPhone.Text,
                Skills = txtSkills.Text,
                Years = txtYears.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Confirm = txtConfirm.Text


            };

            SetResponse response = await client.SetAsync("Information/" + txtName, data);
            Data result = response.ResultAs<Data>();

        }
    }
}

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

    
    public partial class AdminSection : System.Web.UI.Page { 
    //{3JjYUMerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW"
    //    https:troye-computer-systems.firebaseio.com/
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xPHpLFIEZB9ZPxEGOavaiYwfG0nzMRoMf4LuCVQ5",
            BasePath = "https://troyecomputersolutions.firebaseio.com/"
        };
     
        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           
               
            

            
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSection.aspx");
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSection.aspx");
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {

        }
    }
}
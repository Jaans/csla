using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace PTWebcs
{
	/// <summary>
	/// Summary description for _Default.
	/// </summary>
	public class _Default : System.Web.UI.Page
	{
    protected System.Web.UI.WebControls.HyperLink HyperLink2;
    protected System.Web.UI.WebControls.HyperLink HyperLink1;
    protected System.Web.UI.WebControls.Label lblName;
  
		private void Page_Load(object sender, System.EventArgs e)
		{
			    lblName.Text = User.Identity.Name;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
      this.Load += new System.EventHandler(this.Page_Load);

    }
		#endregion
	}
}

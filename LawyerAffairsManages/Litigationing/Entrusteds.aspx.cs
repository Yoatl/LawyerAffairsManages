using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LawyerAffairsManages.Litigationing
{
    public partial class Entrusteds : System.Web.UI.Page
    {
        Lawyer_DLL.BLL.case_entr bll = new Lawyer_DLL.BLL.case_entr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataLoad();
            }
        }

        private void DataLoad()
        {
            WTList.DataSource =null;
            WTList.DataSource = bll.GetList("").Tables[0];
            WTList.Rebind();
        }

    }
}
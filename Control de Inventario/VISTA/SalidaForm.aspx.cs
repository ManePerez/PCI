﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VISTA
{
    public partial class SalidaForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnAceptar_click(object sender, EventArgs e)
        {
            Response.Redirect("ListaProducto.aspx");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using CallCenter.Logic;

namespace CallCenter
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["AveriaID"];
            int averiaId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out averiaId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }

            }
            else
            {
                Debug.Fail("ERROR :Se ha llegado sin producto.");
                throw new Exception("ERROR : No se ha cogido un averiaID.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}
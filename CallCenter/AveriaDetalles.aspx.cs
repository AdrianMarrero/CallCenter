using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CallCenter.Models;
using System.Web.ModelBinding;

namespace CallCenter
{
    public partial class AveriaDetalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Averia> GetAverias([QueryString("averiaID")] int? averiaId)
        {
            var _db = new CallCenter.Models.AveriaContext();
            IQueryable<Averia> query = _db.Averias;
            if (averiaId.HasValue && averiaId > 0)
            {
                query = query.Where(p => p.AveriaID == averiaId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}
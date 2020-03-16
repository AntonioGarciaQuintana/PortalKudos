using Core.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AppContext : DbContext
    {
        IDbSet<Student> Students { get; set; }

        public AppContext()
            : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
        }

        public new void Dispose()
        {
            base.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}

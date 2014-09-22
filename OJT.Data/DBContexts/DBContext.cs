using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using OJT.Model.Models;

namespace OJT.Data.DBContexts
{
    public class OJTDBContext : IdentityDbContext<ApplicationUser>
    {
        public OJTDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static OJTDBContext Create()
        {
            return new OJTDBContext();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TR_Group.DAL.IdentiyTables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
#region
/* 
* using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
* This Namespace is use by 
* IdentityDbContext<ApplicationUser>
* 
*/
#endregion
using Microsoft.EntityFrameworkCore;
#region
/* 
* using Microsoft.EntityFrameworkCore;
* This Namespace is use by 
* DbContextOptions
* 
*/
#endregion



namespace TR_Group.DAL.DatabaseContext
{
    public class TRGroup_DataContext : IdentityDbContext<ApplicationUser>
    {
#nullable disable
        public TRGroup_DataContext()
        {

        }

        public TRGroup_DataContext(DbContextOptions<TRGroup_DataContext> options) : base(options)
        {
        }


        //Create the DataSet for the Employee         
        public DbSet<ApplicationUser> AspNetUsers { get; set; }
    }
}

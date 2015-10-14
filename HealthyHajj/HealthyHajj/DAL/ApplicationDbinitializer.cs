using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HealthyHajj.DAL
{
    public class ApplicationDbinitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        
    }
}
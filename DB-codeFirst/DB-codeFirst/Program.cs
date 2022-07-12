using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DB_codeFirst.DbModels;

namespace DB_codeFirst
{
    public sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();

                var firstOffice = context.Office.SingleOrDefault(x => x.OfficeId == 1);

                if (firstOffice is not null)
                {
                    firstOffice.Title = "lalala";
                }

                context.SaveChanges();
            }

            Console.WriteLine("done");
        } 
    }
}



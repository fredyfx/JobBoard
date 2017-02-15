using JobBoard.Data;
using JobBoard.Models.JsonJobModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace JobBoard.Models.SeedDataModel
{
    public class SeedData
    {
        // also calling seed data in the configure method of startup.cs

        public static void InitializeDb(IServiceProvider serviceProvider)
        {
            using (var context = new JobBoardDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<JobBoardDbContext>>()))
            {
                if (context.JsonJob.Any())
                {
                    return; // db has already been seeded
                }

                

                context.JsonJob.AddRange(
                    new JsonJob
                    {
                        ApplicationLink = "http://www.phcnw.com/about-us/careers-phcnw",
                        Company = "PHC Northwest",
                        DatePosted = "Closing Date: open until filled",
                        Experience = "",
                        Hours = "Full Time",
                        JobID = "",
                        JobTitle = "Project Area Manager, Washington County",
                        LanguagesUsed = "",
                        Location = "",
                        Salary = "Portland Metro"
                    },

                    new JsonJob
                    {
                        ApplicationLink = "http://jobs@maxwellpr.com",
                        Company = "Maxwell PR + Engagement",
                        DatePosted = "Closing Date: open until filled",
                        Experience = "",
                        Hours = "Full Time",
                        JobID = "",
                        JobTitle = "Paid Media Specialist",
                        LanguagesUsed = "",
                        Location = "Portland Metro",
                        Salary = ""
                    }
                );

                // save the data into the db
                context.SaveChanges();
            }
        }
    }
}

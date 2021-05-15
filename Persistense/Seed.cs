using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistense
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Missions.Any()) return;
            
            var missions = new List<Mission> {
                new Mission
                {
                    BUnit = "SeLoger Vacances",
                    Company = new Company {
                        Name = "SeLoger",
                        BUnit = "SeLoger Vacances",
                        Contacts = new List<Contact> {
                            new Contact {
                                CreateDate = DateTime.Now,
                                Email = "techlead@hrteam.com",
                                FirstName = "Tech",
                                LastName = "Lead",
                                MobileNumber = "065433454",
                                Position = "Tech Lead",
                                UpdateDate = DateTime.Now
                            }
                        },
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    },
                    CreateDate = DateTime.Now,
                    DateBeginContract = new DateTime(2021-05-19),
                    Intermediate = new Intermediate {
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Name = "HR Team",
                    },
                    IsRenewable = true,
                    MissionDurationMonths = 3,
                    Title = "Développeur Sénior Fullstack .NETCore/React",
                    TJM = 480,
                    UpdateDate = DateTime.Now


                }
            };

            await context.Missions.AddRangeAsync(missions);
            await context.SaveChangesAsync();
        }
    }
}
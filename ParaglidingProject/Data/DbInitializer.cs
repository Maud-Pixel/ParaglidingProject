using ParaglidingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaglidingProject.Data
{
    public class DbInitializer
    {
        public static void Initialize(ParaglidingClubContext context)
        {
            context.Database.EnsureCreated();

            if(context.Pilots.Any())
            {
                return;
            }

            var pilots = new Pilot[]
            {
                new Pilot{FirstName="Tony", LastName="Stark", Adress="39 Cliffbide Drive Malibu, CA 56677", PhoneNumber="0488971525", Weight=78, Role=Role.Président },
                new Pilot{FirstName="Steve", LastName="Rogers", Adress="1404 Alameda Ave Brooklyn, NY 11365", PhoneNumber="0456321598", Weight=99, Role=Role.Secrétaire },
                new Pilot{FirstName="Clint", LastName="Barton", Adress="244 Ramblewood St. San Angelo, TX 76904", PhoneNumber="0423165878", Weight=80, Role=Role.Trésorier },
                new Pilot{FirstName="Bruce", LastName="Banner", Adress="273 South St Louis Lane New York, NY 10034", PhoneNumber="04598617", Weight=79 },
                new Pilot{FirstName="Natacha", LastName="Romanov", Adress="70 Arnold St. Los Angeles, CA 90042", PhoneNumber="04598617", Weight=55 },
            };

            foreach(Pilot p in pilots)
            {
                context.Pilots.Add(p);
            }
            context.SaveChanges();

            var models = new ModelParagliding[]
            {
                new ModelParagliding{HeightParagliding="25m²", MaxWeightPilot=90, MinWeightPilot=40, AprovalDate=DateTime.Parse("2015-03-15"), AprovalNumber="152689" },
                new ModelParagliding{HeightParagliding="26m²", MaxWeightPilot=100, MinWeightPilot=45, AprovalDate=DateTime.Parse("2012-07-28"), AprovalNumber="256986" },
                new ModelParagliding{HeightParagliding="28m²", MaxWeightPilot=120, MinWeightPilot=60, AprovalDate=DateTime.Parse("2017-01-04"), AprovalNumber="362514" },
            };

            foreach(ModelParagliding m in models)
            {
                context.ModelParaglidings.Add(m);
            }

            context.SaveChanges();
        }
    }
}

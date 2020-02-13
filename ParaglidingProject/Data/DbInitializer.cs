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

            #region Pilots
            if (context.Pilots.Any())
            {
                return;
            }

            var pilots = new Pilot[]
            {
                new Pilot{FirstName="Tony", LastName="Stark", Adress="39 Cliffbide Drive Malibu, CA 56677", PhoneNumber="0488971525", Weight=78, Role=Role.Président, LevelID=5 },
                new Pilot{FirstName="Steve", LastName="Rogers", Adress="1404 Alameda Ave Brooklyn, NY 11365", PhoneNumber="0456321598", Weight=99, Role=Role.Secrétaire, LevelID=1 },
                new Pilot{FirstName="Clint", LastName="Barton", Adress="244 Ramblewood St. San Angelo, TX 76904", PhoneNumber="0423165878", Weight=80, Role=Role.Trésorier, LevelID=3 },
                new Pilot{FirstName="Bruce", LastName="Banner", Adress="273 South St Louis Lane New York, NY 10034", PhoneNumber="04598617", Weight=79, LevelID=2 },
                new Pilot{FirstName="Natacha", LastName="Romanov", Adress="70 Arnold St. Los Angeles, CA 90042", PhoneNumber="04598617", Weight=55, LevelID=3 },
            };

            foreach(Pilot p in pilots)
            {
                context.Pilots.Add(p);
            }
            context.SaveChanges();

            #endregion

            #region Flights(pas fini)
            if (context.Flights.Any())
            {
                return;
            }

            var flights = new Flight[]
            {
                new Flight{PilotID=1, ParaglidingID=2, FlightDate=DateTime.Parse("2018-04-18"), FlightDuration=0.10F, LandingSiteID=1, TakeOffSiteID=2 },
                new Flight{PilotID=1, ParaglidingID=1, FlightDate=DateTime.Parse("2018-07-12"), FlightDuration=0.08F, LandingSiteID=2, TakeOffSiteID=2 },
                new Flight{PilotID=1, ParaglidingID=2, FlightDate=DateTime.Parse("2019-04-04"), FlightDuration=0.07F, LandingSiteID=2, TakeOffSiteID=2 },
                new Flight{PilotID=1, ParaglidingID=2, FlightDate=DateTime.Parse("2019-07-21"), FlightDuration=0.10F, LandingSiteID=3, TakeOffSiteID=2 },
                new Flight{PilotID=2, ParaglidingID=5, FlightDate=DateTime.Parse("2018-01-21"), FlightDuration=0.10F, LandingSiteID=3, TakeOffSiteID=2 },
            };

            foreach (Flight f in flights)
            {
                context.Flights.Add(f);
            }
            context.SaveChanges();
            #endregion

            #region Paraglidings
            if (context.Paraglidings.Any())
            {
                return;
            }

            var paraglidings = new Paragliding[]
            {
                new Paragliding{ModelParaglidingID=1, DateOfCommissioning=DateTime.Parse("2015-07-02"), DateOfLastRevision=DateTime.Parse("2019-12-09") },
                new Paragliding{ModelParaglidingID=1, DateOfCommissioning=DateTime.Parse("2016-01-28"), DateOfLastRevision=DateTime.Parse("2019-11-04") },
                new Paragliding{ModelParaglidingID=2, DateOfCommissioning=DateTime.Parse("2014-02-12"), DateOfLastRevision=DateTime.Parse("2020-01-10") },
                new Paragliding{ModelParaglidingID=2, DateOfCommissioning=DateTime.Parse("2013-08-03"), DateOfLastRevision=DateTime.Parse("2019-09-18") },
                new Paragliding{ModelParaglidingID=3, DateOfCommissioning=DateTime.Parse("2017-04-22"), DateOfLastRevision=DateTime.Parse("2019-11-25") },

            };

            foreach(Paragliding p in paraglidings)
            {
                context.Paraglidings.Add(p);
            }
            context.SaveChanges();

            #endregion

            #region ModelParaglidings

            if (context.ModelParaglidings.Any())
            {
                return;
            }

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
            #endregion

            #region Licenses

            if(context.Licenses.Any())
            {
                return;
            }

            var licenses = new License[]
            {
                new License{Title="Pilote de parapente", LevelID=1},
                new License{Title="Pilote XC de parapente", LevelID=2},
                new License{Title="Moniteur de parapente", LevelID=3},
                new License{Title="Pilote au treuil de parapente", LevelID=4},
                new License{Title="Examinateur de parapente", LevelID=5}
            };

            foreach(License l in licenses)
            {
                context.Licenses.Add(l);
            }

            context.SaveChanges();

            #endregion

            #region Courses

            if(context.Courses.Any())
            {
                return;
            }

            var courses = new Course[]
            {
                new Course{StartDate=DateTime.Parse("2018-04-29"), EndDate=DateTime.Parse("2018-05-30"), CoursePrice=70.00M, LicenseID=1},
                new Course{StartDate=DateTime.Parse("2018-06-18"), EndDate=DateTime.Parse("2018-07-10"), CoursePrice=30.50M, LicenseID=3},
                new Course{StartDate=DateTime.Parse("2018-09-15"), EndDate=DateTime.Parse("2018-11-12"), CoursePrice=46.00M, LicenseID=2},
                new Course{StartDate=DateTime.Parse("2019-01-15"), EndDate=DateTime.Parse("2019-03-20"), CoursePrice=60.00M, LicenseID=4},
                new Course{StartDate=DateTime.Parse("2019-05-25"), EndDate=DateTime.Parse("2019-07-19"), CoursePrice=35.80M, LicenseID=5},
                new Course{StartDate=DateTime.Parse("2019-10-02"), EndDate=DateTime.Parse("2019-12-23"), CoursePrice=30.50M, LicenseID=3}
            };

            foreach(Course c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges();
            #endregion

            #region Levels

            if(context.Levels.Any())
            {
                return;
            }

            var levels = new Level[]
            {
                new Level{Name="Niveau 1", Skill="Savoir decoller, savoir atterrir"},
                new Level{Name="Niveau 2", Skill="Bonne maitrise du parapente, savoir évaluer les conditions météo"},
                new Level{Name="Niveau 3", Skill="Savoir enseigner aux aspirants pilotes, savoir voler avec treuil, très bonne maitrise"},
                new Level{Name="Niveau 4", Skill="Maitrise totale du parapente à tous temps"},
                new Level{Name="Niveau 5", Skill="Savoir évaluer les aspirants pilotes et les moniteurs"},

            };

            foreach(Level l in levels)
            {
                context.Levels.Add(l);
            }

            context.SaveChanges();
            #endregion

            #region LandingSites

            if(context.LandingSites.Any())
            {
                return;
            }

            var landingSites = new LandingSite[]
            {
                new LandingSite{Name="Site d'atterrissage 1", Orientation="S-E", DescriptionAproach="PTU", LevelID=2},
                new LandingSite{Name="Site d'atterrissage 2", Orientation="N-E", DescriptionAproach="PT8", LevelID=4},
                new LandingSite{Name="Site d'atterrissage 3", Orientation="N", DescriptionAproach="PTL", LevelID=1},
            };

            foreach(LandingSite ls in landingSites)
            {
                context.LandingSites.Add(ls);
            }

            context.SaveChanges();
            #endregion

            #region TakeOffSites

            if(context.TakeOffSites.Any())
            {
                return;
            }

            var takeOffSites = new TakeOffSite[]
            {
                new TakeOffSite{Name="Site de decollage 1", Orientation="E", LevelID=1},
                new TakeOffSite{Name="Site de decollage 2", Orientation="S-O", LevelID=3},
                new TakeOffSite{Name="Site de decollage 3", Orientation="O", LevelID=2},
            };

            foreach(TakeOffSite ts in takeOffSites)
            {
                context.TakeOffSites.Add(ts);
            }

            context.SaveChanges();
            #endregion

            #region Subscriptions

            if(context.Subscriptions.Any())
            {
                return;
            }

            var subscriptions = new Subscription[]
            {
                new Subscription{Year=2017, Price=20.00M},
                new Subscription{Year=2018, Price=25.00M},
                new Subscription{Year=2019, Price=15.50M},
                new Subscription{Year=2020, Price=19.50M},

            };

            foreach(Subscription s in subscriptions)
            {
                context.Subscriptions.Add(s);
            }

            context.SaveChanges();
            #endregion

            #region Payments

            if(context.Payments.Any())
            {
                return;
            }

            var payments = new Payment[]
            {
                new Payment{SubsciptionID=1, PilotID=1, IsPay=true},
                new Payment{SubsciptionID=2, PilotID=1, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=1, IsPay=true},
                new Payment{SubsciptionID=4, PilotID=1, IsPay=true},
                new Payment{SubsciptionID=1, PilotID=2, IsPay=true},
                new Payment{SubsciptionID=2, PilotID=2, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=2, IsPay=true},
                new Payment{SubsciptionID=4, PilotID=2, IsPay=false},
                new Payment{SubsciptionID=2, PilotID=3, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=3, IsPay=true},
                new Payment{SubsciptionID=4, PilotID=3, IsPay=true},
                new Payment{SubsciptionID=1, PilotID=4, IsPay=true},
                new Payment{SubsciptionID=2, PilotID=4, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=4, IsPay=true},
                new Payment{SubsciptionID=4, PilotID=4, IsPay=true},
                new Payment{SubsciptionID=1, PilotID=5, IsPay=true},
                new Payment{SubsciptionID=2, PilotID=5, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=5, IsPay=true},
                new Payment{SubsciptionID=3, PilotID=5, IsPay=false},
            };

            foreach(Payment p in payments)
            {
                context.Payments.Add(p);
            }

            context.SaveChanges();
            #endregion

            #region Obtainings

            if(context.Obtainings.Any())
            {
                return;
            }

            var obtainings = new Obtaining[]
            {
                new Obtaining{PilotID=1, LicenseID=5, IsSucced=true, ObtainingDate=DateTime.Parse("2019-07-19") },
                new Obtaining{PilotID=2, LicenseID=1, IsSucced=true, ObtainingDate=DateTime.Parse("2018-05-30") },
                new Obtaining{PilotID=3, LicenseID=3, IsSucced=true, ObtainingDate=DateTime.Parse("2018-07-10") },
                new Obtaining{PilotID=3, LicenseID=4, IsSucced=false },
                new Obtaining{PilotID=4, LicenseID=1, IsSucced=true, ObtainingDate=DateTime.Parse("2018-05-30") },
                new Obtaining{PilotID=4, LicenseID=2, IsSucced=true, ObtainingDate=DateTime.Parse("2018-11-12") },
                new Obtaining{PilotID=5, LicenseID=1, IsSucced=true, ObtainingDate=DateTime.Parse("2018-05-30") },
                new Obtaining{PilotID=5, LicenseID=2, IsSucced=true, ObtainingDate=DateTime.Parse("2018-11-12") },
                new Obtaining{PilotID=5, LicenseID=3, IsSucced=true, ObtainingDate=DateTime.Parse("2019-12-23") },
            };

            foreach(Obtaining o in obtainings)
            {
                context.Obtainings.Add(o);
            }

            context.SaveChanges();

            #endregion

            #region Teachings

            if(context.Teachings.Any())
            {
                return;
            }

            var teachings = new Teaching[]
            {
                new Teaching{PilotID=1, CourseID=1},
                new Teaching{PilotID=1, CourseID=2},
                new Teaching{PilotID=1, CourseID=3},
                new Teaching{PilotID=1, CourseID=4},
                new Teaching{PilotID=1, CourseID=6},
                new Teaching{PilotID=3, CourseID=3},
                new Teaching{PilotID=3, CourseID=6},
            };

            foreach(Teaching t in teachings)
            {
                context.Teachings.Add(t);
            }

            context.SaveChanges();

            #endregion

            #region Participations

            if(context.Participations.Any())
            {
                return;
            }

            var participations = new Participation[]
            {
                new Participation{CourseID=1, PilotID=2, IsPay=true},
                new Participation{CourseID=1, PilotID=4, IsPay=true},
                new Participation{CourseID=1, PilotID=5, IsPay=true},
                new Participation{CourseID=2, PilotID=3, IsPay=true},
                new Participation{CourseID=3, PilotID=4, IsPay=true},
                new Participation{CourseID=3, PilotID=5, IsPay=true},
                new Participation{CourseID=4, PilotID=3, IsPay=true},
                new Participation{CourseID=5, PilotID=1, IsPay=true},
                new Participation{CourseID=6, PilotID=5, IsPay=true},
            };

            foreach(Participation p in participations)
            {
                context.Participations.Add(p);
            }

            context.SaveChanges();

            #endregion
        }
    }
}

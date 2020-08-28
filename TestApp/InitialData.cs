using System.Linq;
using TestApp.Models;

namespace TestApp
{
    public static class InitialData
    {
        public static void Initialize(FacilityContext context)
        {
            if (!context.FacilityStatuses.Any())
            {
                context.FacilityStatuses.AddRange(
                    new FacilityStatus
                    {
                        Name = "Active"
                    },
                    new FacilityStatus
                    {
                        Name = "Inactive"
                    },
                    new FacilityStatus
                    {
                        Name = "OnHold"
                    }
                    );

                context.SaveChanges();
            }

            if (!context.Facilities.Any())
            {
                context.Facilities.AddRange(
                    new Facility
                    {
                        Name = "Anna",
                        Address = "UPA 5, 217, Lviv",
                        PhoneNumber = "+380-970-557-981",
                        Email = "annaganna@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Georg",
                        Address = "Shevchenka 15, 55, Kyiv",
                        PhoneNumber = "+380-637-711-892",
                        Email = "georggeorg@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Mikhailo",
                        Address = "Bandery 18, 20, Oslo",
                        PhoneNumber = "+380-988-456-325",
                        Email = "mikhailoailo@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "OnHold").FirstOrDefault()
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}

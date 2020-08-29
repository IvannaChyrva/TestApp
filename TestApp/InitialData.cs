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
                    },
                    new Facility
                    {
                        Name = "Grisha",
                        Address = "Verbytskogo 9, 85, Kyiv",
                        PhoneNumber = "+380-589-788-123",
                        Email = "gggrisha@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Mila",
                        Address = "Bandery 5, 106, Oslo",
                        PhoneNumber = "+380-989-625-767",
                        Email = "milagamnila@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "OnHold").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Yulia",
                        Address = "Shevchenka 85, 57, Kyiv",
                        PhoneNumber = "+380-668-771-254",
                        Email = "yuliagrusi@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Oleg",
                        Address = "Bandery 1, 6, Oslo",
                        PhoneNumber = "+380-896-456-115",
                        Email = "olegjikl@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "OnHold").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Nazar",
                        Address = "Shevchenka 75, 311, Kyiv",
                        PhoneNumber = "+380-683-158-111",
                        Email = "nazarnna@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Mila",
                        Address = "Bandery 1, 15, Oslo",
                        PhoneNumber = "+380-975-450-300",
                        Email = "milamila@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "OnHold").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Valerii",
                        Address = "Shevchenka 93, 11, Kyiv",
                        PhoneNumber = "+380-689-141-131",
                        Email = "valerii1265@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "Inactive").FirstOrDefault()
                    },
                    new Facility
                    {
                        Name = "Kira",
                        Address = "Kochevnuka 32, 20, Lviv",
                        PhoneNumber = "+380-985-256-245",
                        Email = "125kira125@gmail.com",
                        FacilityStatus = context.FacilityStatuses.Where(f => f.Name == "OnHold").FirstOrDefault()
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}

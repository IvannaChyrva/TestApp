namespace TestApp.Models
{
    public class Facility
    {
        public int FacilityId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int FacilityStatusId { get; set; }

        public FacilityStatus FacilityStatus { get; set; }
    }
}

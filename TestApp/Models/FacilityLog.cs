using System;

namespace TestApp.Models
{
    public class FacilityLog
    {
        public int FacilityLogId { get; set; }        

        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public DateTime ChangeDate { get; set; }

        public int FacilityId { get; set; }

        public Facility Facility { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TalentsManagerService.Data.Model
{
    public class Talent : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string Linkedin { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portfolio { get; set; }

        public AvailabilityHour AvailabilityHour { get; set; }

        public AvailabilityPartOfDay AvailabilityPartOfDay { get; set; }

        public Decimal HourlySalary { get; set; }

        public virtual ICollection<TalentKnowledge> Knowledges { get; set; }
    }

    public enum AvailabilityHour
    {
        UpToFourHours,
        BetweenFourAndSixHours,
        BetweenSixAndEightHours,
        UpToEightHours,
        OnlyWeekends
    }

    public enum AvailabilityPartOfDay
    {
        Morning,
        Afternoon,
        Night,
        Dawn,
        Business
    }
}
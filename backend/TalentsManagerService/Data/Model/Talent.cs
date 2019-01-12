using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentsManagerService.Data.Model
{
    public class Talent : BaseEntity
    {
        private static string DELIMITER = ";";

        #region Fields

        public string Name { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string Linkedin { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portfolio { get; set; }

        public Decimal HourlySalary { get; set; }

        public bool UpToFourHoursPerDay { get; set; }
        public bool FourToSixHoursPerDay { get; set; }
        public bool SixToHeightHoursPerDay { get; set; }
        public bool UpToEightHoursPerDay { get; set; }
        public bool OnlyWeekends { get; set; }

        public bool WorkingMorning { get; set; }
        public bool WorkingAfternoon { get; set; }
        public bool WorkingNight { get; set; }
        public bool WorkingDawn { get; set; }
        public bool WorkingBusiness { get; set; }

        [Column("SkillsCollection")]
        public string _skills { get; set; }

        [NotMapped]
        public string[] Skills
        {
            get => string.IsNullOrEmpty(_skills) ? new string[0] : _skills.Split(DELIMITER);
            set
            {
                _skills = string.Join($"{DELIMITER}", value);
            }
        }

        #endregion
    }
}
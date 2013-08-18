using System;
using System.Collections.Generic;

namespace K94Warriors.Models
{
    public class DogProfile
    {
        public DogProfile()
        {
            this.DogEvents = new List<DogEvent>();
            this.DogMedicalRecords = new List<DogMedicalRecord>();
            this.DogNotes = new List<DogNote>();
            this.DogSkills = new List<DogSkill>();
        }

        public int ProfileID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public Nullable<int> Age { get; set; }
        public string Color { get; set; }
        public Nullable<System.DateTime> PickedUpDate { get; set; }
        public bool IsFixed { get; set; }
        public Nullable<System.DateTime> GraduationDate { get; set; }
        public Nullable<int> WarriorID { get; set; }
        public System.DateTime CreatedTimeUTC { get; set; }
        public System.Guid CreatedByUserID { get; set; }
        public bool IsApproved { get; set; }
        public int LocationId { get; set; }
        public virtual ICollection<DogEvent> DogEvents { get; set; }
        public virtual ICollection<DogMedicalRecord> DogMedicalRecords { get; set; }
        public virtual ICollection<DogNote> DogNotes { get; set; }
        public virtual WarriorInfo WarriorInfo { get; set; }
        public virtual ICollection<DogSkill> DogSkills { get; set; }
        public virtual Location Location { get; set; }
    }
}

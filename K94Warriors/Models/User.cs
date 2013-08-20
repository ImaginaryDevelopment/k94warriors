using System;
using System.Collections.Generic;

namespace K94Warriors.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DisplayName { get; set; }
        public System.DateTime CreatedTimeUTC { get; set; }
        public string PhoneProvider { get; set; }
        public int UserTypeId { get; set; }
        public virtual ICollection<DogNote> DogNotes { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
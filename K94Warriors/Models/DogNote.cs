using System;
using System.Collections.Generic;

namespace K94Warriors.Models
{
    public class DogNote
    {
        public int NoteID { get; set; }
        public int DogProfileID { get; set; }
        public string Note { get; set; }
        public bool IsCritical { get; set; }
        public int NoteTypeId { get; set; }
        public virtual DogProfile DogProfile { get; set; }
        public virtual NoteType NoteType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.Entities
{
   public class Student
    {
        public int StudentID { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public ICollection<Contacts> Contacts{ get; set; }

    }
}

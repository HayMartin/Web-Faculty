using System;
using System.Collections.Generic;
using System.Text;
using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Faculty.Entities
{
   public class Contacts
    {
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }   

        public Student student { get; set; }
        public Teacher teacher { get; set; }




    }
}

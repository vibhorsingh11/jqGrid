using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Models
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StandardId { get; set; }
        public Nullable<int> RowVersions { get; set; }
    }
}
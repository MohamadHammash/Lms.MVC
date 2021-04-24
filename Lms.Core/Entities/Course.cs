﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.Entities
{
    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }


        // nav prop
        public ICollection<Student> Students { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacess.Model
{
    internal class Hold
    {
        private string _holdNavn;
        public string HoldNavn { get { return _holdNavn; } set { _holdNavn = value; } }
        private List<Student> _students;
        public List<Student> StudentsIHold { get { return _students; } }

        private int _holdId;
        public int HoldId { get { return _holdId; } set { _holdId = value; }








        }
    }
}

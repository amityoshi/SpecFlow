using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecFlowGettingStartedUI.Models
{
    public class Doctor
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Specialization;

        public string Specialization
        {
            get { return _Specialization; }
            set { _Specialization = value; }
        }
        private string _Location;

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClasses
{
    [Serializable]
    public class SimpleFIO
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public string Full
        {
            get { return Ext.GetFullFIO(this); }
        }

        public string Abbr
        {
            get { return Ext.GetAbbrFIO(this); }
        }
    }
}

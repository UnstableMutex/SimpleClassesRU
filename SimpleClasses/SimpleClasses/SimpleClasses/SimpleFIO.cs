using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClasses
{
    [Serializable]
    public class SimpleFIO : IReadOnlySimpleFIO
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
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

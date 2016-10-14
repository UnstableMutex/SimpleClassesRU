using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SimpleClasses
{
    class Ext
    {
        public static string GetFullFIO(SimpleFIO fio)
        {
            var res= fio.Surname + " " + fio.FirstName;
            if (!string.IsNullOrEmpty(fio.Patronymic))
            {
                res += " " + fio.Patronymic;
            }
            return res;
        }
        public static string GetAbbrFIO(SimpleFIO fio)
        {
            var res= fio.Surname + " " + fio.FirstName[0]+".";
            if (!string.IsNullOrEmpty(fio.Patronymic))
            {
                res += " " + fio.Patronymic[0]+".";
            }
            return res;
        }
    }
}

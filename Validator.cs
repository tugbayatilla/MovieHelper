using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace MovieHelper
{
    internal static class Validator
    {
        private static DateTime _currentDate = Convert.ToDateTime("16.09.2008 13:29:57", CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat);
            
        internal static void Check(Form that)
        {
            //if (_currentDate.AddDays(365) < DateTime.Now || _currentDate > DateTime.Now)
            //{
            //    MessageBox.Show("Expired.");
            //    that.Close();
            //}
        }
    }
}

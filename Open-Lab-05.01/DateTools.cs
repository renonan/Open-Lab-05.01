using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            double centuryint = year / 100;
            centuryint = Math.Ceiling((double)year / 100);
            int lastdigit = (Convert.ToInt32(centuryint) % 10);
            if (lastdigit == 1 && centuryint != 11)
            {
                string result = centuryint.ToString() + "st century";
                return result;
            }
            else if (lastdigit == 2 && centuryint != 12)
            {
                string result = centuryint.ToString() + "nd century";
                return result;

            }
            else if (lastdigit == 3 && centuryint != 13)
            {
                string result = centuryint.ToString() + "rd century";
                return result;
            }
            else
            {
                string result = centuryint.ToString() + "th century";
                return result;
            }
                

        }
    }
}

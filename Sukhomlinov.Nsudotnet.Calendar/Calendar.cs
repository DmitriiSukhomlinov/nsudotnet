using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Sukhomlinov.Nsudotnet.Calendar
{
    class Calendar {

        static int _daysInWeek = 7;

        static void Main() {
            Console.WriteLine("Введите дату");
            string inputString = Console.ReadLine();
            DateTime dateTime;
            bool parsed = DateTime.TryParse(inputString, out dateTime);

            if (!parsed) {
                Console.WriteLine("Неправильный формт даты");
                return;
            }

            int dayOfFirstWeek = dateTime.Day % 7;


            int firstDayOfMounthWeekDay = 
            switch (dateTime.DayOfWeek) {
                case DayOfWeek.Monday:

                    break;
                case DayOfWeek.Tuesday:

                    break;
                case DayOfWeek.Wednesday:

                    break;
                case DayOfWeek.Thursday:

                    break;
                case DayOfWeek.Friday:

                    break;
                case DayOfWeek.Saturday:

                    break;
                case DayOfWeek.Sunday:

                    break;
            }


            Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");



            int dayOfFirstWeek = 0;

        }
    }
}

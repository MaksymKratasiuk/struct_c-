using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_c_
{
    struct Birthday
    {
        private DateTime birthDate;
        private DateTime currentDate;

        public Birthday(DateTime date)
        {
            birthDate = date;
            currentDate = DateTime.Today;
        }

        public string GetWeekday()
        {
            return birthDate.ToString("dddd");
        }

        public string GetWeekdayInYear(int year)
        {
            DateTime birthdayInYear = new DateTime(year, birthDate.Month, birthDate.Day);
            return birthdayInYear.ToString("dddd");
        }

        public int GetDaysUntilBirthday()
        {
            DateTime currentYearBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
            if (currentYearBirthday < currentDate)
            {
                currentYearBirthday = new DateTime(currentDate.Year + 1, birthDate.Month, birthDate.Day);
            }
            TimeSpan timeSpan = currentYearBirthday - currentDate;
            return timeSpan.Days;
        }
    }
    internal class Task3
    {
        public static void task3()
        {
            // Оголошуємо змінну типу Birthday і ініціалізуємо її конструктором
            Birthday birthday = new Birthday(new DateTime(1990, 4, 1));

            // Отримуємо день тижня народження
            string weekday = birthday.GetWeekday();
            Console.WriteLine("День тижня народження: {0}", weekday);

            // Отримуємо день тижня народження у заданому році
            string weekdayInYear = birthday.GetWeekdayInYear(2025);
            Console.WriteLine("День тижня народження у 2025 році: {0}", weekdayInYear);

            // Отримуємо кількість днів до дня народження
            int daysUntilBirthday = birthday.GetDaysUntilBirthday();
            Console.WriteLine("Кількість днів до дня народження: {0}", daysUntilBirthday);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class DaysOfWeek : IPrinter
    {
        public void Print()
        {
            /*List<string> daysOfWeek = new List<string>() 
            { 
                "Понедельник", 
                "Вторник", 
                "Среда", 
                "Четверг", 
                "Пятница", 
                "Суббота", 
                "Воскресенье"
            };*/

            Console.WriteLine("День недели:");
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek);

        }
    }
}

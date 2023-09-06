using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CsLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oldLadies;
            int receptionTime = 10;
            int timePerMinute = 60;

            Console.Write("Введите количество старушек: ");
            oldLadies = Convert.ToInt32(Console.ReadLine());

            int allWaitingTimeInMinutes = oldLadies * receptionTime;
            int waitingTimeHours = allWaitingTimeInMinutes / timePerMinute;
            int waitingTimeMinutes = allWaitingTimeInMinutes % timePerMinute;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часа и {waitingTimeMinutes} минут");
            Console.WriteLine("fds");
            Console.WriteLine("dsdfsfds");


        }
    }
}
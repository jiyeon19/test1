
            int oldLadies;
            int receptionTime = 10;
            int timePerMinute = 60;

            Console.Write("Введите количество старушек: ");
            oldLadies = Convert.ToInt32(Console.ReadLine());

            int allWaitingTimeInMinutes = oldLadies * receptionTime;
            int waitingTimeHours = allWaitingTimeInMinutes / timePerMinute;
            int waitingTimeMinutes = allWaitingTimeInMinutes % timePerMinute;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часа и {waitingTimeMinutes} минут");
 
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExampleEvidentDrivenProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            // Attaching evidents 
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            //start ticking
            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");

            Console.ReadLine();

            //detach the evident 
            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // singaltime will give the exact time when that event was raised 
            // fff is down to miliseconds
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}

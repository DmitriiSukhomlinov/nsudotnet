using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhomlinov.Nsudotnet.NumberGuesser {
    class NumberGuesser {
        private static string[] _guessingHistory = new string[1000];
        private static string[] _sweapWords = new string[4] {
                "{0} плохой мальчик",
                "{0} очень плохой мальчик",
                "{0} очень очень плохой мальчик",
                "{0} заезжай за мной в семь"
            };

        static void Main(string[] args) {
            var startTime = DateTime.Now;
            Console.WriteLine("Напишите свое имя");
            string name = Console.ReadLine();
            int number = new System.Random().Next(0, 101);

            bool numberWasGuessed = false;
            int attemptsCount = 0;
            while (!numberWasGuessed) {
                Console.WriteLine(String.Format("{0}, угадайте число", name));
                string line = Console.ReadLine();
                if (line == "q") {
                    Console.WriteLine("Прошу прощения");
                    return;
                }
                int perspectiveNumber = -1;

                bool canParse = int.TryParse(line, out perspectiveNumber);

                if (!canParse) {
                    Console.WriteLine("Неправильная строка");
                    continue;
                }
                if (perspectiveNumber < 0 || perspectiveNumber > 100) {
                    Console.WriteLine("За пределами");
                    continue;
                }


                if (number > perspectiveNumber) {
                    Console.WriteLine("Загаданное число больше, чем ваше");
                    _guessingHistory[attemptsCount] = "Больше, чем нужно";
                } else if (number < perspectiveNumber) {
                    Console.WriteLine("Загаданное число меньше, чем ваше");
                    _guessingHistory[attemptsCount] = "Меньше, чем нужно";
                } else {
                    Console.WriteLine("Угадали!");
                    numberWasGuessed = true;
                }
                attemptsCount++;
                if (attemptsCount % 4 == 0 & !numberWasGuessed) {
                    Console.WriteLine(String.Format(_sweapWords[new Random().Next(0, 5)], name));
                }

            }

            Console.WriteLine(String.Format("Число было угадано за {0} попыток", attemptsCount));
            for(int i = 0; i < attemptsCount - 1; i++) {
                Console.WriteLine(String.Format("{0}. {1}", i + 1, _guessingHistory[i]));
            }
            Console.WriteLine(String.Format("{0}. Угадали", attemptsCount));
            Console.WriteLine(String.Format("На все про все ушло {0} минут", DateTime.Now.Subtract(startTime).Minutes));
        }
    }
}

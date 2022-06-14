using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уважаемый пользователь моего мегокалькулятора (Семёныч). Прошу c пониманием к нему отнестись. Введите первое число");

            bool Razlogenie2 = false;
            double PervoySchislo = 0;
            while (!Razlogenie2)
            {
                string Razlogenie1 = Console.ReadLine();
                Razlogenie2 = double.TryParse(Razlogenie1, out PervoySchislo);
                if (Razlogenie2 == false)
                {
                    Console.WriteLine("В введенном значении не записано число, попробуйте еще раз");
                }
            }    

            Console.WriteLine("Введите операцию, которую хотите произвести");
            char simvol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число, с помощью которого хотите пошаманить");
            bool Razlogenie4 = false;
            double VtoroeScheslo = 0;
            while (!Razlogenie4)
            {
                string Razlogenie3 = Console.ReadLine();
                Razlogenie4 = double.TryParse(Razlogenie3, out VtoroeScheslo);
                if (Razlogenie4 == false)
                {
                    Console.WriteLine("В введенном значении не записано число, попробуйте еще раз");
                }
            }


            switch (simvol)
            {
                case '+':
                    double Slogenye = (PervoySchislo + VtoroeScheslo);
                    Console.WriteLine(Slogenye);
                    break;
                case '-':
                    double Vichetanie = (PervoySchislo - VtoroeScheslo);
                    Console.WriteLine(Vichetanie);
                    break;
                case '*':
                    double Ymnoshenie = (PervoySchislo * VtoroeScheslo);
                    Console.WriteLine(Ymnoshenie);
                    break;
                case '/':
                    {
                        if (VtoroeScheslo == 0)
                        {
                            Console.WriteLine("ЭЭэ нэ брат, на ноль  число делить нельзя");
                            break;
                        }
                        double Delenie = (PervoySchislo / VtoroeScheslo);
                        Console.WriteLine(Delenie);
                    }
                    break;
                default:
                    Console.WriteLine("Сори, бротишка, я пока умею делать только умножение, деление, выечатение да сложение. Если захочешь больше, то это только с практикой");
                    break;
            }

        }
    }
}

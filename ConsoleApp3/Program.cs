using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уважаемый пользователь моего мегокалькулятора (Семёныч). Прошу c пониманием к нему отнестись. Введите первое число");
            string a = Console.ReadLine();
            Console.WriteLine("Введите операцию, которую хотите произвести");
            string b = Console.ReadLine();
            Console.WriteLine("Введите второе число, с помощью которого хотите пошаманить");
            string c = Console.ReadLine();

            double PervoySchislo = Convert.ToDouble(a);
            double VtoroeScheslo = Convert.ToDouble(c);
            char simvol = Convert.ToChar(b);

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
                        if (VtoroeScheslo <= 0)
                        {
                            Console.WriteLine("ЭЭэ нэ брат, на ноль или отрицательное число делить нельзя");
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

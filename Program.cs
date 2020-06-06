using System;
using System.IO;
//создать 2 класс
//10.Спроектировать иерархию классов: класс функция
//    от одной переменной и его наследники: синус и его производная, 
//    косинус и его производная.
//    Определить в базовом классе и переопределить в наследниках методы вычисления значения функции для заданного значения переменной.
//    Элементы-данные объявляются в базовом классе, а инициализируются в наследниках (элементы данные: значение переменной).
namespace LR61OP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SeeTask();
            double x = 0;
            Function[] argument = new Function[4];//level b?
            int choice=0, exit = 0;
            do
            {
                Console.WriteLine("Press 1 to see the task again");
                Console.WriteLine("Press 2 to Input New X. Current X value is: "+ x);
                Console.WriteLine("Press 3 to get Sinus");
                Console.WriteLine("Press 4 to get Derivative from Sinus");
                Console.WriteLine("Press 5 to get Cosinus");
                Console.WriteLine("Press 6 to get Derivative from Cosinus");
                Console.WriteLine("Press any other number to Quit");
                try { choice = Convert.ToInt32(Console.ReadLine()); }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format of choice, input Integers");
                }
               // choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        SeeTask();
                        break;
                    case 2:
                        Console.WriteLine("Please input X in radians:");
                        x = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 3:
                        argument[0] = new Sin(x);

                        Console.WriteLine("Sinus for x = " + x + " is : " + argument[0].Func(x));

                        break;
                    case 4:
                        argument[1] = new DerSin(x);
                        Console.WriteLine("Derivative of Sinus for x = " + x + " is : "+argument[1].Func(x));

                        break;
                    case 5:
                        argument[2] = new Cos(x);
                        Console.WriteLine("Cosinus for x = " + x + " is : "+argument[2].Func(x));

                        break;
                    case 6:
                        argument[3] = new DerCos(x);
                        Console.WriteLine("Derivative of Cosinus for x = " + x + " is : " + argument[3].Func(x));

                        break;
                    default:
                        exit = 1;
                        Environment.Exit(0);
                        break;
                }
            } while (exit != 1);

        }

 static public void SeeTask()
        {
            Console.WriteLine("\nKariavka Dariia");
            Console.WriteLine("10 variant, level B");
            Console.WriteLine("Спроектировать иерархию классов: класс функция");
            Console.WriteLine("от одной переменной и его наследники: синус и его производная,  косинус и его производная.");
            Console.WriteLine("Определить в базовом классе и переопределить в наследниках методы вычисления значения функции для заданного" +"\n"+
                "значения переменной.");
            Console.WriteLine(" Элементы-данные объявляются в базовом классе, а инициализируются в наследниках (элементы данные: значение переменной).\n");
        }
    }



    abstract public class Function
    {
        protected double X; //declaration
       public abstract double Func(double X);
    }

    public class Sin : Function {
       public Sin(double X) {//init
            this.X = X;
        }
        public override double Func(double X)
        {
            double DoSin = Math.Sin(X);
            return DoSin;
        }
   

    }
    public class DerSin : Function
    {
        public DerSin(double X)//init
        {
            this.X = X;
        }
        public override double Func(double X)
        {
            double DerSin = Math.Cos(X);//sin's derivative from X is cosinus
            return DerSin;
        }


    }

    public class Cos : Function
    {
        public Cos(double X)//init
        {
            this.X = X;
        }
        public override double Func(double X)
        {
            double DoCos = Math.Cos(X);
            return DoCos;

        }

    }
    public class DerCos : Function
    {
        public DerCos(double X)//init
        {
            this.X = X;
        }
        public override double Func(double X)
        {
            double DerCos = -(Math.Sin(X));//cos' derivative is minus sinus
            return DerCos;
        }


    }
}






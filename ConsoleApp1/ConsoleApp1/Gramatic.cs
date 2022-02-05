using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace ConsoleApp1
{
     class Gramatic
    {

        static void Main(string[] args)
        {
            
            #region Codigo de saludo
            /*
            string hello = "Hola";  
            */            

            #endregion

            #region Types

            /*
            //0 a 255
            byte v1 = 200;
            Console.WriteLine(" Valor almacenado en el tipo byte: " + v1);
            
            //-128 a 127
            sbyte v2 = -100;
            Console.WriteLine("Valor almacenado en el tipo sbyte: " + v2);
            
            //-32768 a 32767
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en el tipo short" + v3);
            
            //0 a 65535
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en el tipo ushort" + v4);
            */


            #endregion

            #region  Variables

            /*string name = Console.ReadLine();

            Console.WriteLine(name);
            */

            
            /*
            string name = default(string);
            Console.WriteLine(name);
            */

            
            /*
            DateTime? fecha = null;
            
            Console.WriteLine(fecha?.Day);
            */

            /*
            var variable = new DateTime();
            Console.WriteLine(variable);
            */

            #endregion

            #region Nomenclaturas
            
            // Buenas prácticas en Csharp

            /*
            var estoEsUnaVariablePublica = "xd";

            private static string _siempreElMismoValor = "as";

            public int AditionOfTwoNumbers(int a, int b)
            {
                return a + b;
            }*/
            

            #endregion

            #region Constants
            /*
            public const string NAME = "Daniel";
            public const int IDTEACH = 1;
        */
            #endregion

            #region If and else
            /*
            int suma = 3 + 7;

            if (suma == 6)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (suma.GetType() != typeof(decimal) )
            {
                Console.WriteLine("No son del mismo type");
            }
            */
            #endregion

            #region Switch Case
            /*
            int number = 2;

            switch (number)
            {
                case 1: Console.WriteLine(1);
                    break;
                case 2: Console.WriteLine(2);
                    break;
                case 3: Console.WriteLine(3);
                    break;
                default: Console.WriteLine("Other");
                    break;
            }
            */
            #endregion

            #region Do while
            /*
            int index = 0;
            
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index < 100*3 );
            */
            #endregion

            #region While
            /*
            int index = 0;

            while ( index <= 10)
            {
                Console.WriteLine("*");
                index++;
            }
            */


            #endregion

            #region For
            /*
            int number = 10;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region ForEach
            /*
            var listOfNumbers = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

            var listOfPersons = new List<Person>();
            
            listOfPersons.Add(new Person(){ Age = 20, Name = "Daniel", SurName = "Castillo"});
            listOfPersons.Add(new Person(){ Age = 18, Name = "Julieth", SurName = "Segura"});
            listOfPersons.Add(new Person(){ Age = 25, Name = "Michelle", SurName = "Castillo"});

            foreach ( var Person in listOfPersons)
            {
                Console.WriteLine(Person.Age + " " + Person.Name + " "+Person.SurName);
            }
            */
            #endregion

            #region Operators

            //  Existen demasiados operadores, estudiarlos más a fondo en notion

            #endregion

            #region Console simplification
            // Is most important the add el static in the import
            //WriteLine("Works");

            #endregion

            #region Read args
            /*
            WriteLine("Existen "+ args.Length + " elementos");
            */
            #endregion

            #region Arrays
            /*
            int[] arrayOfIntegers = new int[5];
            int[,] arrayOfIntegersTwoDimensions = new int[2, 2];
            int[][] arrayOfIntegersEscalonates = new int[5][];
            arrayOfIntegersEscalonates[0] = new int[4] {1, 2, 3, 4};
            arrayOfIntegersEscalonates[1] = new int[2] {1,  3 };
            */
            

            #endregion

            #region Castings or Casts
            /*
            var cadena = "Hola";
            int number = 7;

            cadena = number.ToString();
            
            //Implicits
            int numberInteger = 123;
            long numberLong = numberInteger;

            //Explicits
            double numberDouble = 12.56;
            int numberIntegerDouble = (int) numberDouble;
            double valueDouble = 8.45;
            int valueInteger = ToInt32(valueDouble);
            Convert.ToInt32(valueDouble);

            //Define for the user

            //With class of assistance
            */
            #endregion

            #region Excercises

            /*/
             /Excercise 1
            int numberOne = 1, numberTwo = 2, summ = numberOne + numberTwo;
            WriteLine(summ);
            
            
            //Excercise 2
            int numberOne = ToInt32( ReadLine() );
            int numberTwo = ToInt32(ReadLine());
            if (numberOne > numberTwo)
            {
                WriteLine("El número mayor es:" + numberOne);
            }
            else
            {
                WriteLine("El número mayor es:" + numberTwo);
            }
            */
            
            //Excercise 3 
            /*
            string nameDay = ReadLine();
            if (nameDay.Trim() == "sabado" || nameDay.Trim() == "domingo")
            {
                WriteLine("Es fin de semana");
            }
            else
            {
                WriteLine("No es fin de semana");
            }
            */
            //Excercise 4
            /*
            WriteLine("Digite el precio del producto");
            int priceSale = ToInt32(ReadLine());
            Clear();
            WriteLine("Efectivo o tarjeta");
            string methodToPay = ReadLine();
            if (methodToPay.Trim() == "efectivo")
            {
                WriteLine("Pago con efectivo");
            }
            else
            {
                WriteLine("Pago con tarjeta");
            }
            */
            //Excercise 5
            /*
            for (int i = 1; i < 101; i++)
            {
                WriteLine(i);
            }
            */
            //Excersise 6
            /*
            int count = 1;
            while (count < 101)
            {
                WriteLine(count);
                count++;
            }
            */
            //Excersice 7
            /*
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    WriteLine(i);
                }
            }
            */
            // Excersice 8
            /*
            for (int i = 1; i < 101; i++)
            {
                if (i%3==0)
                {
                    WriteLine(i);
                }
            }
            */
            //Excersice 9
            /*
            int[] numbers = new int[99];
            for (int i = 0; i < 99; i++)
            {
                numbers[i] = ToInt32(ReadLine());
            }

            for (int i = 0; i < 99; i++)
            {
                WriteLine(numbers[i]);
            }
             */
            // Excersice 10
            /*
            int[] numbers = new int[10];
            int sum = 0, rest = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ToInt32(ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
                else
                {
                    rest = rest - numbers[i];
                }
            }
            
            WriteLine("suma: "+sum+"  resta: "+rest);
            */
            //Excersice 11
            /*
            WriteLine("Digite un numero del 1 al 7: \n");
            int dayOfWeek = ToInt32(ReadLine());
            switch (dayOfWeek)
            {
                case 1: WriteLine("Lunes");
                    break;
                case 2:WriteLine("Martes");
                    break;
                case 3:WriteLine("Miercoles");
                    break;
                case 4:WriteLine("Jueves");
                    break;
                case 5:WriteLine("Viernes");
                    break;
                case 6:WriteLine("Sábado");
                    break;
                case 7:WriteLine("Domingo");
                    break;
                default: WriteLine("No existe este día ");
                    break;
                
            }
            */
            //Ejercicio 12
            /*
            int number = ToInt32(ReadLine());
            if (number > 0 && number < 1001)
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum = sum + i;
                }
                decimal media = sum / number;
                WriteLine("Suma: "+ sum + " La media es: " + media);
            }
            else
            {
                WriteLine("Número fuera de rango");
            }
            */
            // Ejercicio 13
            /*
            int number = ToInt32(ReadLine());
            if ((number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0 && number % 9 != 0)
                || number==2 || number == 3 || number==5 || number==7)
            {
                WriteLine("Es primo");
            }
            else
            {
                WriteLine("no es primo");
            }
            */
            //Ejercicio 14
            /*
            int number = ToInt32(ReadLine());
            int c = 0;
            for (int i = 0; 0 < number; i++)
            {
                number = number / 10;
                c++;
            }
            WriteLine("El numero tiene: "+c+" cifras");
            */


            #endregion
        }

    }

     public class Person
     {
         public string Name { get; set; }
         public string SurName { get; set; }
         public int Age { get; set; }
     }
}
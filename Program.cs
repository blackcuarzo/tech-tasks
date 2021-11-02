using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


namespace tech_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10; int b = 3;
            int[] encontrarMultiplos(int a, int n){
                List <int> arrayList = new List<int>();
                int maxInt = n/a;
                for (int i = 1; i < maxInt + 1; i++)
                {
                    arrayList.Add( a * i );
                }
                return arrayList.ToArray();
                //return arrayList.toArray
            }
            int sumofMultiples(int a, int b, int n){
                int [] arrayA = encontrarMultiplos(a,n);
                int [] arrayB = encontrarMultiplos(b,n);
                int [] combined = arrayA.Concat(arrayB).ToArray();
                int [] filtered = combined.Distinct().ToArray();
                return filtered.Sum();
            }
            int encontrarDigito(int inicio){
                for (int i = inicio;;i++){
                    if(evaluarSuma(i)) {
                        return i;
                    }
                }
            }
            bool evaluarSuma(int number){
                int num = number;
                List <int> listOfInts = new List<int>();
                while(num>0){
                    listOfInts.Add((int)Math.Pow((num%10),5));
                    num /= 10;
                }
                return (listOfInts.ToArray().Sum() == number);
            }
            void pantallaInicial(){
                Console.WriteLine("* * * Challenge C# Junior Developer * * *\n\n");
                Console.WriteLine("Select an option: \n");
                Console.WriteLine("1. Fin Multiples of 3 or 5");
                Console.WriteLine("2. Power Number");
                Console.WriteLine("3. Make Matriz and sum diagonals");
                Console.WriteLine("4. Make Program to access Database");
                Console.WriteLine("Option:");
                switch(Console.ReadLine())
                {
                    case "1":
                        while(true){
                            Console.Clear();
                            Console.WriteLine("Enter n:");
                            string input = Console.ReadLine();
                            int number;
                            bool success = Int32.TryParse(input,out number);
                            if (success){
                                Console.WriteLine("The sum of multiples equals to  ==> " + sumofMultiples(3,5,number).ToString());
                                break;
                            }else{
                                Console.WriteLine("Error interno de parsing, intente nuevamente");
                            }
                        }
                        break;
                    case "2":
                        while(true){
                            Console.Clear();
                            Console.WriteLine("Enter starting search number:");
                            string input = Console.ReadLine();
                            int number;
                            bool success = Int32.TryParse(input,out number);
                            if (success){
                                Console.WriteLine("We found a number!!, its ==> " + encontrarDigito(number).ToString());
                                break;
                            }else{
                                Console.WriteLine("Error interno de parsing, intente nuevamente");
                            }
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                        
                }

            }
            pantallaInicial();
            
        }

    }
}

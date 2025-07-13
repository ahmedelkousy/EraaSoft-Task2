using System.Xml.Serialization;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 2, 8, 4, 3, 5, 6, 8, 32, 56 };

            Console.WriteLine($"available options:\n" +
                $"=======================================\n" +
                $"|\t1- min value\n" +
                $"|\t2- max value\n" +
                $"|\t3- average\n" +
                $"|\t4- sorting\n" +
                $"|\t5- print the list\n" +
                $"|\t6- add numbers to the list\n" +
                $"|\t7- clear the list\n" +
                $"|\t8- quit\n" +
                $"=======================================\n");
            int op = 0;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Chose one Option");
                Console.WriteLine("| 1-Min | 2-Max | 3-Avrg | 4-Sort | 5-Print | 6-Add | 7-Empty | 8-Quit |");
                Console.Write("==> ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        MinValue(list);
                        break;
                    case 2:
                        MaxValue(list);
                        break;
                    case 3:
                        avergValue(list);
                        break;
                    case 4:
                        PrintList(list);
                        break;
                    case 5:
                        SortingList(list);
                        break;
                    case 6:
                        addNum(list);
                        break;
                    case 7:
                        list.Clear();
                        Console.WriteLine("now the list is Empty ");
                        Console.WriteLine("----------------------");
                        break;
                    case 8:
                        Console.WriteLine("Quitting the program");
                        Console.WriteLine("see you later");
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("invalid choice, please try again");
                        break;
                }

            } while (op != 8);

        }


        //=========================================================================//
        //================================ Methods ================================//
        //=========================================================================//

        //-----------------------------------------------------------------------------//
        // Method (1) calculate the minimum value in a list
        static void MinValue(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            int min = list[0];
            Console.WriteLine("-------------------------------");
            Console.WriteLine("the minimum value is " + min);
            Console.WriteLine("-------------------------------");
        }

        //-----------------------------------------------------------------------------//
        // Method (2) calculate the maximum value in a list
        static void MaxValue(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            int max = list[0];
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("the max value in the list is " + max);
            Console.WriteLine("-------------------------------------");
        }

        //-----------------------------------------------------------------------------//
        // Method (3) calculate the average value in a list
        static void avergValue(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            int avrg = sum / list.Count;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("the list average value is " + avrg);
            Console.WriteLine("-------------------------------");
        }

        //-----------------------------------------------------------------------------//
        // Method (4) print the list
        static void PrintList(List<int> list)
        {
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------");

        }


        //-----------------------------------------------------------------------------//
        // Method (5) sort the list in ascending 
        static void SortingList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------");
        }

        //---------------------------------------------------------------------//
        // method (6) add number to the list
        static void addNum(List<int> list)
        {
            Console.WriteLine("what is your number to add to the list");
            int num = Convert.ToInt32(Console.ReadLine());
            list.Add(num);
            Console.WriteLine("the " + num + " has added to the list");
            Console.WriteLine("your list now is:");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-------------------------------");

        }





    }
}

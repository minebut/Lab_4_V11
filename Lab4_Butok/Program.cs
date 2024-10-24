/*Варіант №11. Створити клас "набір доміно", що включає закритий масив
елементів класу "доміно". У доміно зберігаються два числа. Забезпечити
можливість виведення доміно за номером, виведення всього набору доміно,
перемішування доміно і видача доміно по 7 штук у випадковому порядку.
Набори доміно можна складати і порівнювати.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Butok
{

    namespace Lab4_Butok
    {
        class Program
        {
            static List<DominoSet> dominoSets = new List<DominoSet>();//

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Create new set ");
                    Console.WriteLine("2. Enter set ");
                    Console.WriteLine("3. Compare sets ");
                    Console.WriteLine("4. Delete set ");
                    Console.WriteLine("5. Shaffle set ");
                    Console.WriteLine("6. Enter 7 rendom element set ");
                    Console.WriteLine("0. Exite ");

                    Console.Write("Option ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateSet();
                            break;
                        case 2:
                            ShowSet();
                            break;
                        case 3:
                            CompareSets();
                            break;
                        case 4:
                            DeleteSet();
                            break;
                        case 5:
                            ShuffleSet();
                            break;
                        case 6:
                            ShowRandomSet();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine(" Wrong choise ");
                            break;
                    }
                }
            }

            static void CreateSet()
            {
                Console.Clear();
                Console.Write("Enter name set ");
                string name = Console.ReadLine();
                dominoSets.Add(new DominoSet(name));
                Console.WriteLine($"Set'{name}' created");
            }

            static void ShowAvailableSets()//показує доступні набори
            {
                Console.Clear();
                if (dominoSets.Count == 0)
                {
                    Console.WriteLine("There are no kits available");
                    return;
                }

                Console.WriteLine("Available sets");
                for (int i = 0; i < dominoSets.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {dominoSets[i].Name}");
                }
            }


            static void ShowSet()//показує набір
            {
                Console.Clear();
                ShowAvailableSets();

                Console.Write("Enter name set");
                int setIndex = int.Parse(Console.ReadLine()) - 1;

                if (setIndex >= 0 && setIndex < dominoSets.Count)
                {
                    dominoSets[setIndex].ShowSet();
                }
                else
                {
                    Console.WriteLine("Available sets");
                }
            }

            static void CompareSets()//порівнює набори та виводить їх
            {
                if (dominoSets.Count < 2)
                {
                    Console.WriteLine("A minimum of 2 sets is required for comparison");
                    return;
                }
                ShowAvailableSets();

                Console.Write("Enter first set ");
                int firstSetIndex = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Enter second set ");
                int secondSetIndex = int.Parse(Console.ReadLine()) - 1;
                
                var firstSet = dominoSets[firstSetIndex];
                var secondSet = dominoSets[secondSetIndex];

                Console.WriteLine("First set");
                firstSet.ShowSet();

                Console.WriteLine("Second set");
                secondSet.ShowSet();

            }
            
            //static void CompareSets()
            //{
            //    if (dominoSets.Count < 2)
            //    {
            //        Console.WriteLine("Для порівняння потрібно мінімум 2 набори.");
            //        return;
            //    }

            //    ShowAvailableSets();

            //    Console.Write("Виберіть перший набір: ");
            //    int firstSetIndex = int.Parse(Console.ReadLine()) - 1;

            //    Console.Write("Виберіть другий набір: ");
            //    int secondSetIndex = int.Parse(Console.ReadLine()) - 1;

            //    if (firstSetIndex >= 0 && firstSetIndex < dominoSets.Count &&
            //        secondSetIndex >= 0 && secondSetIndex < dominoSets.Count)
            //    {
            //        var firstSet = dominoSets[firstSetIndex];
            //        var secondSet = dominoSets[secondSetIndex];


            //    }
            //    else
            //    {
            //        Console.WriteLine("Набір не знайдений.");
            //    }
            //}

            static void DeleteSet()//видаляє набір
            {
                Console.Clear();

                ShowAvailableSets();

                Console.Write("Enter the set number to delete ");
                int setIndex = int.Parse(Console.ReadLine()) - 1;

                if (setIndex >= 0 && setIndex < dominoSets.Count)
                {
                    string name = dominoSets[setIndex].Name;
                    dominoSets.RemoveAt(setIndex);
                    Console.WriteLine($"Set '{name}' deleted.");
                }
                else
                {
                    Console.WriteLine("Set not found.");
                }
            }

            static void ShuffleSet()//перемішує набір
            {
                Console.Clear();
                ShowAvailableSets();

                Console.Write("Enter the set number to shuffle: ");
                int setIndex = int.Parse(Console.ReadLine()) - 1;

                if (setIndex >= 0 && setIndex < dominoSets.Count)
                {
                    dominoSets[setIndex].Shuffle();
                    Console.WriteLine($"Set '{dominoSets[setIndex].Name}' shuffled.");
                }
                else
                {
                    Console.WriteLine("Set not found.");
                }
            }

            static void ShowRandomSet()//показує випадковий набір
            {
                Console.Clear();
                ShowAvailableSets();

                Console.Write("Enter the number of the set to draw 7 random dominoes: ");
                int setIndex = int.Parse(Console.ReadLine()) - 1;

                if (setIndex >= 0 && setIndex < dominoSets.Count)
                {
                    dominoSets[setIndex].ShowRandomSet();
                }
                else
                {
                    Console.WriteLine("Set not found.");
                }
            }
        }
    }
}


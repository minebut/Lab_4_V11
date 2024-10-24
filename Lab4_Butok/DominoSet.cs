using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Butok
{

    namespace Lab4_Butok
    {
        class DominoSet
        {
            static Random rand = new Random();

            private List<Domino> dominoes;

            public string Name { get; private set; }//назва сету

            public DominoSet(string name)
            {
                Name = name;
                dominoes = new List<Domino>();
                GenerateFullSet();
            }

            private void GenerateFullSet()//генерація сету
            {
                for (int i = 0; i <= 6; i++)
                {
                    for (int j = i; j <= 6; j++)
                    {
                        dominoes.Add(new Domino(i, j));
                    }
                }
            }

            public void ShowSet()//виведення сету 
            {

                for (int i = 0; i < dominoes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {dominoes[i]}");
                }

            }

            public void Shuffle()//перемішування
            {
                Random rnd = new Random();
                for (int i = dominoes.Count - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = dominoes[i];
                    dominoes[i] = dominoes[j];
                    dominoes[j] = temp;
                }
                Console.WriteLine("Set shuffled");
            }

            public void ShowRandomSet()//створення та виведення 7 випадкових доміно
            {

                List<Domino> randomSet = new List<Domino>();
                for (int i = 0; i < 7; i++)
                {
                    int index = rand.Next(dominoes.Count);
                    randomSet.Add(dominoes[index]);
                }

                Console.WriteLine("Random 7 elements");
                foreach (var domino in randomSet)
                {
                    Console.WriteLine(domino);
                }
            }

            
        }
    }
}

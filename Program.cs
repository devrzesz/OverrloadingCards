using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollectionLearning
{
    class Program
    {
        static List<int> MyList = new List<int>();

        static List<InnaKlasa> listaZKlasy;

        static KolejnaKlasa kolejnaKlasa;

        static void Main(string[] args)
        {
            //FillList();
            //FiltrTheList();
            InitializationClass();
            FillTheClass();
            // SortTheListAndPrint();
            foreach (InnaKlasa item in kolejnaKlasa)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void SortTheListAndPrint()
        {
            foreach (var klasa in listaZKlasy)
                Console.WriteLine(klasa);

            InnaKlasa.Sort = WayOfSort.ByName;
            listaZKlasy.Sort();
            Console.WriteLine();

            InnaKlasa.Sort = WayOfSort.ByNumber;
            listaZKlasy.Sort();
            Console.WriteLine();

            foreach (var klasa in listaZKlasy)
                Console.WriteLine(klasa);

        }

        private static void InitializationClass()
        {
            listaZKlasy = new List<InnaKlasa>();
            kolejnaKlasa = new KolejnaKlasa();
        }

        private static void FillTheClass()
        {
            listaZKlasy.Add(new InnaKlasa { Name = "zwa", Number = 13 });
            listaZKlasy.Add(new InnaKlasa { Name = "Mazwxa", Number = 3 });
            listaZKlasy.Add(new InnaKlasa { Name = "Aazwa", Number = 44 });
            listaZKlasy.Add(new InnaKlasa { Name = "Aazwaaa", Number = 6 });

        }

        static void FillList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }

        private static void FiltrTheList()
        {
            foreach (int n in Filter())
            {
                Console.WriteLine(n.ToString());
            }
        }

        static IEnumerable<int> Filter()
        {

            foreach (int i in MyList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }

        }

    }

    class KolejnaKlasa:IEnumerable
    {
        public List<InnaKlasa> ListaStworzonaZInnejKlasy { get; set; }

        public KolejnaKlasa()
        {
            ListaStworzonaZInnejKlasy = new List<InnaKlasa>();
            ListaStworzonaZInnejKlasy.Add(new InnaKlasa { Name = "Aaaa", Number = 1 });
            ListaStworzonaZInnejKlasy.Add(new InnaKlasa { Name = "Baaa", Number = 3 });
            ListaStworzonaZInnejKlasy.Add(new InnaKlasa { Name = "Caaa", Number = 2 });
            ListaStworzonaZInnejKlasy.Add(new InnaKlasa { Name = "Daaa", Number = 4 });
        }

        public IEnumerator GetEnumerator()
        {
            return ListaStworzonaZInnejKlasy.GetEnumerator();
        }
    }

    class InnaKlasa : IComparable<InnaKlasa>
    {
        public string Name { get; set; }
        public int Number { get; set; }
        static public WayOfSort Sort { get; set; }

        public int CompareTo(InnaKlasa obj)
        {
            if (Sort == WayOfSort.ByNumber)
            {
                if (this.Number > obj.Number)
                    return 1;
                if (this.Number < obj.Number)
                    return -1;
            }
            else
            {
                if (this.Name.Length == obj.Name.Length)
                {
                    for (int i = 0; i < this.Name.Length; i++)
                    {
                        if (this.Name[i] > obj.Name[i])
                            return 1;
                        if (this.Name[i] < obj.Name[i])
                            return -1;
                    }
                }

                if (this.Name.Length > obj.Name.Length)
                {
                    return 1;

                }
                else if (this.Name.Length < obj.Name.Length)
                {
                    return -1;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Number}. {Name}";
        }
    }

    enum WayOfSort
    {
        ByName,
        ByNumber,
    }
}
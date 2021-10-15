using System;

namespace _01
{


    class Film
    {


        public string name = "Большой Лебовски";
        public string director = "Коэн И., Коэн Дж.";
        public int year = 1998;
        public string type = "К";
        public void Print()
        {
            Console.WriteLine("| " + name + "   |" + director + " |" + year + " " + "  |" + type);
        }
    }

    class Film2
    {


        public string name = "Геркулес";
        public string director = "Маскер Дж. ";
        public int year = 1997;
        public string powtype = "А";
        public void Print()
        {
            Console.WriteLine("| " + name + "     |" + director + "     |" + year + "    |" + type);
        }

        class Film3
        {


            public string name = "Ноттинг-хилл";
            public string director = "Мишелл Р";
            public int year = 1999;
            public string type = "М";
            public void Print()
            {
                Console.WriteLine("| " + name + "      |" + director + "      |" + year + "   |" + type);
            }

            class MainClass
            {
                public static void Main(string[] args)
                {
                    Console.WriteLine("Кинопродукция");
                    Console.WriteLine("| Фильм | Режиссер | Год выпуска | Тип | ");
                    Film A = new Film();
                    A.Print();
                    Film2 B = new Film2();
                    B.Print();
                    Film3 C = new Film3();
                    C.Print();
                    Console.WriteLine("К – комедия  М – мелодрама А – мультфильм");
                    Console.ReadKey();
                }





            }

        }
    }
}

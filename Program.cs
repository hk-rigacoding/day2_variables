using System;

namespace day2_variables
{

    //sagatave, taisīsim dublikātus
    //<class> <nosaukums>
    class Lappuses
    {
        //[redzamība, noklusētā = private] <tips> <nosaukums>;
        //redzamība :
        //private : piekļuve klases robežās
        //public : piekļuve no citām klasēm

        private string autors;
        public static int svars;

        //inicializāciju
        public Lappuses(string param1, int param2)
        {
            autors = param1;
            svars = param2;
            Console.WriteLine(svars);
        }




        //[redzamība] <tips> <nosaukums>;
        public void Set_svars(int param2)
        {
            svars = param2;
        }
        public int Get_svars()
        {
           return svars;
        }

        public string Get_autors()
        {
            return autors;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            //jauns objekts
            Lappuses lappuse = new Lappuses("J.Rainis", 1);
            Lappuses lappuse1 = new Lappuses("J.Rainis1", 2);
            Lappuses lappuse2 = new Lappuses("J.Rainis2", 3);
            Lappuses lappuse3 = new Lappuses("J.Rainis3", 4);

            lappuse.Set_svars(45);

            int sv0 = Lappuses.svars;

            int rez = lappuse.Get_svars();



            Lappuses.svars = 5;

            Console.WriteLine(lappuse.Get_svars());
            Console.WriteLine(lappuse1.Get_svars());
            Console.WriteLine(lappuse2.Get_svars());
            Console.WriteLine(lappuse3.Get_svars());


            //Lappuses.Set_svars(5);


            /*
            lappuse.Set_svars(0);
            lappuse1.Set_svars(0);
            lappuse2.Set_svars(0);
            lappuse3.Set_svars(0);
            */



            Console.WriteLine("Hello World!");
        }
    }
}

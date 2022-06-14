using System;

namespace Badetidssystemet22
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreds k = new Kreds("1", "A1", "Landsvej 8", 13);
            Console.WriteLine(k.ToString());
            Kreds k1 = new Kreds("2", "B1", "Landsvej 2", 19);

            try
            {
                Badetidsperiode b = new Badetidsperiode(" Yes", " No", new DateTime(2022, 6, 14, 08, 00, 00), new DateTime(2022, 6, 14, 10, 00, 00), DayOfWeek.Tuesday);
                Console.WriteLine(b.ToString());

                Badetidsperiode b1 = new Badetidsperiode("No", "Yes", new DateTime(2022, 6, 15, 19, 00, 00), new DateTime(2022, 6, 15, 21, 00, 00), DayOfWeek.Wednesday);

                //add og delete metoder
                b1.AddKreds(k1);
                //b1.DeleteKreds("");
                Console.WriteLine();
                b1.AddKreds(k);
                Console.WriteLine(k1);
                Console.WriteLine(b1);
                
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

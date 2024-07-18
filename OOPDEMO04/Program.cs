using System.Text;

namespace OOPDEMO04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3]; // { 0, 0, 0 }

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); 
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); 

            //Arr02 = Arr01; 

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); 
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); 

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); 
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); 

            //Arr02[0] = 100;

            //Console.WriteLine("Arr02[0] = 100");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); 
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); 
            //------------------------------------------------------------------------------------
            //int[] Arr01 = { 10, 20, 30 };
            //int[] Arr02 = (int[])Arr01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC Of Arr01 = {Arr01.GetHashCode()}"); 
            //Console.WriteLine($"HC Of Arr02 = {Arr02.GetHashCode()}"); 
            //Console.WriteLine($"Arr01 [0] = {Arr01[0]}"); 
            //Console.WriteLine($"Arr02 [0] = {Arr02[0]}"); 
            //Arr01[0] = 100;
            //Console.WriteLine("After Arr01 [0] = 100");
            //Console.WriteLine($"Arr01 [0] = {Arr01[0]}"); 
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); 

            //-------------------------------------------------------------------------------------

            //string[] Names01 = { "Omar" };
            //string[] Names02 = new string[1]; 

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); 

            //Names02 = Names01; 

            //Console.WriteLine("After Shallow Copy ");

            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); 
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}");
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 
            //Names02[0] = "Aya";
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 

            //Names02 = (string[])Names01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC Of Names01 = {Names01.GetHashCode()}"); 
            //Console.WriteLine($"HC Of Names02 = {Names02.GetHashCode()}"); 
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Omar
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); // Omar
            //Names02[0] = "Aya";
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); // Omar
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); //Aya

            //---------------------------------------------------------------------------

            //StringBuilder[] Names01 = new StringBuilder[1];
            //Names01[0] = new StringBuilder("Omar");
            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"Name01 HC = {Names01.GetHashCode()}"); 
            //Console.WriteLine($"Name02 HC = {Names02.GetHashCode()}"); 
            //Names02 = Names01; 
            //Console.WriteLine("Name02 = Names01");
            //Console.WriteLine($"Name01 HC = {Names01.GetHashCode()}"); 
            //Console.WriteLine($"Name02 HC = {Names02.GetHashCode()}"); 
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 
            //Names02[0].Append(" Amr");
            //Console.WriteLine("Names02[0].Append(\" Amr\");");
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 



            //Names02 = (StringBuilder[]) Names01.Clone(); 
                                                         
            //Console.WriteLine("Names02 = (StringBuilder()) Names01.Clone();");
            //Console.WriteLine($"Name01 HC = {Names01.GetHashCode()}"); 
            //Console.WriteLine($"Name02 HC = {Names02.GetHashCode()}"); 
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 
            //Names02[0].Append(" Amr");
            //Console.WriteLine("Names02[0].Append(\" Amr\");");
            //Console.WriteLine($"Name01[0] = {Names01[0]}"); 
            //Console.WriteLine($"Name02[0] = {Names02[0]}"); 
        }
    }
}

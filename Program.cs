using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni4
{
    //Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z
    //stranice pravokutnog trokuta.U program uključite i provjeru da vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti(iznosi moraju biti veći od 0).

    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y,z;
            Console.WriteLine("Upisi tri broja da provjerim jesu li to stranice nekog pravokutnog trokuta: ");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z=Convert.ToInt32(Console.ReadLine());
            if(x==0 || y==0 || z==0)
            {
              Console.WriteLine("Stranice ne smiju biti 0");
            }
            else
            {
                if(x*x+y*y==z*z)
                {
                    Console.WriteLine("To su stranice pravokutnog trokuta");
                }
               
                else if (y*y+z*z==x*x)
                {
                    Console.WriteLine("To su stranice pravokutnog trokuta");
                }
                
                else if (z * z + x * x == y * y)
                {
                    Console.WriteLine("To su stranice pravokutnog trokuta");
                }
                else { Console.WriteLine("To nisu stranice pravokutnog trokuta"); }

            }
            
            Console.ReadKey();
        }

    }
}

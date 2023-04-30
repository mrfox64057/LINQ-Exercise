using System.Security.Cryptography;
using System.Threading.Channels;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {            
            var zachs = ListOfSloths.GetSloths();
            var slothABCs = zachs.OrderBy(name => name.DiffSloths);
            foreach ( var s in slothABCs)
            {
                Console.WriteLine(s.DiffSloths);
            }
        }
    }
}
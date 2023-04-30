using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    public class ListOfSloths
    {
        public static List<Sloths> GetSloths()
        {
            return new List<Sloths>
            {
                new Sloths {DiffSloths = "Pygmy three-toed sloth"},
                new Sloths {DiffSloths = "Maned sloth"},
                new Sloths {DiffSloths = "Pale-throated sloth"},
                new Sloths {DiffSloths = "Brown-throated sloth"}, 
                new Sloths {DiffSloths = "Linnaeus’s two-toed sloth"},
                new Sloths {DiffSloths = "Hoffman’s two-toed sloth"}
            };
            //return new List<Sloths>
            //{
            //    new Sloths {GenusSpecies  = "Bradypus pygmaeus"},
            //    new Sloths {GenusSpecies = "Bradypus torquatus"},
            //    new Sloths {GenusSpecies = "Bradypus tridactylus" },
            //    new Sloths {GenusSpecies = "Bradypus variegatus"},
            //    new Sloths {GenusSpecies = "Choloepus didactylus"},
            //    new Sloths {GenusSpecies = "Choloepus hoffmanni"}
            //};
        }
    }

}

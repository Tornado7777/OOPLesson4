using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var building1 = new Building();
            building1.RandomParametrsBuilding();
            building1.ShowParametrsBuilding();
            var building2 = new Building();
            building2.RandomParametrsBuilding();
            building2.ShowParametrsBuilding();
            var building3 = new Building();
            building3.RandomParametrsBuilding();
            building3.ShowParametrsBuilding();

        }

        
    }
}

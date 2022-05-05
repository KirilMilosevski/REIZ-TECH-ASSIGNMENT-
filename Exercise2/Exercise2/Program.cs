using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
     public  class Branch
    {
        
        private int v;

        public  Branch(int v)
        {
            this.v = v;
        }
       
        public static void Main()
        {
            List<Branch> branches = new List<Branch>();
            branches.Add(new Branch(6));
            branches.Add(new Branch(11));
            branches.Add(new Branch(2));
            branches.Add(new Branch(3));

            Console.WriteLine("Depth is: " + branches.Count);
        }
    }
}

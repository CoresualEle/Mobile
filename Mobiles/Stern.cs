using System;

namespace Mobiles
{
    public class Stern : INode
    {
        public Stern(int weight)
        {
            Weight = weight;
        }

        public int Weight { get; }

        public int Balance()
        {
            return Weight;
        }

        public void Print(int depth = 0)
        {
            var msg = "";

            for (var i = 0; i < depth; i++)
                msg += "\t";

            msg += ToString();

            Console.WriteLine(msg);
        }

        public override string ToString()
        {
            return $"Stern - Weight: {Weight}";
        }
    }
}
using System;

namespace Mobiles
{
    public class Stab : INode
    {
        public Stab(INode leftChildNode, INode rightChildNode, int length)
        {
            LeftChildNode = leftChildNode;
            RightChildNode = rightChildNode;
            Length = length;

            Position = 0;
        }

        public INode LeftChildNode { get; }

        public INode RightChildNode { get; }

        public int Length { get; }

        public double Position { get; private set; }

        public int Balance()
        {
            var leftWeight = LeftChildNode.Balance();
            var rightWeight = RightChildNode.Balance();

            var ratio = (double) leftWeight / (leftWeight + rightWeight);

            Position = Length * (1 - ratio);

            return leftWeight + rightWeight;
        }

        public void Print(int depth = 0)
        {
            var msg = "";

            for (var i = 0; i < depth; i++)
                msg += "\t";

            msg += ToString();

            Console.WriteLine(msg);

            LeftChildNode.Print(depth + 1);
            RightChildNode.Print(depth + 1);
        }

        public override string ToString()
        {
            return $"Stab - Length: {Length}, Position: {Position}";
        }
    }
}
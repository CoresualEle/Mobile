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

            Console.WriteLine($"Balanced Node set to Pos: {Position}!");

            return leftWeight + rightWeight;
        }
    }
}
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
    }
}
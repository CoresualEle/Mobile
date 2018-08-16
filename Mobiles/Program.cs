namespace Mobiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sternOne = new Stern(2);
            var sternTwo = new Stern(4);
            var sternThree = new Stern(9);

            var stabOne = new Stab(sternOne, sternTwo, 9);
            var stabTwo = new Stab(stabOne, sternThree, 10);

            stabTwo.Balance();
        }
    }
}
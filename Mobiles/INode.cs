namespace Mobiles
{
    public interface INode
    {
        int Balance();

        void Print(int depth = 0);
    }
}

namespace rnd
{
    internal class Next
    {
        private int v1;
        private int v2;

        public Next(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static implicit operator int(Next v)
        {
            throw new NotImplementedException();
        }
    }
}
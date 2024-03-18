using System;

namespace CAAbstractClasses
{
    interface IProduct
    {
        void GetProductInfo();
        void DisplayProductInfo();
        int Addition(int x, int y);
    }
    class Product : IProduct
    {
        public void GetProductInfo()
        {
            Console.WriteLine("This is Product Info Method");
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine("This is Display Product Info Method");
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
    class Example2
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.GetProductInfo();
            p1.DisplayProductInfo();
            Console.WriteLine(p1.Addition(100, 200));
            Console.Read();
        }
    }
}

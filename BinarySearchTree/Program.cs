namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomBinarySearch CustomBstObj = new CustomBinarySearch();
            CustomBstObj.Add(10);
            CustomBstObj.Add(23);
            CustomBstObj.Add(13);
            CustomBstObj.Add(44);
            CustomBstObj.Add(75);
            CustomBstObj.Add(56);
            CustomBstObj.Add(97);
            CustomBstObj.Add(18);
            CustomBstObj.Add(19);
            CustomBstObj.Add(10);

            Console.Write(CustomBstObj.Search(75));

            CustomBstObj.PreOrder();
            Console.WriteLine("--------");

            CustomBstObj.InOrder();
            Console.WriteLine("--------");


            CustomBstObj.PostOrder();
            Console.WriteLine("--------");
        } 
    }
}
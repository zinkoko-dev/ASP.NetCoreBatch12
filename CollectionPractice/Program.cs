
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Collection Practice");

        /*// Array List
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(1);
        myArrayList.Add(2);
        myArrayList.Add(3.00);
        myArrayList.Add("Hello");

        for (int i = 0; i < myArrayList.Count; i++)
        {
            Console.WriteLine(myArrayList[i]);
        }*/

        /*// List
        List<string> Messages = new List<string>();
        Messages.Add("Hello");
        Messages.Add("World!!");
        Messages.ForEach(msg => Console.WriteLine(msg));*/

        /*// HashTable
        Hashtable hs = new Hashtable();
        hs.Add("one", "Open file");
        hs.Add("two", "Excetuable App");
        hs.Add("three", "Excetuable file Open");
        //hs.Add("three", "Test"); not allow duplicate key

        foreach (DictionaryEntry de in hs)
        {
            Console.WriteLine(de.Value);
        }*/

        /*// Queue
        Queue q = new Queue();
        q.Enqueue("Queue Test");
        Console.WriteLine(q.Dequeue());*/

        /*// IList
        IList<string> list = new List<string>();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        foreach (string item in list) { 
            Console.WriteLine(item);
        }*/
    }
}
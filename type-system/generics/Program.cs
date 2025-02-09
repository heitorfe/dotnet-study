//Type parameteer T in angle brackets.
public class GenericList<T>{
    //The nested class is also generic, and hods a data item of type T.
    private class Node(T t)
    {
        //T as property type
        public T Data {get; set;} = t;
        public Node? Next {get; set;}
    }

    //First item in the linked list
    private Node? head;

    //T as parameter type
    public void AddHead(T t)
    {
        Node n = new(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? current = head;
        while (current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }


}

public class Program
{
    public static void Main()
    {
        //Declare a list of type int.
        GenericList<int> list = new();
        list.AddHead(1);
        list.AddHead(2);
        list.AddHead(3);

        //Use foreach to print the list.
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}
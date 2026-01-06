namespace Cs.Advanced.AnonymousMethods;

internal class Program
{
    static void Main(string[] args)
    {
        //Subscriber subscriber = new Subscriber();
        Publisher publisher = new Publisher();

        //handle the event (or) subscribe to event
        publisher.myEvent += delegate (int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        };

        //invoke the event
        publisher.RaiseEvent(10, 20);
        publisher.RaiseEvent(5,80);
        publisher.RaiseEvent(14,22);

        Console.ReadKey();
    }
}

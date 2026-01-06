namespace Cs.Advanced.AnonymousMethods;

internal class Program
{
    static void Main(string[] args)
    {

        Publisher publisher = new Publisher();

        //handle the event (or) subscribe to event
        publisher.myEvent += delegate (int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        };
        //delegate (int a, int b) definisce un methodo anonimo, dopodiche lo associa all'evento (che non ha niente a che fare w anonymous methods)

        //invoke the event
        publisher.RaiseEvent(10, 20);
        publisher.RaiseEvent(5,80);
        publisher.RaiseEvent(14,22);

        Console.ReadKey();
    }
}

namespace delegates
{

    public class C
    {
        public static void M1(int i)
        {
            System.Console.WriteLine(i);
        }
        public static void M2(int i)
        {
            System.Console.WriteLine(i);
        }
    }

    public class Program
    {
        delegate void D(int x);

        static void Main()
        {
            D cd1 = new D(C.M1); // M1 - one entry in invocation list
            D cd2 = new D(C.M2); // M2 - one entry
            cd1(1);
            cd2(2);
            D cd3 = cd1 + cd2;   // M1 + M2 - two entries
            cd3(3);             // Prints 3, two-times

            D cd4 = cd3 + cd1;   // M1 + M2 + M1 - three entries
            cd4(4);             // Prints 4, three-times

            D cd5 = cd4 + cd3;   // M1 + M2 + M1 + M1 + M2 - five entries
            cd5(5);             // Prints 5, five-times
            D td3 = new D(cd3);  // [M1 + M2] - ONE entry in invocation
                                 // list, which is itself a list of two methods.
	    PathTraversalVuln x = new PathTraversalVuln(".");
	    
        }
    }

}

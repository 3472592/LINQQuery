namespace EasyQuery;

public class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
            throw new ArgumentNullException(nameof(args));

        /* letter “v” to stand in for
        each of the array values in the query. So v
        is 0, then 12, then 44, then 36…etc. It’s
        called the range variable. */
        int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };

        /* This LINQ query has
        four clauses: the from
        clause, a where clause, an
        orderby clause, and the
        select clause. */
        var result = from v in values
                     where v < 37 // select ea "v" in array, that less than 37.
                     orderby v // sort in lowest to highest.
                     select v; // in LINQ it is @ the bottom, in SQL up top.

        foreach (int i in result)
            Console.Write("{0} ", i);
        Console.ReadKey();  
    }
}
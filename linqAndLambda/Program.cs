using System.Linq;
namespace linqAndLambda
{
    public class activitySetOne
    {
        List<string> cities = new List<string>
        {
            "Mumbai",
            "Delhi",
            "Ahmedabad",
            "Surat",
            "Valsad",
            "Varanasi"  ,
            "Chennai",
            "Bhopal",
            "Darjeeling",
        };

        public static void Main(string[] args)
        {   
            activitySetOne activitySetOne = new activitySetOne();

            // For Descending Order
            Console.WriteLine("For Descending Order");
            Console.WriteLine();
            IEnumerable<string> citiesDescendingOrder = activitySetOne.descendingOrder(activitySetOne);
            activitySetOne.displayTheResult(citiesDescendingOrder);


            //For Ascending Order
            Console.WriteLine();
            Console.WriteLine("For Ascending Order");
            Console.WriteLine();
            IEnumerable<string> citiesAscendingOrder = activitySetOne.citiesAscendingOrder(activitySetOne);
            activitySetOne.displayTheResult(citiesAscendingOrder);

            //For Descending by length
            Console.WriteLine();
            Console.WriteLine("For Descending by length");
            Console.WriteLine();
            IEnumerable<string> citiesDescendingOrderByLength = activitySetOne.descendingByLength(activitySetOne);
            activitySetOne.displayTheResult(citiesDescendingOrderByLength);


            //For Descending by length
            Console.WriteLine();
            Console.WriteLine("For Ascending by length");
            Console.WriteLine();
            IEnumerable<string> citiesAscendingOrderByLength = activitySetOne.ascendingByLength(activitySetOne);
            activitySetOne.displayTheResult(citiesAscendingOrderByLength);

            //Get cities names starts with V and D letter.

            Console.WriteLine();
            Console.WriteLine("Get cities names starts with V and D letter.");
            Console.WriteLine();
            IEnumerable<string> citiesWithAandD = activitySetOne.citiesWithAandDMethod(activitySetOne);
            activitySetOne.displayTheResult(citiesWithAandD);


            // Get count of city names starts with A letter.
            Console.WriteLine();
            Console.WriteLine("Get cities names starts with V and D letter.");
            Console.WriteLine();
            IEnumerable<string> countOfStartWithA = activitySetOne.countOfStartWithAMethod(activitySetOne);
            Console.WriteLine("Count of Cities with A is "+countOfStartWithA.Count());

            // Group ordered city names by its first letter

            Console.WriteLine();
            Console.WriteLine("Get cities names starts with V and D letter.");
            Console.WriteLine();
            activitySetOne.groupByFirstLetterMethod(activitySetOne);
          

        }

        // group by first letter

        public void groupByFirstLetterMethod(activitySetOne activitySetOne)
        {
            var groupByFirstLetter =
              from c in activitySetOne.cities
              group c by c[0];

            foreach (var currentLetterGroup in groupByFirstLetter)
            {
                Console.WriteLine("\tWords that begin with '{0}':", currentLetterGroup.Key);
                foreach (var name in currentLetterGroup)
                {
                    Console.WriteLine("\t{0}", name);
                }
            }
        }
        public IEnumerable<string> countOfStartWithAMethod(activitySetOne activitySetOne)
        {
            var countOfStartWithA =
              from c in activitySetOne.cities
              where c[0] == 'A'
              select c;
            return countOfStartWithA;
        }

        public IEnumerable<string> citiesWithAandDMethod(activitySetOne activitySetOne)
        {
            var citiesWithAandD =
              from c in activitySetOne.cities
              where c[0]=='V' || c[0] == 'D'
              select c;
            return citiesWithAandD;
        }

        public IEnumerable<string> descendingByLength(activitySetOne activitySetOne)
        {
            var descendingByLength =
              from c in activitySetOne.cities
              orderby c.Length descending
              select c;
            return descendingByLength;
        }

        public IEnumerable<string> ascendingByLength(activitySetOne activitySetOne)
        {
            var ascendingByLength =
              from c in activitySetOne.cities
              orderby c.Length ascending
              select c;
            return ascendingByLength;
        }

        public IEnumerable<string> citiesAscendingOrder(activitySetOne activitySetOne)
        {
            var citiesAscendingOrder =
              from c in activitySetOne.cities
              orderby c ascending
              select c;
            return citiesAscendingOrder;
        }
        public IEnumerable<string> descendingOrder(activitySetOne activitySetOne)
        {
            var citiesDescendingOrder =
               from c in activitySetOne.cities
               orderby c descending
               select c;
            return citiesDescendingOrder;   
        }
      public void displayTheResult(IEnumerable<string> resultIn)
        {
            foreach (var c in resultIn)
            {
                Console.WriteLine(c);
            }
        }
    }
}
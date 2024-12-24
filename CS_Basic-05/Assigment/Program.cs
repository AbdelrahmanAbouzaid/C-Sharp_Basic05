namespace Assigment
{
    enum Colors 
    { 
        Red, Green, Blue
    }
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Season
    {
        Summer, Winter, Spring, Autumn
    }

    [Flags]
    enum Permissions
    {
        Read = 8,
        Write = 4,
        Delete = 2,
        Execute = 1
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //// GetValues => Enum.GetValues along with typeof(WeekDays) to iterate through all the values of the WeekDays enum
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);

            //} 
            #endregion

            #region Q2
            //Console.Write("Enter a season: ");
            //string input = Console.ReadLine();

            //Season season;
            //while (!Enum.TryParse(input, true, out season))
            //{
            //    Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //    input = Console.ReadLine();
            //}

            //switch (season)
            //{
            //    case Season.Summer:
            //        Console.WriteLine("December, January, February");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("September, October, November");
            //        break;
            //    case Season.Spring:
            //        Console.WriteLine("March, April, May");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September, October, November");
            //        break;
            //} 
            #endregion

            #region Q3
            //Permissions permissions = Permissions.Read;

            //Console.WriteLine(permissions);

            //permissions ^= Permissions.Write;

            //if ((permissions & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Permissions Read");
            //else
            //    Console.WriteLine("Permissions Not Read");

            //Console.WriteLine(permissions);

            //permissions ^= Permissions.Read;

            //Console.WriteLine(permissions);

            //if ((permissions & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Permissions Read");
            //else
            //    Console.WriteLine("Permissions Not Read"); 
            #endregion

            #region Q4
            //Console.Write("Ente the Color Name: ");
            //string inputColor = Console.ReadLine();
            //if (Enum.TryParse(inputColor, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputColor} is not a primary color.");
            //} 
            #endregion

        }
    }
}

namespace Assignment_1_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ITI
            using DBContexts.ITIDBContext iTIDBContext = new DBContexts.ITIDBContext();
            #endregion
            #region Airline
            using DBContexts.AirlineDBContext airlineDBContext = new DBContexts.AirlineDBContext();
            #endregion
        }
    }
}

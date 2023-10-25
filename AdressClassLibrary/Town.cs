namespace AdressClassLibrary
{
    internal class Town
    {
        public string TownName { get; set; }
        public int ZipNumber { get; set; }


        public Town(string townName, int zipNumber)
        {
            TownName = townName;
            ZipNumber = zipNumber;
        }

        public static Town GetTown(string townName)
        {
            Dictionary<string, int> TownList = new Dictionary<string, int> { { "gent", 9000 }, { "aalst", 9300 }, { "lokeren", 9160 } };
            Town town = null;
            foreach(string townNameKey in TownList.Keys)
            {
                if(townNameKey == townName.ToLower())
                {
                    town = new Town(townName, TownList[townName]);
                    break;
                }
            }
            try
            {
                if(town != null)
                    return town;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return town;
        }
    }
}

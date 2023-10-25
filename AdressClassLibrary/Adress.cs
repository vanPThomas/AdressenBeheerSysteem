namespace AdressClassLibrary
{
    public class Adress
    {
        public Adress(string townName, string streetName, string houseNumber)
        {
            Town = Town.GetTown(townName);
            if (streetName != null)
                StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Town Town { get; set; } = null;
        public string StreetName { get; set; } = null;
        public string HouseNumber { get; set; } = null;

        public static bool ValidHouseNumber(string houseNumber)
        {
            bool valid = false;
            int housenumber;
            valid = int.TryParse(houseNumber.Substring(0, 1), out housenumber);
            return valid;

        }

    }
}

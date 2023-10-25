namespace AdressClassLibrary
{
    public class DataManager
    {
        HashSet<Adress> adresses = new HashSet<Adress>();

        public void AddAdress(string town, string streetname, string housenumber)
        {
            Adress adress = new Adress (town, streetname, housenumber);
            adresses.Add (adress);
            
        }
    }
}

namespace CoreTemplate.Models
{
    public class Repository
    {
        private static List<Ogrenci> ogrencis = new List<Ogrenci>();

        public static List<Ogrenci> ogrenciListe()
        {
            return ogrencis;
        }

        public static void OgrenciEkle(Ogrenci o)
        {
            ogrencis.Add(o);
        }

        public static List<Ogrenci> Ogrenciler { get { return ogrencis; } }

    }
}

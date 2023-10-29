namespace SignalRApi.DAL
{
    public enum Ecity
    {
        Edirne=1,
        İstanbul=2,
        Ankara=3,
        Antalya=4,
        Bursa=5
    }

    public class Visitor
    {
        public int VisitorId { get; set; }
        public Ecity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}

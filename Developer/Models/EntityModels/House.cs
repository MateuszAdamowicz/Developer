namespace Developer.Models.EntityModels.Interfaces
{
    public class House: Ad, IHouse
    {
        public string Location { get; set; }
        public string LandArea { get; set; }
        public string UsableArea { get; set; }
        public string TechnicalCondition { get; set; }
        public string Rooms { get; set; }
        public string Heating { get; set; }
        public string Rent  { get; set; }
        public string Ownership { get; set; }
        public string PricePerMeter { get; set; }
        public string ToLet { get; set; }
    }
}
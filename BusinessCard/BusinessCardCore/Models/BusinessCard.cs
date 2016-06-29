namespace BusinessCardCore.Models
{
    public class BusinessCard: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string CompanyName { get; set; }
        public string TitlePosition { get; set; }

    }
}
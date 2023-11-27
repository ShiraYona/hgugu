namespace ServerToAngular.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Donor { get; set; }
        public int Cost { get; set; } = 10;
        public string Image { get; set; }
        public string Description { get; set; }

        public Gift(int id, string name, string donor, int cost,string image,string description)
        {
            Id = id;
            Name = name;
            Donor = donor;
            Cost = cost;
            Image = image;
            Description = description;
        }
    }
}

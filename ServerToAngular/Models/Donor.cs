namespace ServerToAngular.Models
{
  public class Donor
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }


    public Donor(int id, string name, string email)
    {
      Id = id;
      Name = name;
      Email = email;
      
    }
  }
}

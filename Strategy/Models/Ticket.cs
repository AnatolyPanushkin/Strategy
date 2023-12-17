namespace Strategy.Models;

public class Ticket
{
    public string Description { get; set; }
    
    public List<Place> Places { get; set; }
    
    public string Address { get; set; }
    
    public string Time { get; set; }
}
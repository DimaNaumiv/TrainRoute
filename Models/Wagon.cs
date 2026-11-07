namespace Models;

public class Wagon
{
    public Guid Id { get; set; }
    public Guid TrainId { get; set; }
    public int WagonNumber { get; set; }
    public string WagonClass { get; set; }
    
    public Train Train { get; set; }
    public List<Seat> Seats { get; set; }   
}
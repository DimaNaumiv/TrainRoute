namespace Models;

public class Seat
{
    public Guid Id { get; set; }
    public Guid WagonId { get; set; }
    public int SeatNumber { get; set; }
    public bool IsUpper { get; set; }
    public bool NearWindow { get; set; }
    public bool HasSocket { get; set; }
    public bool Has_Air { get; set; }
    public bool Allow_pets { get; set; }
    
    public Wagon Wagon { get; set; }
}
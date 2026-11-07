namespace Models;

public class Ticket
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid TrainRunId { get; set; }
    public Guid SeatId { get; set; }
    public int FromSation { get; set; }
    public int ToSation { get; set; }
    
    public decimal Price { get; set; }
    public string Status { get; set; }

    public TrainRun TrainRun { get; set; }  
    public Seat Seat { get; set; }
    
}
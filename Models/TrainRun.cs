using Train_Route;

namespace Models;

public class TrainRun
{
    public Guid Id { get; set; }
    public Guid TrainId { get; set; }
    public Guid RoutId { get; set; }
    public DateOnly  RunDate { get; set; }
    public int DalayMinutes { get; set; }
    public string Satus { get; set; }
    
    public Train Train { get; set; }
    public Routes Rout { get; set; }
}
namespace Models;

public class Train
{
    public Guid Id { get; set; }
    public string Number { get; set; }
    public string TrainType { get; set; }
    
    public List<Wagon> Wagons { get; set; }
}
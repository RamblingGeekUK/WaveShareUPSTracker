public class Reading
{

    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public int Id {get;set;}
    public float LoadVoltage {get;set;}
    public double Current {get;set;}
    public float Power {get;set;}
    public float PercentRemaining {get;set;}
    

    public Reading() {}

    public Reading(Reading entry) =>
        (Id, DateCreated, LoadVoltage, Current, Power, PercentRemaining) = (entry.Id, entry.DateCreated, entry.LoadVoltage, entry.Current, entry.Power, entry.PercentRemaining);
}
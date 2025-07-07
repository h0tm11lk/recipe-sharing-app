public class Step
{
    public StepId Id { get; set; }
    public int OrderNumber { get; set; }
    public string Description { get; set; }
    public void UpdateDescription()
    {
        // Logic to update the step description
    }

    public void UpdateOrderNumber()
    {
        // Logic to update the step order number
    }       
}
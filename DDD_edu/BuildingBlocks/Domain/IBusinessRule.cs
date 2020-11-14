namespace DDD_edu.BuildingBlocks.Domain
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}
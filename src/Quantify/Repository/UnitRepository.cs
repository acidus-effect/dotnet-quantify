namespace Quantify
{
    public interface UnitRepository<TValue, TUnit>
    {
        UnitData<TValue, TUnit> GetUnit(TUnit unit);
    }
}
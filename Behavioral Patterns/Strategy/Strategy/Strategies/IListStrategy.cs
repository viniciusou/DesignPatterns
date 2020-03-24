using System.Text;

namespace Strategy.Strategies
{
    public interface IListStrategy
    {
        void Start(StringBuilder stringBuilder);
        void End(StringBuilder stringBuilder);
        void AddListItem(StringBuilder stringBuilder, string item);
    }
}

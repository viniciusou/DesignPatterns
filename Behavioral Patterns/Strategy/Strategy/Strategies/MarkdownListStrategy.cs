using System.Text;

namespace Strategy.Strategies
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder stringBuilder, string item)
        {
            stringBuilder.AppendLine($" * {item}");
        }

        public void End(StringBuilder stringBuilder)
        {
            
        }

        public void Start(StringBuilder stringBuilder)
        {
            
        }
    }
}

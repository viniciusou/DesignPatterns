using System.Text;

namespace Strategy.Strategies
{
    public class HtmlListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder stringBuilder, string item)
        {
            stringBuilder.AppendLine($"   <li>{item}</li>");
        }

        public void End(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("</ul>");
        }

        public void Start(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<ul>");
        }
    }
}

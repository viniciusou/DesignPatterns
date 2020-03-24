using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class TextProcessor
    {
        private StringBuilder stringBuilder = new StringBuilder();
        private IListStrategy listStrategy;

        public void SetOutputFormat(OutputFormat format)
        {
            listStrategy = format switch
            {
                OutputFormat.Html => new HtmlListStrategy(),
                OutputFormat.Markdown => new MarkdownListStrategy(),
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null),
            };
        }

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(stringBuilder);
            foreach (var item in items)
                listStrategy.AddListItem(stringBuilder, item);
            listStrategy.End(stringBuilder);
        }

        public StringBuilder Clear()
        {
            return stringBuilder.Clear();
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }
    }
}

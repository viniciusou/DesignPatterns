using System;

namespace Strategy
{
    /// <summary>
    /// The strategy pattern enables selecting an algorithm at runtime. Instead of 
    /// implementing a single algorithm directly, code receives run-time instructions 
    /// as to which in a family of algorithms to use. Deferring the decision about which 
    /// algorithm to use until runtime allows the calling code to be more flexible and 
    /// reusable. 
    /// 
    /// 
    /// In this case the list strategy can be changed at runtime between html list and 
    /// markdown list.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var textProcessor = new TextProcessor();
            textProcessor.SetOutputFormat(OutputFormat.Html);
            textProcessor.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(textProcessor);

            Console.WriteLine();

            textProcessor.Clear();
            textProcessor.SetOutputFormat(OutputFormat.Markdown);
            textProcessor.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(textProcessor);
        }
    }
}

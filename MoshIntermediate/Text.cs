using System;

namespace MoshIntermediate
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("A link was added to " + url);
        }
    }
}
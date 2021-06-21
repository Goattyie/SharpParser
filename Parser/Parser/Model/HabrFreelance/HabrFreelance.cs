using HtmlAgilityPack;
using Fizzler;
using System;
using System.Collections.Generic;

namespace Parser.Model.AliExpress
{
    class HabrFreelance : IParser<string[]>
    {
        public string[] Parse(HtmlDocument htmlDocument)
        {
            List<string> nodes = new List<string>();
            foreach (HtmlNode link in htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'task__title')]") ?? new HtmlNodeCollection(new HtmlNode(new HtmlNodeType(), new HtmlDocument(), 0)))
            {
                HtmlAttribute att = link.Attributes["Title"];
                nodes.Add(att.Value);
            }
            return nodes.ToArray();
        }
    }
}

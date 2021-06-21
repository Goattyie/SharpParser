using HtmlAgilityPack;

namespace Parser.Model
{
    interface IParser<T> where T:class
    {
        T Parse(HtmlDocument htmlDocument);
    }
}

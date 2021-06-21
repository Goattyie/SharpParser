using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    class ParserWorker<T> where T : class
    {
        IParser<T> _parser;
        IParserSettings _parserSettings;
        HtmlLoader _loader;

        public event Action<object> OnComplete;
        public event Action<object, T> OnNewData;
        public IParser<T> Parser
        {
            get { return _parser; }
            set { _parser = value; }
        }
        public IParserSettings ParserSettings
        {
            get { return _parserSettings; }
            set
            {
                _parserSettings = value;
                _loader = new HtmlLoader(_parserSettings);
            }
        }

        public bool isActive;
        public ParserWorker(IParser<T> parser)
        {
            Parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            ParserSettings = parserSettings;
        }
        public void Start()
        {
            isActive = true;
            Worker();
        }
        public void End()
        {
            isActive = false;
        }
        public async void Worker()
        {
            for(int i = ParserSettings.StartPoint; i <= ParserSettings.EndPoint; i++)
            {
                if (!isActive)
                    break;

                var document = await _loader.GetHtmlPageById(i);
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(document);
                var data = _parser.Parse(htmlDocument);
                OnNewData?.Invoke(this, data);
            }
            OnComplete?.Invoke(this);
            isActive = false;
        }
    }
}

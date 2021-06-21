using System;

namespace Parser.Model.AliExpress
{
    class HabrFreelanceSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://freelance.habr.com";
        public string Prefix { get; set; } = "tasks?page={0}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public HabrFreelanceSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
    }
}

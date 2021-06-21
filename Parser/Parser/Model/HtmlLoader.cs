using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace Parser.Model
{
    class HtmlLoader
    {
        readonly HttpClient httpClient;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            httpClient = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}";
        }
        public async Task<string> GetHtmlPageById(int id)
        {
            var currentUrl = String.Format(url, id);
            var request = await httpClient.GetAsync(currentUrl);
            string document = null;

            if(request != null && request.StatusCode == HttpStatusCode.OK)
            {
                document = await request.Content.ReadAsStringAsync();
            }

            return document;
        }
    }
}

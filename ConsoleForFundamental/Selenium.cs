using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForFundamental;

internal class Selenium
{
    public async Task<string> HisLastBow()
    {
        HttpClient book = new HttpClient();
        var homePageContent = await book.GetStringAsync("https://sherlock-holm.es/stories/plain-text/last.txt");
        homePageContent =homePageContent.Replace("\n", "");
        return homePageContent;

    }
}

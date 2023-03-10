﻿namespace News.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Article
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("publishedAt")]
    public DateTime PublishedAt { get; set; }

    [JsonPropertyName("source")]
    public Source Source { get; set; }
}

public class Root
{
    [JsonPropertyName("totalArticles")]
    public int TotalArticles { get; set; }

    [JsonPropertyName("articles")]
    public List<Article> Articles { get; set; }
}

public class Source
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}

// READ ME: TODO: ReadMe.
//Raw JSON FROM: https://gnews.io/api/v4/top-headlines?category=general&apikey=be1323e95fb4fa7316d1b7ecc96014f0&lang=en&topic=sports
//{"totalArticles":440499,"articles":[{"title":"Morpeth 'human bones' discovery LIVE: Updates as police cordon off wooded area","description":"A police investigation is under way after potential human bones were found in Northumberland woodland","content":"KEY EVENT\nRecap: Everything we know so far\nAn investigation has been launched by Northumbria Police after potentially human bones were found in a woodland area of Northumberland.\n(Image: Newcastle Chronicle)\nPolice received reports of the bones just ... [1416 chars]","url":"https://www.chroniclelive.co.uk/news/north-east-news/morpeth-human-bones-discovery-live-26441330","image":"https://i2-prod.chroniclelive.co.uk/incoming/article26441263.ece/ALTERNATES/s1200/0_SGP_NEC_100323BONES12JPG.jpg","publishedAt":"2023-03-10T19:27:29Z","source":{"name":"Chronicle Live","url":"https://www.chroniclelive.co.uk"}},{ "title":"Sony: Xbox’s Call of Duty Offer Will ‘Irreparably Harm Competition’","description":"Sony is claiming it's not happy with Microsoft's latest Call of Duty offer, as the company said it would \"irreparably\" harm competition and innovation.","content":"Sony is claiming it's not happy with Microsoft's latest Call of Duty offer, as the company said it would \"irreparably\" harm competition and innovation.\nEarlier this week, reports filed from Sony and Microsoft to the UK's Competition and Markets Autho... [2107 chars]","url":"https://www.ign.com/articles/sony-xboxs-call-of-duty-offer-will-irreparably-harm-competition","image":"https://assets-prd.ignimgs.com/2022/12/07/mw2-campaign-review-blogroll-1666622891997-1670386664953.jpg?width=1280","publishedAt":"2023-03-10T18:56:49Z","source":{ "name":"IGN","url":"https://www.ign.com"} },{ "title":"Federal budget 2023 coming March 28","description":"The 2023 federal budget will be presented on Tuesday, March 28, Deputy Prime Minister and Finance Minister Chrystia Freeland announced Friday, with stakeholders calling for the massive fiscal document to include a plan to promote economic growth.","content":"The 2023 federal budget will be presented on Tuesday, March 28, Deputy Prime Minister and Finance Minister Chrystia Freeland announced Friday, with stakeholders calling for the massive fiscal document to include a plan to promote economic growth.\nRis... [4020 chars]","url":"https://www.ctvnews.ca/politics/freeland-facing-calls-to-prioritize-economic-growth-as-budget-date-confirmed-1.6308009","image":"https://www.ctvnews.ca/content/dam/ctvnews/en/images/2023/3/10/chrystia-freeland-1-6308014-1678468567055.jpg","publishedAt":"2023-03-10T18:52:26Z","source":{ "name":"CTV News","url":"https://www.ctvnews.ca"} },{ "title":"From Brexit to Qatar, Gary Lineker has not shied away from airing his views","description":"BBC presenter has been no stranger to controversy before his latest comments about Suella Braverman","content":"Gary Lineker, the former Tottenham, Leicester and England striker who went on to become the BBC’s best-paid presenter, has not shied away from airing his views over the years.\nBefore the latest controversy, which was sparked after he suggested that l... [3490 chars]","url":"https://www.theguardian.com/football/2023/mar/10/brexit-qatar-gary-lineker-not-shied-away-airing-views","image":"https://i.guim.co.uk/img/media/4c257c5e77bdf8c8761e820b64f231f80adda4d7/0_295_4671_2803/master/4671.jpg?width=1200&height=630&quality=85&auto=format&fit=crop&overlay-align=bottom%2Cleft&overlay-width=100p&overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&enable=upscale&s=0bad12b77f90f9712fb133eacf07bb2e","publishedAt":"2023-03-10T18:45:00Z","source":{ "name":"The Guardian","url":"https://www.theguardian.com"} },{ "title":"The Best Mario Day Deals on Nintendo Games and Consoles","description":"Celebrate everyone's favorite red-capped plumber with these discounts on Nintendo consoles and games.","content":"March 10 is Mario Day, and of all the made-up shopping holidays, this one is actually worth celebrating. From special console bundles to discounts on games featuring beloved characters from the Mario universe, these limited-time deals will be sure to... [5934 chars]","url":"https://www.wired.com/story/mario-day-deals-2023/","image":"https://media.wired.com/photos/5acd484a0a43cb2563ab81dc/191:100/w_1280,c_limit/03-Super-Mario-Odyssey-screenshot-SOURCE-Nintendo.jpg","publishedAt":"2023-03-10T18:27:00Z","source":{ "name":"WIRED","url":"https://www.wired.com"} },{ "title":"Floods, heavy snow hit California during atmospheric storms","description":"Evacuations were ordered Friday in Northern California after a new atmospheric river brought heavy rain, thunderstorms and strong winds, swelling rivers and creeks and flooding several major highways during the morning commute. In Santa Cruz County, a creek bloated by rain destroyed a portion of Main Street in Soquel, a town of 10,000 people, isolating […]","content":"Evacuations were ordered Friday in Northern California after a new atmospheric river brought heavy rain, thunderstorms and strong winds, swelling rivers and creeks and flooding several major highways during the morning commute.\nIn Santa Cruz County, ... [4745 chars]","url":"https://ktla.com/news/california/new-atmospheric-river-storm-brings-heavy-rain-to-california/","image":"https://ktla.com/wp-content/uploads/sites/4/2023/03/AP23068838518765.jpg?w=1280","publishedAt":"2023-03-10T18:26:05Z","source":{ "name":"KTLA Los Angeles","url":"https://ktla.com"} },{ "title":"US closes Silicon Valley Bank in biggest collapse since 2008","description":"US regulators pulled the plug on Silicon Valley Bank on Friday in a spectacular move that sent global banking shares into turmoil, as markets fretted over possible contagion from America's biggest banking failure since the 2008 financial crisis.","content":"US regulators pulled the plug on Silicon Valley Bank on Friday in a spectacular move that sent global banking shares into turmoil, as markets fretted over possible contagion from America's biggest banking failure since the 2008 financial crisis.\nUS a... [3372 chars]","url":"https://www.news.com.au/breaking-news/markets-in-turmoil-as-us-closes-silicon-valley-bank/news-story/79ad7e57df1cd2d0419982e0c092f0fa","image":"https://content.api.news/v3/images/bin/5fa3234b83c990469e1d976ee98a0532","publishedAt":"2023-03-10T18:21:33Z","source":{ "name":"news.com.au","url":"https://www.news.com.au"} },{ "title":"Scientists Name Newly Discovered Roach After Pokémon","description":"Nocticola pheromosa is thought to be the first bug of its kind discovered in Singapore.","content":"Here’s a pocket monster that you probably wouldn’t want to catch. Scientists say they’ve confirmed the existence of a previously unknown cockroach species found in Singapore—a species they then decided to name after an otherworldly Pokémon that more ... [3387 chars]","url":"https://gizmodo.com/singapore-roach-named-after-pokemon-nocticola-pheromosa-1850212824","image":"https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/dbb1a90ee7cdbbfe3434d3b3f0b28eea.jpg","publishedAt":"2023-03-10T18:10:00Z","source":{ "name":"Gizmodo","url":"https://gizmodo.com"} },{ "title":"Canada faces muted impact from Silicon Valley Bank failure","description":"SVB became one of the largest U.S. banks to fail since the 2008 financial crisis, as a California regulator closed it down after it faced a run on its deposits from companies seeking to withdraw cash from their accounts","content":"People look at signs posted outside of an entrance to Silicon Valley Bank in Santa Clara, Calif., March 10, 2023.Jeff Chiu/The Associated Press\nThe abrupt failure on Friday of Silicon Valley Bank, one of the world’s most prominent technology financie... [5148 chars]","url":"https://www.theglobeandmail.com/business/article-canada-silicon-valley-bank-impact/","image":"https://www.theglobeandmail.com/resizer/w-VPmm0DLmXLBI8ESrDhxoTCv5w=/1200x800/filters:quality(80)/cloudfront-us-east-1.images.arcpublishing.com/tgam/YUU6ICQNDVJP5LRMUNEM2ZA27A.jpg","publishedAt":"2023-03-10T18:03:22Z","source":{ "name":"The Globe and Mail","url":"https://www.theglobeandmail.com"} },{ "title":"Altercation at Arizona hotel led to complaint about Supreme Court Justice Russell Brown","description":"On leave from top court since February, Justice Brown defends himself in Friday statement after complainant shared story with media","content":"Supreme Court Justice Russell Brown, right, appears at a ceremony at the Supreme Court of Canada in Ottawa in 2015.Adrian Wyld/The Canadian Press\nA complaint about the conduct of Supreme Court Justice Russell Brown, who has been on leave with pay sin... [4183 chars]","url":"https://www.theglobeandmail.com/canada/article-altercation-at-arizona-hotel-led-to-complaint-about-supreme-court/","image":"https://www.theglobeandmail.com/resizer/SAba4dxKjPmEwaERODvAttXoRdU=/1200x767/filters:quality(80)/cloudfront-us-east-1.images.arcpublishing.com/tgam/NWASXTJT5JHGBMMKCZHZQ45LFM.JPG","publishedAt":"2023-03-10T17:59:12Z","source":{ "name":"The Globe and Mail","url":"https://www.theglobeandmail.com"} }]}

//When to json to C# Converter site : https://json2csharp.com/   selected "Use Pascal Case" and Add JsonPropertyName then clicked on "Convert".  Then Copy/Paste Here.
using System.Text.Json;

namespace NewsWeb
{
    public class ArticlesContainer
    {
        public static Article[] Articles { get; set; } = JsonSerializer.Deserialize<Article[]>("""
                                                                              [
                                                                                { "id": 1, "name": "Welcome to the dojo", "body": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In mauris nulla, pulvinar nec lacinia a, vulputate in sapien. Nullam id lacinia enim. Aenean justo felis, accumsan at faucibus in, viverra sed nunc. Nunc imperdiet auctor dui at blandit. Aenean rhoncus erat non ipsum iaculis imperdiet. Pellentesque faucibus elit at cursus vestibulum. Praesent eu augue facilisis, tempor diam a, blandit lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae." },
                                                                                { "id": 2, "name": "How to be a Ninja",   "body": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In mauris nulla, pulvinar nec lacinia a, vulputate in sapien. Nullam id lacinia enim. Aenean justo felis, accumsan at faucibus in, viverra sed nunc. Nunc imperdiet auctor dui at blandit. Aenean rhoncus erat non ipsum iaculis imperdiet. Pellentesque faucibus elit at cursus vestibulum. Praesent eu augue facilisis, tempor diam a, blandit lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae." },
                                                                                { "id": 3, "name": "Ninja Web Dev Tips",  "body": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In mauris nulla, pulvinar nec lacinia a, vulputate in sapien. Nullam id lacinia enim. Aenean justo felis, accumsan at faucibus in, viverra sed nunc. Nunc imperdiet auctor dui at blandit. Aenean rhoncus erat non ipsum iaculis imperdiet. Pellentesque faucibus elit at cursus vestibulum. Praesent eu augue facilisis, tempor diam a, blandit lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae." }
                                                                              ]
                                                                              """, new JsonSerializerOptions { AllowTrailingCommas = true })!;
    }

    public class Article
    {
        public int id { get; set; }
        public string name { get; set; }
        public string body { get; set; }
    }

}

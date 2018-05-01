namespace SupportTool.Models
{
    public class Domain1
    {
        public string Url { get; set; }
        public string Token { get; set; }
    }

    public class Domain2
    {
        public string Url { get; set; }
        public string Token { get; set; }
    }

    public class Domains
    {
        public Domain1 Domain1 { get; set; }
        public Domain2 Domain2 { get; set; }
    }

    public class Service1
    {
        public string Url { get; set; }
        public string Token { get; set; }
    }

    public class Service2
    {
        public string Url { get; set; }
        public string Token { get; set; }
    }

    public class Services
    {
        public Service1 Service1 { get; set; }
        public Service2 Service2 { get; set; }
    }

    public class Appsettings
    {
        public Domains Domains { get; set; }
        public Services Services { get; set; }
    }
}

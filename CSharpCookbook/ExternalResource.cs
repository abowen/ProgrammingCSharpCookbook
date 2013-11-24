namespace CSharpCookbook
{
    public class ExternalResource
    {
        public ExternalResource(string title, string link)
        {
            Link = link;
            Title = title;
        }

        public string Title { get; private set; }
        public string Link { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Title, Link);
        }
    }
}

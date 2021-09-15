

namespace gotcha_web.util{
    public class Link{
        public string linktext{get;set;}
        public string path{get;set;}

        public Link(string text, string path)
        {
            linktext = text;
            this.path = path;
        }
    }

}
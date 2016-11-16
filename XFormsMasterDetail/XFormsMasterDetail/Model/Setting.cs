using XFormsMasterDetail.Helper;

namespace XFormsMasterDetail.Model
{
    public class Setting : IListContnent
    {
        public Setting(string title, string category, string style)
        {
            Title = title;
            Category = category;
            StyleId = style;
        }
        public Setting(string title, string category)
        {
            Title = title;
            Category = category;
            StyleId = "disclosure";
        }
        public Setting(string title)
        {
            Title = title;
            StyleId = "disclosure";
        }
        public Setting()
        {
            StyleId = "none";
        }
        
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string StyleId { get; set; }
        public string Category { get; set; }
    }
}

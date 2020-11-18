using System.Collections.Generic;

using Xamarin.Forms;
namespace CarouselDemo.Models
{
    public class Chapter
    {
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
    }

    public class Page
    {
        public string Title { get; set; }
        public Color BackColor { get; set; }
    }
}

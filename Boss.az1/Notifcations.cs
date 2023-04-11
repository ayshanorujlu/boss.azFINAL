using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az1
{
    public class Notifications
    {
        public Notifications(int count, string? content)
        {
            count = Count;
            content = Content;


        }
        public Notifications() { }
        public int Count { get; set; } = 0;
        public string Content { get; set; }

        public void Show()
        {
            Console.WriteLine(Content);
        }
    }
}

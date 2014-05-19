// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
// Sample HTML fragment: <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
//                       Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//                       <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
//                       Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;

namespace TagReplaceHTML
{
    class TagReplaceHTML
    {
        static void Main()
        {
            string sample = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

            string edit = sample.Replace(@"<a href=""", "[URL=");
            edit = edit.Replace(@"</a>", "[/URL]");
            edit = edit.Replace(@""">", "]");
            Console.WriteLine("URL: {0}", edit);
        }
    }
}
using System;
using System.Dom;
using System.Html;
using HelloWorld.Strings;

namespace HelloWorld
{
    public class Person
    {
        public string Name { get; set; }
        public string Greeting(Person p)
        {
            return "Hello {0}".FormatWith(p.Name);
        }
    }
}

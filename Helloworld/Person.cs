using System;
using System.Dom;
using System.Html;
using Core.Text.Extensions;

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

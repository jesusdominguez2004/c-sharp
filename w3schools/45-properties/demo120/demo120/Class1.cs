// W3Schools, C# Properties
using System;

namespace MyApplication
{
    class Person
    {
        private string name;    // field
        public string Name      // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
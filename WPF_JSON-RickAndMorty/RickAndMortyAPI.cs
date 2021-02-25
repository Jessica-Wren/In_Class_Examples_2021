using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_JSON_RickAndMorty
{
    public class RickAndMortyAPI // the first curly brace above info
    {
        public Info info { get; set; }    // a property called info is inside the RickAndMortyClass
        public List<Character> results { get; set; } // this property has a [ so we need to make it a collection. so well do a list

    }

    public class Character
    {
        public string name { get; set; }
        public string image { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Info  // the curly brace after info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        
    }
}

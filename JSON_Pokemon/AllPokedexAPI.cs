using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    public class AllPokedexAPI // first bracket
    {
        public int height { get; set; }
        public int weight { get; set; }

        public override string ToString()
        {
            return (height + " " + weight);
        }

        public SpritesObject sprites { get; set; }
    }

    public class SpritesObject
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
        
    }

   
}

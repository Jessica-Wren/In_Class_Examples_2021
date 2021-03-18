using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeGrady
{
    public class CoolData
    {
        public string Name { get; set; }
        public string Ugliness { get; set; }
        public string Stinkiness { get; set; }
        public string Coolness { get; set; }

        public CoolData()
        {
            Name = string.Empty;
            Ugliness = string.Empty;
            Stinkiness = string.Empty;
            Coolness = string.Empty;
        }

        public CoolData(string line)
        {
            // Name,Ugliness,Stinkiness,Coolness

            var pieces = line.Split(',');     // separating everything on a comma

            Name = pieces[0];
            Ugliness = pieces[1];
            Stinkiness = pieces[2];
            Coolness = pieces[3];
            

        }

        public override string ToString()
        {
            return (Name + " (Ugliness: " + Ugliness + " Stinkiness: " + Stinkiness + " Coolness: " + Coolness);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_19
{
    class Person
    {
        public string Name { get; private set; }
        public bool HasGlasses { get; private set; }
        public uint NbLostTeeth { get; private set; }
        public DateTime BirthDate { get; private set; }
        public TimeSpan LostTime { get; private set; }

        public Person(string name, bool HasGlasses, uint NbLostTeeth, DateTime BirthDate, TimeSpan LostTime)
        {
            Name = name;
            this.HasGlasses = HasGlasses;
            this.NbLostTeeth = NbLostTeeth;
            this.BirthDate = BirthDate;
            this.LostTime = LostTime;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"The name is {Name}\n");
            if (HasGlasses)
                s.Append("I have glasses.\n");
            else
                s.Append("I don't have glasses.\n");
            s.Append($"I have lost {NbLostTeeth} teeth. \n");
            s.Append($"I was born the {BirthDate.ToString("dddd, d MMMM yyyy")}\n");
            s.Append($"Finally, I have lost {LostTime.ToString("hh")} hours {LostTime.ToString("mm")} minutes and  {LostTime.ToString("ss")} seconds in my life.");
            return s.ToString();
        }
    }
}

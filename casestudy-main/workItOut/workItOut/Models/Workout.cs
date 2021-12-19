using System;
using System.Collections.Generic;
using System.Text;


namespace workItOut.Models
{
    class Workout : IEquatable<Workout>, IComparable<Workout>
    {
        public string Name { get; set; }
        public Workout()
        {
        }
        public Workout(string symbol, string name)
        {
            Name = name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public bool Equals(Workout other)
        {
            return Name == other.Name;
        }

        public int CompareTo(Workout other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}


    
using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
        private int Id { get; set; }
        private static int NextId = 1;
        private string Value { get; set; }

        // TODO: Task 2: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            Id = NextId;
            NextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();

            return oldestPerson;
                
        }

        public HashSet<Person> GetAllPeopleOver30()
        {
            return this.members
                .Where(x => x.Age > 30)
                .OrderBy(y => y.Name)
                .ToHashSet();
        }
    }
}

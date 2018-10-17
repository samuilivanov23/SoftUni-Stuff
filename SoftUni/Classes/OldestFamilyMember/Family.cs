using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        List<Person> members = new List<Person>();

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMmber()
        {
            int maxAge = members[0].Age;
            int index = 0;
            for(int i = 1; i < members.Count; i++)
            {
                if(maxAge < members[i].Age)
                {
                    maxAge = members[i].Age;
                    index = i;
                }
            }

            return members[index];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamStatistics
{
    class Person
    {
        public string name;
        private int overall;
        private int stamina;
        private int pace;
        private int dribble;
        private int passing;
        private int shooting;

        public Person()
        {}

        public int Overall
        {
            get { return this.overall; }
            private set { this.overall = value; }
        }

        public void SetOverall(Statistics statistics)
        {
            this.overall = statistics.Stamina + statistics.Shooting + statistics.Passing + statistics.Pace + statistics.Dribble;
            this.overall /= 5;
        }
    }
}

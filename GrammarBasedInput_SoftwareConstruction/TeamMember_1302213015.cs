using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_01
{
    public class TeamMember_1302213015
    {
        public List<Member> members { get; set; } = new List<Member>();
    }
    public class Member 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}

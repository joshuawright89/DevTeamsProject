using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class Developer
    {
        public string Name { get; set; }
        public bool HasPluralSight { get; set; }
    }

    public void Developer() { }

    public void Developer(string name, bool hasPluralSight)
    {
        Name = name;
        HasPluralSight = hasPluralSight;
    }


}

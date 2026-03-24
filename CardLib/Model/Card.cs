using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Model;

internal class Card
{
    public Card(string name, string description, object value, ICollection<object> efect)
    {
        Name = name;
        Description = description;
        Value = value;
        Effect = efect;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public Object Value { get; set; }
    public ICollection<Object> Effect { get; set; }

    
}

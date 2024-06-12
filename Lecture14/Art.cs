using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture14
{
    internal class Art
    {
        //Enumerables
        //Keyword: enum

        public enum STYLES { Abstract, Impressionism, Cubism }


        //Fields
        STYLES style;
        String name;

        //Constructor
        public Art(string name, STYLES style)
        {
            this.name = name;
            this.style = style;
        }

        //Properties
        public STYLES Style { get => style; set => style = value; }
        public string Name { get => name; set => name = value; }

        //Methods
        public override string ToString()
        {
            return $"{this.name} - {this.style}";
        }
    }
}

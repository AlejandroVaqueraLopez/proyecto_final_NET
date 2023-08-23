using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_rpg
{
    public class Character
    {
        //Properties
        public string name;
        public string secondName;
        public int hp;
        public int ap;
        public int x;
        public int y;

        //setters & getters
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setSecondName(string secondName)
        {
            this.secondName = secondName;
        }
        public string getSecondName()
        {
            return this.secondName;
        }

    }
}

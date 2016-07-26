using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCCharacters
{
    class Characters : Form1
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string alias;

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string realName;

        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        private string occupation;

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        private string height;

        public string Height
        {
            get { return height; }
            set { height = value; }
        }
        private string weight;

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string Base;

        public string Base1
        {
            get { return Base; }
            set { Base = value; }
        }
        private string allies;

        public string Allies
        {
            get { return allies; }
            set { allies = value; }
        }
        private string foes;

        public string Foes
        {
            get { return foes; }
            set { foes = value; }
        }

        public Characters(string name, string alias, string description, string realName, string occupation, string height, string weight, string Base, string allies, string foes)
        {
            this.name = name;
            this.alias = alias;
            this.description = description;
            this.realName = realName;
            this.occupation = occupation;
            this.height = height;
            this.weight = weight;
            this.Base = Base;
            this.allies = allies;
            this.foes = foes;
        }
    }
}

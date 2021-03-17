

namespace GrandPrix.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseModel
    {

        protected  BaseModel(string name)
        {

            this.Name = name;

        }

        public string Name { get; set; }

        public abstract string Type { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class User : IEntity
    {
        public string Name { get; private set; }

        public User(string name) {
            this.Name = name;
        }
    }
}

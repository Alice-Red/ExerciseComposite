using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class Group :　Many, IEntity {
        public string Name { get; private set; }

        public string Id { get; private set; }


        public Group(string name) {
            Name = name;
        }

        public IEntity[] GetChildren() {
            return entities.ToArray();
        }
    }
}

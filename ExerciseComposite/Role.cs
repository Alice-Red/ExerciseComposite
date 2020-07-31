using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class Role : Many
    {
        public string Name { get; private set; }

        public Role(string name) {
            Name = name;
        }

    }
}

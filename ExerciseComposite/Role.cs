using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class Role : Many, IHaveName
    {
        public string Name { get; }

        public Role(string name) {
            Name = name;
        }

    }
}

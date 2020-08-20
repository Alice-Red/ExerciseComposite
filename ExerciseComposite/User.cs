using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class User : IEntity
    {
        public string Name { get; private set; }

        public string Id { get; private set; }

        public User(string name) {
            Name = name;
        }

        public IEntity[] GetChildren() {
            return null;
        }

        //public void ViewInConsole(int level) {

        //}
    }
}

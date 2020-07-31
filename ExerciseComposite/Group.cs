using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseComposite
{
    public class Group : Many, IEntity, IHaveName
    {

        public string Name { get; private set; }

        public string Id { get; private set; }

        public Group(string name) {
            Name = name;
        }

        public IEntity[] GetChildren() {
            return entities.ToArray();
        }

        public void ViewInConsole(int level) {
            Console.WriteLine($"{string.Join("", Enumerable.Repeat(@"\t", level))}");
            //string tabs = string.Join("", Enumerable.Repeat(@"\t", level));
            foreach (var item in entities) {

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public interface IEntity
    {
        public string Name { get; }
        public string Id { get; }

        public IEntity[] GetChildren();

        public void ViewInConsole(int level);

    }
}

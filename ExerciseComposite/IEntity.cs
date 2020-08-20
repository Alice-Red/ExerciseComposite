using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public interface IEntity : IHaveName
    {
        public string Id { get; }

        //public IEntity[] GetChildren();


    }
}

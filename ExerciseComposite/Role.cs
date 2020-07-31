using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class Role
    {
        public string Name { get; private set; }

        public List<IEntity> entities = new List<IEntity>();

        public Role(string name) {
            Name = name;
        }

        public void SetMember(IEntity entity) {
            entities.Add(entity);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExerciseComposite
{
    public abstract class Many : IEnumerable<IEntity>
    {
        internal List<IEntity> entities = new List<IEntity>();

        public IEntity this[string name] {
            get {
                foreach (var item in entities) {
                    if (item.Name == name)
                        return item;
                }
                return null;
            }
        }

        public void Add(IEntity entity) {
            entities.Add(entity);
        }

        public void SetMember(IEntity entity) {
            entities.Add(entity);
        }

        public IEnumerator<IEntity> GetEnumerator() {
            foreach (var item in entities) {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            foreach (var item in entities) {
                yield return item;
            }
        }
    }
}

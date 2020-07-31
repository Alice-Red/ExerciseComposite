using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciseComposite
{
    public class Group : IEnumerable<IEntity>, IEntity
    {
        public string Name { get; private set; }

        private List<User> users = new List<User>();

        public Group(string name) {
            Name = name;
        }

        public void Add(User user) {
            users.Add(user);
        }

        public IEnumerator<IEntity> GetEnumerator() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }
}

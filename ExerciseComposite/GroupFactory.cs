using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseComposite
{
    public class GroupFactory
    {
        public static GroupFactory Instance = new GroupFactory();

        private ConcurrentDictionary<string, Task<Group>> groups = new ConcurrentDictionary<string, Task<Group>>();

        public Group Get(string name) {
            Task<Group> f = default;
            groups.TryGetValue(name, out f);

            if (f == null) {
                var ft = Task<Group>.Factory.StartNew(() => new Group(name));
                f = groups.GetOrAdd(name, ft);
                if (f == null) {
                    f = ft;
                }
            }
            return f.Result;
        }

    }
}

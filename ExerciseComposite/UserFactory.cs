using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseComposite
{
    public class UserFactory
    {
        public static UserFactory Instance { get; } = new UserFactory();

        ConcurrentDictionary<string, Task<User>> pool = new ConcurrentDictionary<string, Task<User>>();

        public User Get(string name) {
            Task<User> f = default;
           /* var f =*/ pool.TryGetValue(name, out f);

            if (f == null) {
                var ft = Task<User>.Factory.StartNew(() => new User(name));
                f = pool.GetOrAdd(name, ft);
                if (f == null) {
                    f = ft;
                }
            }
            return f.Result;
        }


    }
}

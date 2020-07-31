using System;
using ExerciseComposite;

namespace ExericeCompositeDebugCUI
{
    class Program
    {
        static void Main(string[] args) {
            Role role = new Role("情報システム部");
            Group gp1 = new Group("") {
                new User("Butter"),
                new User("Cherry"),
                new User("Duff"),
            };
            User Asan = new User("Aさん");

            role.SetMember(gp1);
            role.SetMember(Asan);
            
        }
    }
}

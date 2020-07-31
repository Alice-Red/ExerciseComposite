using System;
using System.Threading.Tasks;
using ExerciseComposite;

namespace ExericeCompositeDebugCUI
{
    class Program
    {
        static void Main(string[] args) {

            UserFactory.Instance.Get("Butter");

            Role role = new Role("情報システム部");
            Group gp1 = new Group("group1") {
                UserFactory.Instance.Get("Apple"),
                UserFactory.Instance.Get("Butter"),
                UserFactory.Instance.Get("Cherry"),
                UserFactory.Instance.Get("Duff"),
            };

            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });
            Task.Factory.StartNew(() => {
                User Asan = UserFactory.Instance.Get("Apple");
                role.SetMember(Asan);
            });

            role.SetMember(gp1);


            //Console.WriteLine(UserFactory.Instance.);
            System.Threading.Thread.Sleep(1000);

            Console.ReadLine();
        }
    }
}

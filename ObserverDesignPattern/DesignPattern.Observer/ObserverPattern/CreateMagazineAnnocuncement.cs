using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                Content = "Bilim dergimizin mart sayısı 1 martta evinize ulaştırılacaktır, konular Jupiter Gezegeni ve Mars olacaktır",
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine="Magazine"

            });
            context.SaveChanges();
        }
    }
}

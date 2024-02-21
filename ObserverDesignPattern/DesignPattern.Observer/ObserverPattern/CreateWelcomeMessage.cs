using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                Content = "Bilim dergimize kayıt olduğunuz için çok teşekkür ederiz,dergilerimize web sitemizden ulaşabilirsiniz.",
                NameSurname=appUser.Name+ " "+appUser.Surname,
                
            });
            context.SaveChanges();
        }
    }
}

using DesignPattern.Observer.DAL;
using System.Collections.Generic;

namespace DesignPattern.Observer.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observes;

        public ObserverObject()
        {
            _observes = new List<IObserver>();
        }
         public void RegisterObserver(IObserver observer)
        {
            _observes.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observes.Remove(observer);
        }
        public void NotifyObserver(AppUser appUser)
        {
            _observes.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}

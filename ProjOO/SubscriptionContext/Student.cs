using ProjOO.SharedContext;
using ProjOO.NotificationContext;
{

}

namespace ProjOO.SubscriptionContext
{
    class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }

        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreatSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Primium", " O aluno já está ativo no plano"));
                return;
            }
            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
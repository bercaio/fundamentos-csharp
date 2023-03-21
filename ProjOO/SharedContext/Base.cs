using System;
using ProjOO.NotificationContext;

namespace ProjOO.SharedContext
{
    public abstract class Base : Notifiable
    {
        protected Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }

}
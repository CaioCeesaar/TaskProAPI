using System.Collections.Generic;
using TaskProCore.Interfaces;

namespace TaskProCore.Models.Notifications;

public class Notifier : INotifier
{
    private readonly List<Notification>  _notifications = new();
    
    public bool HaveNotification()
    {
        return _notifications.Count != 0;
    }

    public List<Notification> GetNotifications()
    {
        return _notifications;
    }

    public void Handle(Notification notification)
    {
        _notifications.Add(notification);
    }
}
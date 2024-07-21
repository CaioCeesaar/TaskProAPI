using System.Collections.Generic;
using TaskProCore.Models.Notifications;

namespace TaskProCore.Interfaces;

public interface INotificador
{
    bool HaveNotification();
    List<Notification> GetNotifications();
    void Handle(Notification notification);
}
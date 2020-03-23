using RoteProcessing.Domain.Models.ResponseServices;
using System.Collections.Generic;
using System.Linq;
using Wiz.RoteProcessing.Domain.Interfaces.Notifications;

namespace Wiz.RoteProcessing.Domain.Notifications
{
    public class DomainNotification : IDomainNotification
    {
        private readonly List<NotificationMessage> _notifications;

        public DomainNotification()
        {
            _notifications = new List<NotificationMessage>();
        }

        public IReadOnlyCollection<NotificationMessage> Notifications => _notifications;

        public bool HasNotifications => _notifications.Any();

        public void AddNotification(ResponseService responseService)
        {
            _notifications.Add(new NotificationMessage(responseService.Status.ToString(), responseService.ErrorMessage));
        }
    }
}

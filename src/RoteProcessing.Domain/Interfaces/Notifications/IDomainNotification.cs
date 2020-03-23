using RoteProcessing.Domain.Models.ResponseServices;
using System.Collections.Generic;
using Wiz.RoteProcessing.Domain.Notifications;

namespace Wiz.RoteProcessing.Domain.Interfaces.Notifications
{
    public interface IDomainNotification
    {
        IReadOnlyCollection<NotificationMessage> Notifications { get; }
        bool HasNotifications { get; }
        void AddNotification(ResponseService responseService);
    }
}

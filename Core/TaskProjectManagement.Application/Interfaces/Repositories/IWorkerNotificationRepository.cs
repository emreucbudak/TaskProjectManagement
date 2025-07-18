﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IWorkerNotificationRepository
    {
        Task AddWorkerNotification(WorkerNotification workers);
        Task<IEnumerable<WorkerNotification>> getAllNotification(int userId);
        

    }

}

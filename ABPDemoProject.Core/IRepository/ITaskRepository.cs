using Abp.Domain.Repositories;
using ABPDemoProject.entity;
using ABPDemoProject.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABPDemoProject
{
    public interface ITaskRepository:IRepository<Task,long>
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
    }
}

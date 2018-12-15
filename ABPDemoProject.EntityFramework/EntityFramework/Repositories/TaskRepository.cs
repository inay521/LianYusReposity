using Abp.EntityFramework;
using ABPDemoProject.entity;
using ABPDemoProject.enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ABPDemoProject.EntityFramework.Repositories
{
    public class TaskRepository : ABPDemoProjectRepositoryBase<Task, long>, ITaskRepository
    {
        public TaskRepository(IDbContextProvider<ABPDemoProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
        {
            //在仓储方法中，不用处理数据库连接、DbContext和数据事务，ABP框架会自动处理。

            var query = GetAll(); //GetAll() 返回一个 IQueryable<T>接口类型

            //添加一些Where条件

            if (assignedPersonId.HasValue)
            {
                query = query.Where(task => task.AssignedPerson.Id == assignedPersonId.Value);
            }

            if (state.HasValue)
            {
                query = query.Where(task => task.State == state);
            }

            return query
                .OrderByDescending(task => task.CreationTime)
                .Include(task => task.AssignedPerson)
                .ToList();
        }
    }
}

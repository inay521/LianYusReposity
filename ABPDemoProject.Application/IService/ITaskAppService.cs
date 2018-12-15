using Abp.Application.Services;
using ABPDemoProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPDemoProject.IService
{
    public interface ITaskAppService:IApplicationService
    {
        GetTasksOutput getTasks(GetTasksInput input);
        void UpdateTask(UpdateTaskInput input);
        void CreateTask(CreateTaskInput input);
    }
}

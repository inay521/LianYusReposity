using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABPDemoProject.enums;

namespace ABPDemoProject.DTO
{
    public class GetTasksInput
    {
        public int AssignedPersonId;
        public TaskState? State;
    }
}

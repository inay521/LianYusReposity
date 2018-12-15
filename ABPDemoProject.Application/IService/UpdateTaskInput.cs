using Abp.Runtime.Validation;
using ABPDemoProject.DTO;
using ABPDemoProject.enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABPDemoProject.IService
{
    public class UpdateTaskInput : IInputDto, ICustomValidate
    {
        [Range(1, long.MaxValue)]
        public long TaskId { get; set; }

        public int? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }

        public void AddValidationErrors(List<ValidationResult> results)
        {
            if (AssignedPersonId == null && State == null)
            {
                results.Add(new ValidationResult("AssignedPersonId和State不能同时为空!", new[] { "AssignedPersonId", "State" }));
            }
        }

        public void AddValidationErrors(CustomValidationContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
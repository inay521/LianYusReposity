using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPDemoProject.DTO
{
    public class CreateTaskInput : IInputDto
    {
        public int? AssignedPersonId { get; set; }

        [Required]
        public string Description { get; set; }
    }

    public interface IInputDto
    {
    }
}

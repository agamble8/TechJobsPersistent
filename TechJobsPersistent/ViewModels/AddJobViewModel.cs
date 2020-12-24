using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employer must be selected")]
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        // Step 3.1
        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> allSkills)
        {
            Skills = allSkills;

            Employers = new List<SelectListItem>();

            foreach (var employer in possibleEmployers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }

        public AddJobViewModel()
        {
        }

    }
}

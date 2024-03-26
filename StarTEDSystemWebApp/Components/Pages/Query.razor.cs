using Microsoft.AspNetCore.Components;
using StarTEDSystemDB.BLL;
using StarTEDSystemDB.Entities;

namespace StarTEDSystemWebApp.Components.Pages
{
    public partial class Query
    {
        [Inject]
        CourseServices CourseServices { get; set; }

        [Inject]
        ProgramServices ProgramServices { get; set; }

        [Inject]
        ProgramCourseServices ProgramCourseServices { get; set; }

        //Required properties
        public List<StarTEDSystemDB.Entities.Program> Programs { get; set; } 
        public List<Course> Course { get; set; }

        public List<string> errorList = new List<string>();
        public string feedback { get; set; }

        [Parameter]
        public int ProgramId { get; set; }

        protected override Task OnInitializedAsync()
        {
            return Task.Run(() =>
            {
                Programs = ProgramServices.GetAllPrograms();

                if (ProgramId != 0)
                {
                }
            });
        }



    }
}

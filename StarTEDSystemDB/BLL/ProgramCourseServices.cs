using StarTEDSystemDB.DAL;
using StarTEDSystemDB.Entities;


namespace StarTEDSystemDB.BLL
{
    public class ProgramCourseServices
    {
        private readonly StarTEDContext _context;

        internal ProgramCourseServices(StarTEDContext context)
        {
            _context = context;
        }

        public List<ProgramCourse> GetAllProgramCourses()
        {
            return _context.ProgramCourses.ToList<ProgramCourse>();
        }
    }
}

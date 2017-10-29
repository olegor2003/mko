namespace Mko.ObjectModel.Model
{
    public class SchoolYear
    {
        public int Id { get; set; }

        public int PupilId { get; set; }

        public int YearId { get; set; }

        public int GradeId { get; set; }

        //public ICollection<Pupil>  Pupils { get; set; }

        //public ICollection<Year> Years { get; set; }

        //public ICollection<Grade> Grades { get; set; }
    }
}

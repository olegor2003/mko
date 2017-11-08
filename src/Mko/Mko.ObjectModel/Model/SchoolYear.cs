namespace Mko.ObjectModel.Model
{
    public class SchoolYear
    {
        public int Id { get; set; }

        public int PupilId { get; set; }

        public int YearId { get; set; }

        public int GradeId { get; set; }

        public Pupil Pupil { get; set; }

        public Grade Grade { get; set; }

        public Year Year { get; set; }
    }
}

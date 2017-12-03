namespace Mko.ObjectModel.Model
{
    public class Mark : BaseEntity
    {
        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        public int PupilId { get; set; }

        public int? Value { get; set; }

        public Year Year { get; set; }

        public int YearId { get; set; }

        public Period Period { get; set; }
    }
}
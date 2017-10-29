namespace Mko.ObjectModel.Model
{
    public class SubjectCriteria
    {
        public int Id { get; set; }

        public Subject Subject { get; set; }

        public Range Satisfactorily { get; set; }

        public Range Good { get; set; }

        public Range Excellent { get; set; }
    }
}
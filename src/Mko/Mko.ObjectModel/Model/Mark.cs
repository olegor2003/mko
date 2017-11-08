namespace Mko.ObjectModel.Model
{
    public class Mark: BaseEntity
    {
        public Subject Subject { get; set; }

        public Pupil Pupil { get; set; }

        public int Value { get; set; }

        public Year Year { get; set; }

        public Periods Period { get; set; }
    }
}
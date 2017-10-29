namespace Mko.ObjectModel.Model
{
    public class Mark
    {
        public int Id { get; set; }

        public Subject Subject { get; set; }

        public Pupil Pupil { get; set; }

        public int Value { get; set; }

        public Year Year { get; set; }
    }
}
namespace Mko.ObjectModel.Model
{
    public class Subject: BaseEntity
    {
        public Parallel Parallel { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Mko.ObjectModel.Model
{
    // TODO move to fluent
    [ComplexType]
    public class Range
    {
        public int From { get; set; }

        public int To { get; set; }
    }
}
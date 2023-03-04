using System.ComponentModel.DataAnnotations;

namespace DateGen.Models
{
    public class DateInfo
    {
        private Guid id { get;}
        private DateTime date { get;}

        public int? start { get; set; }
        public int? end { get; set; }

        public DateInfo(Guid id, DateTime date, int? start, int? end)
        {
            this.id = id;
            this.date = date;
            this.start = start;
            this.end = end;
        }
    }
}

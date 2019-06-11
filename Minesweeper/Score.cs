using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    [Serializable]
    public class Score : IComparable<Score>
    {
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public DateTime Date { get; set; }

        public Score(string name, int min, int sec)
        {
            Date = DateTime.Now;
            Name = name;
            Minutes = min;
            Seconds = sec;
        }

        public override string ToString()
        {
            return string.Format("{0,-25} {1:00}:{2:00} - {3:00}/{4:00}/{5}", Name, Minutes, Seconds, Date.Day, Date.Month, Date.Year);
        }

        public int CompareTo(Score other)
        {
            if (this.Minutes == other.Minutes && this.Seconds == other.Seconds) return this.Date.Millisecond - other.Date.Millisecond;
            if (this.Minutes == other.Minutes) return this.Seconds - other.Seconds;
            return this.Minutes - other.Minutes;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
                return false;
            Score s = (Score)obj;
            return this.Date == s.Date && this.Minutes == s.Minutes && this.Seconds == s.Seconds && this.Name == s.Name;
        }
    }
}

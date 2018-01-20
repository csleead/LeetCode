namespace LeetCode.Problem56
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }

        public override string ToString() => $"[{start}, {end}]";

        public override bool Equals(object obj)
        {
            var that = obj as Interval;
            if(that == null)
                return false;

            return start == that.start && end == that.end;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + start.GetHashCode();
                hash = hash * 23 + end.GetHashCode();
                return hash;
            }
        }
    }
}

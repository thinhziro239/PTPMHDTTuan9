using System.Data;

namespace HoHuuThinh_1150080037_BTtuan9
{
    internal class Sqlflarameter
    {
        private string v;
        private SqlDbType @char;

        public Sqlflarameter(string v, SqlDbType @char)
        {
            this.v = v;
            this.@char = @char;
        }
    }
}
using System;
namespace ekstraøvelser
{
    public class Bjcard: card
    {
      
        public Bjcard(string s, int r ) : base (s,r)
        {
          if (r == 14)
            {
                r = 14;
            }
          if (r >= 10)
            {
                r = 10;
            }
        }
    }
}

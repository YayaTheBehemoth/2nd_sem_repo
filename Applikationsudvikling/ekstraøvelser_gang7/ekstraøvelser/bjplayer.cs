using System;
namespace ekstraøvelser
{
     class bjplayer: player
    {
      
        private card _card0;
        private card _card1;
        private card _card2;
      

        public bjplayer(string n, int p = 0) :base (n,p)
        {
          
            _card0 = null;
            _card1 = null;
            _card2 = null;
           
        }

        public card card0
        {
            get { return _card0; }
            set { _card0 = value; }
        }
        public card card1
        {
            get { return _card1; }
            set { _card1 = value; }
        }
        public card card2
        {
            get { return _card2; }
            set { _card2 = value; }
        }

        public int countHand()
        {
            int hand = _card0.rank + _card1.rank;
            if (!(_card2 == null))
            {
               hand = hand + _card2.rank;
            }
            return hand;
        }
        public void emptyHand()
        {

            _card0 = null;
            _card1 = null;
            _card2 = null;
        }
        public void convertAce(card c)
        {
            
      
            
                c.rank = 11;
                if (this.countHand() > 21)
                {
                    c.rank = 1;
                }
            
        }
    }
}

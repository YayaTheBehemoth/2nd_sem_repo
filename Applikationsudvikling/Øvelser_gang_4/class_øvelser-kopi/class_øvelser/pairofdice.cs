using System;
namespace class_øvelser
{
    public class pairofdice : Dice

    {
        
        private Dice a;
        private Dice b;
       

        public pairofdice()
        {
            a = new Dice();
            b = new Dice();

        }
      

        public void shakeIt()
        {
            a.Throw();
            b.Throw();
        }
        public int showTotal()
        {
            int a_eyes = a.show();
            int b_eyes = b.show();
            int total = a_eyes + b_eyes;
            return total; 

            
        }
    }
}

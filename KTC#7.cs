namespace st
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefauldAttak defAttak = new DefauldAttak();
            AngerAttak angerAttak = new AngerAttak();
            Enemy enemy = new Enemy(defAttak, 30);
            enemy.Attak();
            if (enemy.NeedAngerAttak())
            {
                enemy.curAttak = angerAttak;
                enemy.Attak();
            }
        }
    }
    public interface IAttak
    {
        public void Attak();
    }
    class AngerAttak : IAttak
    {
        public void Attak()
        {
            Console.WriteLine("AAAAAARRRRRR");
        }
    }
    class DefauldAttak : IAttak
    {
        public void Attak()
        {
            Console.WriteLine("aaaaaarrrrrrr");
        }
    }
    class Enemy
    {
       public IAttak curAttak {  get; set; }
       private int hp;
       public Enemy(IAttak attak, int hp)
       {
            curAttak = attak;   
            this.hp = hp;
       }
       
       public void Attak()
       {
            curAttak.Attak();
       }
        public bool NeedAngerAttak()
        {
            if(hp <= 50)
            {
                return true;
            }
            return false;
        }
    }
}

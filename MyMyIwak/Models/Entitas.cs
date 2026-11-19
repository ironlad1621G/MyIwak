namespace MyMyIwak.Models
{
    public abstract class Entitas
    {
        private int id;

        public int Id
        {
            get { return id; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ID tidak boleh negatif");
                }
                id = value;
            }
        }

        protected Entitas(int id)
        {
            this.Id = id;
        }

        public abstract string Deskripsikan();

        public override string ToString()
        {
            return Deskripsikan();
        }
    }
}

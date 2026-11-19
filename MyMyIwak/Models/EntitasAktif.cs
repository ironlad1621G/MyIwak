namespace MyMyIwak.Models
{
    public abstract class EntitasAktif : Entitas
    {
        private bool is_active;

        public bool Is_active
        {
            get { return is_active; }
            private set { is_active = value; }
        }

        protected EntitasAktif(int id, bool is_active) : base(id)
        {
            this.Is_active = is_active;
        }

        public virtual void Nonaktifkan()
        {
            Is_active = false;
        }

        public void Aktifkan()
        {
            Is_active = true;
        }
    }
}

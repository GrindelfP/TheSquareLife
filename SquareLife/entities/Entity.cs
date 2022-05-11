namespace SquareLife
{
    internal abstract class Entity
    {
        protected bool Status { get; set; }
        protected string Id { get; set; } 
        public virtual void Appear() { }
        public virtual void Move() { }
        public virtual void GiveBirth() { }
        public virtual void Swallow() { }
        public virtual void Disappear() { }
        public Entity(bool status, string id)
        {
            Status = status;
            Id = id;
        }
    }
}

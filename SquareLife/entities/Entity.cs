namespace SquareLife
{
    internal abstract class Entity
    {
        protected string Color { get; set; }
        protected int Size { get; set; }
        protected string Id { get; set; }
        protected abstract Position Position();
        protected abstract Position Move();
        public Entity(string id, Position originalPosition)
        {
            Id = id;
            Color = ""; //!
            Size = 1; //!
        }
    }
}
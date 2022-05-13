namespace SquareLife
{
    internal abstract class Entity
    {
        protected string EntColor { get; set; }
        protected EntitySize EntSize { get; set; }
        protected string Id { get; set; }
        protected abstract Position Position();
        protected abstract Position Move();
        public Entity(string id, Position originalPosition)
        {
            Id = id;
            EntColor = ""; //!
            EntSize = EntitySize.MIN_ENTITY_AREA_SIZE; //!
        }
    }
}
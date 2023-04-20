namespace BorderControl
{
    public abstract class Identifiable
    {
        protected Identifiable(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public bool IsFake(string value) => this.Id.EndsWith(value);
    }
}

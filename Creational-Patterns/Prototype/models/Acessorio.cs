namespace Prototype.models
{
    public class Acessorio : ICloneable
    {
        public string Nome { get; set; } = string.Empty;

        public object Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}
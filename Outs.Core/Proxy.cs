namespace Outs.Core
{
    public class Proxy<TValue>
    {
        public TValue? Value { get; private set; }
        public bool IsValueSetted { get; private set; }

        internal void SetValue(TValue? value)
        {
            this.Value = value;
            this.IsValueSetted = true;
        }
    }
}
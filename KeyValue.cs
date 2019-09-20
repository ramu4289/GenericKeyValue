namespace GenericKeyValue
{
    public class KeyValue<T> where T : struct
        //public struct KeyValue<T>
    {
        public readonly string key;
        public readonly T value;

        public KeyValue(string _key, T _value)
        {
            this.key = _key;
            this.value = _value;
        }
    }
}

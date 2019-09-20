using System.Collections.Generic;

namespace GenericKeyValue
{
    class MyDictionary
    {


        private KeyValue<object>[] keyValues = new KeyValue<object>[]
        {
                    new KeyValue<object>("Water", 50),
                    new KeyValue<object>("Monster", 20),
                    new KeyValue<object>("Coffee", 44),
                    new KeyValue<object>("RedBull", 39),
        };


        private int Length
        {
            get
            {
                return keyValues.Length;
            }
        }

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (key.ToLower() == keyValues[i].key.ToLower())
                    {
                        return keyValues[i].value;
                    }
                }
                throw new KeyNotFoundException();
            }
            //make new generic , copy new generic
            set
            {
                KeyValue<object>[] newKeyValues = new KeyValue<object>[Length + 1];

                for (int i = 0; i < Length; i++)
                {
                    if (key.ToLower() == keyValues[i].key.ToLower())
                    {
                        keyValues[i] = new KeyValue<object>(key, value);
                    }
                    if (i == keyValues.Length - 1)
                    {
                        newKeyValues = keyValues;
                        keyValues = new KeyValue<object>[Length + 1];

                        for (int j = 0; j < newKeyValues.Length; j++)
                        {
                            keyValues[j] = newKeyValues[j];
                        }

                        break;

                    }
                }
                keyValues[keyValues.Length - 1] = new KeyValue<object>(key, value);
            }

        }
    }
}

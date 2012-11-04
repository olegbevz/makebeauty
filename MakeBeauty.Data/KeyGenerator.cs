namespace MakeBeauty.Data
{
    using System.Collections.Generic;
    using System.Linq;

    public static class KeyGenerator
    {
        public static int Generate(IEnumerable<int> keys)
        {
            var key = 0;

            while (keys != null && keys.Any(k => k == key))
            {
                key++;
            }

            return key;
        }
    }
}
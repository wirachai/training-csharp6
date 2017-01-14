using System;
namespace ExtensionMethod.Sample
{
    public static class NullExtension
    {
        public static bool IsNull(this object x)
        {
            return x == null;
        }
    }
}

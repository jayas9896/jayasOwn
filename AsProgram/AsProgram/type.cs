namespace AsProgram
{
    internal static class type<U>
    {
        public static bool IS<T>(T obj)
        {
            try
            {
                U b = (U)(object)obj;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static U AS<T>(T obj)
        {
            if (IS(obj))
            {
                return (U)(object)obj;
            }
            else
            {
                return default(U);
            }
        }
    }
}

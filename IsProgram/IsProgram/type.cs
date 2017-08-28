namespace IsProgram
{
    public static class type<U>
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
    }
}

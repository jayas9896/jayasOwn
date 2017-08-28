namespace EqualsProgram
{
    class Class1
    {
        public int i;
        public float f;
        public double d;
        public decimal d2;        
        public bool MyEquals(object obj)
        {
            if(obj is Class1)
            {
                return this == (Class1)obj;
            }
            else
            {
                return false;
            }
        }
        public static bool MyEquals(object obj1, object obj2)
        {
            if(obj1 is Class1)
            {
                return ((Class1)obj1).MyEquals(obj2);
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Class1 obj1, Class1 obj2)
        {
            return ((obj1.i == obj2.i) && (obj1.d == obj2.d) && (obj1.f == obj2.f) && (obj1.d2 == obj2.d2));
        }
        public static bool operator !=(Class1 obj1, Class1 obj2)
        {
            return !(obj1 == obj2);
        }
        public static bool MyReferenceEquals(Class1 obj1, Class1 obj2)
        {
            return (object)obj1 == obj2;
        }
        public override bool Equals(object obj1)
        {
            return this.MyEquals(obj1);
        }
    }
}

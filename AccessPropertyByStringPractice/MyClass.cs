using System.Reflection;

namespace AccessPropertyByStringPractice
{
    public class MyClass
    {
        public int MyProperty1 { get; }
        public int MyProperty2 { get; }
        public int MyProperty3 { get; }

        public MyClass()
        {
            MyProperty1 = 10;
            MyProperty2 = 20;
            MyProperty3 = 30;
        }

        public int this[string propertyName]
        {
            get
            {
                return (int)typeof(MyClass).GetProperty(propertyName).GetValue(this);
            }
            set
            {
                typeof(MyClass).GetProperty(propertyName).SetValue(this, (int)value);
            }
        }
    }
}

namespace Tips.Entities
{
    internal class A { }

    internal class B : A { }

    internal class C : B { }

    internal class ConstrainedByBase<T> where T : B
    {
        internal T GetObj(T data)
        {
            return data;
        }
    }
}

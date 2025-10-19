interface IVisitor { void Visit(ElementA a); }
interface IElement { void Accept(IVisitor v); }

class ElementA : IElement { public void Accept(IVisitor v) => v.Visit(this); }

class ConcreteVisitor : IVisitor { public void Visit(ElementA a) => Console.WriteLine("Visited A"); }

class Program
{
    static void Main()
    {
        IElement e = new ElementA();
        e.Accept(new ConcreteVisitor());
    }
}


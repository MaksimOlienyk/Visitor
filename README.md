# Visitor - Патерн Проєктування

Патерн Visitor дозволяє додавати нові операції для об'єктів без зміни їхніх класів.  
Він розділяє алгоритми і структуру об’єктів, які ці алгоритми опрацьовують.

## Ідея

- Кожен об’єкт реалізує метод `Accept`, який приймає **Visitor**.
- Visitor реалізує методи для різних типів елементів.
- Таким чином можна додавати нові операції, не змінюючи самі елементи.

## Структура

| Елемент           | Опис |
|------------------|------|
| `IElement`        | Інтерфейс елементів, які можуть приймати Visitor |
| `ElementA`        | Конкретний елемент |
| `IVisitor`        | Інтерфейс Visitor з методами для кожного типу елемента |
| `ConcreteVisitor` | Реалізація Visitor, яка виконує операції над елементами |
| Клієнт            | Викликає `Accept` для елемента, передаючи Visitor |

## Код

```csharp
interface IVisitor { void Visit(ElementA a); }
interface IElement { void Accept(IVisitor v); }

class ElementA : IElement { 
    public void Accept(IVisitor v) => v.Visit(this); 
}

class ConcreteVisitor : IVisitor { 
    public void Visit(ElementA a) => Console.WriteLine("Visited A"); 
}

class Program {
    static void Main() {
        IElement e = new ElementA();
        e.Accept(new ConcreteVisitor());
    }
}

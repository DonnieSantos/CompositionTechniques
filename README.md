# Quality Code with Dependency Inversion

Writing code that works is easy; writing code that is high quality is not. In over two decades as a programmer, I’ve seldom encountered individuals or software teams who predictably and consistently turn out releases with high [Internal Quality](https://en.wikipedia.org/wiki/Software_quality) resulting in [Testability](https://en.wikipedia.org/wiki/Software_testability), lower amounts of [Technical Debt](https://en.wikipedia.org/wiki/Technical_debt) and higher ease of making future enhancements and bug fixes. As far as I can tell, the reason for this is that programmers, testers, analysts and managers alike have trouble understanding how Internal Quality has a stronger [Economic Impact on the Bottom Line](https://www.amazon.com/Economics-Software-Quality-Capers-Jones/dp/0132582201) than speed to market for large software projects that have a long life-span. In all of my experience strictly relating to Object Oriented Programming concepts, the best guide for achieving software quality is found in the understanding of [SOLID Design Principles](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)).

In this small repository, I am focusing on illustrating introductory techniques for [Dependency Inversion](https://en.wikipedia.org/wiki/Dependency_inversion_principle), one of the most important SOLID principles. Since one of the most common causes of inter-object dependencies wreaking havoc on maintainability is the lack of understanding of [Class Responsibilities](https://en.wikipedia.org/wiki/Single_responsibility_principle), and in particular the overuse (or use at all) of [Inheritance](https://en.wikipedia.org/wiki/Inheritance_(object-oriented_programming)), I will focus on the well-known example of [Composition Over Inheritance](https://en.wikipedia.org/wiki/Composition_over_inheritance). The simple code examples here hopefully dispel the common argument that Inheritance is “easier to read”, which is the only argument I’ve ever heard for why it should ever be used. In my estimation, there is no reason to ***ever*** use Inheritance, as Composition has all its strengths without any of its weaknesses, primarily the awful problem of [Class Coupling](https://en.wikipedia.org/wiki/Coupling_(computer_programming)).

# Composition Over Inheritance

The big selling points of Inheritance are:

- **Reusability**: Derived classes inherit code for reuse.
- **Extensibility**: Derived classes can override or extend class methods.
- **Polymorphism**: Run-time concrete behavior determination for abstractly typed instances.

The biggest problem of Inheritance is class coupling. In large projects, it can make rework a nightmare, making it extremely difficult to apply a small change without cascading breaking changes across modules and tests.
The alternative is Object Composition, which literally has all the advantages of Inheritance with no need for class coupling. I have asked perhaps over one hundred extremely accomplished developers to provide me with a reason to use Inheritance, and the only argument I have been given is “It’s easier”. I hope these meager code examples show that object composition is very easy even for a beginner.

# Fundamentals of Design

Implementing Composition is fairly trivial. You merely change your design from the ***“is a”*** model of Inheritance to a ***“has a”*** model with Interfaces. Instead of an object obtaining its behaviors through Inheritance because of what it ***is***, the object instead should not really be or do much other than be a composite of other smaller objects, abstractly typed, which provide behaviors. Simply put, instead of inheriting from a base class that provides methods for A, B and C… The class should ***have*** three objects, typed as interfaces, that will be instantiated during runtime by some *other thing* that fulfills the promised behaviors for interfaces A, B and C. That’s it. Really.

# Choosing a Creation Pattern

Any [Creation Pattern](https://en.wikipedia.org/wiki/Creational_pattern) can be used to be the thing which makes the decisions as to which concrete object will be obtained for the interface types at runtime. Some of these include but are not limited to:

- **Constructors**: Constructor requires concrete types adhering to interfaces.
- **Factories**: Some other object decides which concrete types you will receive.
- **Dependency Injection**: Some other library provides concretions by configuration.

There are plenty of other [Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns) well documented in famous books and articles that you can improvise with as long as you do not break **SOLID Principles**. None of the implementation details in my code are important; actually, I went out of my way to write them in the least sophisticated way possible to make them accessible to beginners. The only thing I am trying to showcase in my code is the simple nature of Object Composition, why it is not harder than Inheritance, and why it is always better than Inheritance in the long run.

## Code Examples

- **Chess**: [Source Code](https://github.com/DonnieSantos/CompositionTechniques/tree/master/ChessComposition) and [Unit Tests](https://github.com/DonnieSantos/CompositionTechniques/tree/master/ChessCompositionTests).
- **Shapes**: [Source Code](https://github.com/DonnieSantos/CompositionTechniques/tree/master/ShapeComposition) and [Unit Tests](https://github.com/DonnieSantos/CompositionTechniques/tree/master/ShapeCompositionTests).

## Super Short Example

**Basically, instead of using Inheritance like this:**

```cs
abstract class Mammal
{
	public abstract bool HasFins();
}

class Dolphin: Mammal
{
	public override bool HasFins()
	{
		return true;
	}
}

class Human: Mammal
{
	public override bool HasFins()
	{
		return false;
	}
}

Mammal dolphin = new Dolphin();
Mammal human = new Human();

System.Console.WriteLine(dolphin.HasFins());
System.Console.WriteLine(human.HasFins());
```

**You would use Composition similar to this:**

```cs
public interface CanHaveFins
{
	bool HasFins();
}

class DoesHaveFins: CanHaveFins
{
	public bool HasFins() { return true; }
}

class DoesNotHaveFins: CanHaveFins
{
	public bool HasFins() { return false; }
}

class Mammal
{
	private CanHaveFins _canHaveFins;

	public Mammal(CanHaveFins canHaveFins)
	{
		_canHaveFins = canHaveFins;
	}

	public bool HasFins()
	{
		return _canHaveFins.HasFins();
	}
}

Mammal dolphin = new Mammal(new DoesHaveFins());
Mammal human = new Mammal(new DoesNotHaveFins());

System.Console.WriteLine(dolphin.HasFins());
System.Console.WriteLine(human.HasFins());
```

# Design Review

The primary quality of Dependency Inversion is that **concrete type dependencies are not created, referenced, or even known within a class** but instead are provided from something else. It’s of the utmost importance that the class never, ever knows which concrete types it will be referring to inside of its actual class definition. **That is what it means to invert dependencies.** Some other thing will be responsible for determining the concrete types, not the object itself.

If a class instantiates, inherits from, or even references a concrete type, it then becomes coupled to that type, and will become susceptible to breaking changes from outside of itself. This might not seem like a big deal at first, but any project that grows to hundreds of classes, and tens of thousands of lines of code, with more than a few programmers working on it simultaneously, and which needs to be constantly maintained for more than a few months, will become excruciatingly hard to modify without heavy refactoring and costly regression testing. It can take even a very talented developer many years of experience before they fully realize and comprehend the cost benefit of a highly decoupled design.
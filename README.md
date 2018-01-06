# The Economics of Software Quality

Writing code that works is easy; writing code that is high quality is not. In over two decades as a programmer, I’ve seldom encountered individuals or software teams who successfully and consistently turn out releases with high [Internal Quality](https://en.wikipedia.org/wiki/Software_quality) resulting in [Testability](https://en.wikipedia.org/wiki/Software_testability), lower amounts of [Technical Debt](https://en.wikipedia.org/wiki/Technical_debt) and higher ease of making future enhancements and bug fixes. As far as I can tell, the reason for this is that programmers, testers, analysts and managers alike have trouble understanding that Internal Quality has a stronger [Economic Impact](https://www.amazon.com/Economics-Software-Quality-Capers-Jones/dp/0132582201) on the bottom line than speed to market for large software projects that have a long life-span. In my estimation, and strictly relating to Object Oriented Programming, the best guide for achieving software quality is found in the understanding of [SOLID Design Principles](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)).

# Dependency Inversion

In this small repository, I am focusing on illustrating introductory techniques for [Dependency Inversion](https://en.wikipedia.org/wiki/Dependency_inversion_principle). This is also sometimes referred to as [Composition Over Inheritance](https://en.wikipedia.org/wiki/Composition_over_inheritance). The simple code examples here hopefully dispel the common argument that Inheritance is “easier to read”, which is the only argument I’ve ever heard for why it should ever be used. In my estimation, there is no reason to ***ever*** use Inheritance, as Composition has all its strengths without any of its weaknesses, primarily the awful problem of [Class Coupling](https://en.wikipedia.org/wiki/Coupling_(computer_programming)).

# The Problem With Inheritance

The big selling points of Inheritance are:

- **Reusability**: Derived classes inherit code for reuse.
- **Extensibility**: Derived classes can override or extend class methods.
- **Polymorphism**: Run-time concrete behavior determination for abstractly typed instances.

The biggest problem of inheritance is class coupling. In large projects, it can make rework a nightmare, making it extremely difficult to apply a small change without cascading breaking changes across modules and tests.
The alternative is Object Composition, which literally has all the advantages of Inheritance with no need for class coupling. I have asked perhaps over one hundred extremely accomplished developers to provide me with a reason to use Inheritance, and the only argument I have been given is “It’s easier”. I hope these meager code examples show that object composition is very easy even for a beginner.

# How To Do It

Implementing Composition is fairly trivial. You merely change your design from the ***“is a”*** model of Inheritance to a ***“has a”*** model with Interfaces. Instead of an object obtaining its behaviors through Inheritance because of what it ***is***, the object instead should not really be or do much other than be a composite of other smaller objects, abstractly typed, which provide behaviors. Simply put, instead of inheriting from a base class that provides methods for A, B and C… The class should ***have*** three objects, typed as interfaces, that will be instantiated during runtime by some *other thing* that fulfills the promised behaviors for interfaces A, B and C. That’s it. Really.

# Implementation Details

The primary quality of Dependency Inversion is that **concrete dependencies are not created, contained, or even known within a class** (as is the case with instantiating concrete types inside of a class by using the “new” keyword, or by inheriting from another class; both of these result in hard coupling) but instead are given from somewhere else, resulting in the class not actually knowing which concrete objects it will be given. It’s of the utmost importance that the class never, ever knows which concrete types it will be referring to inside of its actual class definition. **That is what it means to invert dependencies.** Some other thing will be responsible for determining the concrete types, not the object itself.

# Creation Patterns

Any [Creation Pattern](https://en.wikipedia.org/wiki/Creational_pattern) can be used to be the thing which makes the decisions as to which concrete object will be obtained for the interface types at runtime. Some of these include but are not limited to:

- **Constructors**: Constructor requires concrete types adhering to interfaces.
- **Factories**: Some other object decides which concrete types you will receive.
- **Dependency Injection**: Some other library provides concretions by configuration.

There are plenty of other [Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns) well documented in famous books and articles that you can improvise with as long as you do not break **SOLID Principles**. None of the implementation details in my code are important; actually, I went out of my way to write them in the least sophisticated way possible to make them accessible to beginners. The only thing I am trying to showcase in my code is the simple nature of Object Composition, why it is not harder than Inheritance, and why it is always better than Inheritance in the long run.
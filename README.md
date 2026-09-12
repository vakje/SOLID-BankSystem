# Learning SOLID principles. 

# BackStory
This task was one of our first projects for learning C#. It is a simple Console application that was supposed to 
familiarize us with C#'s OOP style, etc. The first commit was the project that I submitted. 
I came back to it later to have the simple sandbox-like project where I could play around and, along the way, learng something valuable.

I did learn SOLID, but my current implemenation is not that ideal. Here is my concerns about this project, my thoughts
on my current implementation, what I have learnd, etc.

# SRP
This principle is simple: one responsibility per class. You should separate responsibilities so you don't end up with bloated classes.
I think I did this rule better than the others. 
```csharp
   public class BankAccGenerator
    {
       ... some code ... 

        private static int GenerateRandomId() => _Random.Next(min, int.MaxValue);

        public List<DepositAccount> CreateDepositAccounts => new List<DepositAccount>
        {
            new DepositAccount("saxeli saxelashvili", 500000, GenerateRandomId(), 1.3),
            new DepositAccount("saxeli saxelashvdze", 50000, GenerateRandomId(), 1.3),
            new DepositAccount("lashvardi saxelashvili", 500, GenerateRandomId(), 1.3)
        };
       ... some code ...
    }
```
Instead of dumping the creation of the objects into the Main program like I had before, 
I made a separate class where I separated the responsibility of creating the classes into another class called BankAccGenerator, 
instead of having it inside the main program class.
# OCP
The Open/Closed Principle basically means that you should be able to easily extend the functionality of classes without having to rewrite previously written functionality.
I did it fairly easily Maybe not in the whole project but mostly you can say that I have this priciple down.
# LSP
So here they simply mean that you should be able to easily replace one object with another without ruining the program's correctness.
Well, My implementation follows LSP because the child classes can be used through an Accounts reference, 
and the functionality defined by the base class continues to work correctly through the derived implementations.
# ISP
Well, basically, it forces you not to make your classes depend on interfaces whose functionality they do not use.
When I wanted to learn this principle, I forcibly created a few different interfaces like this one:
```csharp
   internal interface IDepositable
    {
        //template for depositing
        void deposit(decimal amount);
    }
```
Because if you want to follow this principle, you should first understand what problem it is trying to solve. 
So I made a few smaller interfaces like this one and started using them throughout the project.
This helped me understand the idea behind ISP: instead of having one large interface that contains functionality a class might not need, 
you can split it into smaller, more specific interfaces.

At first, I thought this would be a straightforward improvement to the project. But once I started combining these interfaces with my existing inheritance and polymorphism,
things became more complicated than I expected. This is where I started questioning whether I was actually improving the design or just overengineering a simple project.
and Yes i think in reality I do second more but at least I am learning.
# DIP
I tried to follow this principle, which states that high-level modules should depend on abstractions, not on concrete details or low-level modules.
I mostly worked on this within my Main program, where I previously had a lot of code for testing my program. 
I moved most of that code out of Main and into separate classes. It is not ideal yet, but I think it is going in the right direction.
```csharp
   public static void Main()
        {
            try
            {
                BankAccGenerator generator = new BankAccGenerator();
                BankAccSimulator simulation = new BankAccSimulator();

                var accounts = generator.CreateBankAccounts;
                var depositaccounts = generator.CreateDepositAccounts;
                var creditaccounts = generator.CreateCreditAccounts;

                simulation.Simulation(accounts, depositaccounts, creditaccounts);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }

            }
```
What I think is good about this implementation is that Main is no longer manually creating accounts and testing their functionality. 
Instead, it is calling higher-level components such as BankAccGenerator and BankAccSimulator, which handle those responsibilities separately.

It is not a perfect example of DIP, because Main still directly creates the concrete BankAccGenerator and BankAccSimulator classes. 
However, compared to my original implementation, the high-level program logic is much less coupled to the actual implementation details, 
and I think this is a step in the right direction.

# Result 
I finally got the Main ideas of SOLID principles. which will help me in future I am sure.

using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace G_Net_40_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Part 01 Question 01

            //   Q1: Identify the type of relationship in each scenario
            //   below(Inheritance, Association, Aggregation, Composition, or Dependency):
            //   a) A University has Departments. If the university is closed, the departments no longer exist.
            //   b) A Driver uses a Car.The driver does not own the car.
            //   c) A Dog is an Animal.
            //   d) A Team has Players. If the team is deleted, the players still exist.
            //   e) A method receives a Logger as a parameter and calls it inside the method only.

            //---------------------------------------------------------------------------------------------------------


            //Answers: 

            //a) Composition, because Departments cannot exist without the University.
            //b) Association, The driver uses the car but does not own it.
            //c) Inheritance, ((IS - A )) relationship.
            //d) Aggregation, Players can exist independently of the team
            //e) Dependency, Temporary use inside a method only.

            //---------------------------------------------------------------------------------------------------------


            #endregion

            #region Part 01 Question 02

            // Q2: Answer the following questions about access modifiers and sealed:

            // a) A parent class has a protected field.Can a child class in a different assembly access it?
            //    What about through an object instance from outside?
            // b) What is the difference between protected internal and private protected?
            // c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            // d) Can you create an object from a sealed class using new? Why or why not?


            //---------------------------------------------------------------------------------------------------------


            // Answers:

            // a) Child class in a different assembly: Yes, it can access the protected field through inheritance.
            //    but, From outside using an object instance: No, protected members cannot be accessed using an object


            // b) protected internal : Accessible in the same assembly OR in derived classes (any assembly)
            //    private protected : Accessible only in the same assembly AND in derived classes


            // c) sealed keyword : 
            //    When used with a class: Prevents other classes from inheriting from it.
            //    When used with a method: Prevents derived classes from overriding that method.


            // d) Can you create an object from a sealed class using new?
            //    Yes, you can.
            //    because, sealed only prevents inheritance BUT It does NOT prevent object creation.
            //    So you can instantiate it normally using new, but you cannot inherit from it.

            //---------------------------------------------------------------------------------------------------------

            #endregion
            #endregion
        }
    }
}

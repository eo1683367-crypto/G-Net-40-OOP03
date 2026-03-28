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


            #endregion
        }
    }
}

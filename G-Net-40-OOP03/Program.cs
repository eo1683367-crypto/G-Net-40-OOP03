using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Principal;
using G_Net_40_OOP03.Classes;

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



            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

           // a.Create a Cinema and open it.

           // Projector projector = new Projector();
           // var cinema1 = new Cienma("Cinema 1", projector);
           // cinema1.OpenCinema(projector);

           //// b.Create one of each ticket type(hardcoded data) and add them to the Cinema.

           // var ticket1Standard = new StandardTicket("Inception", 120, "A-5"); 
           // var ticket2VIP = new VIPTicket("Avengers", 200, true);
           // var ticket3IMAX = new IMAXTicket("Dune", 180, false);

           // cinema1.AddTicket(ticket1Standard);
           // cinema1.AddTicket(ticket2VIP);
           // cinema1.AddTicket(ticket3IMAX);

           // //c.Print all tickets.
           // cinema1.PrintAllTickets();


           // //d.Print the total tickets sold using the method.
           // Console.WriteLine("\n ======== Statistics ========");
           // Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}\n");


           // //e.Generate and print 2 booking references.
           // Console.WriteLine($"Booking Ref 1: {BookingHelper.GenerateBookingReference()}");
           // Console.WriteLine($"Booking Ref 2: {BookingHelper.GenerateBookingReference()}\n");

           // //f.Calculate and print the group discount for a group of 5 tickets at 80 EGP each of them.
           // Console.WriteLine($"Group Discount (5 tickets x 100 EGP): {BookingHelper.CalcGroupDiscount(5, 100)} EGP (10% Off)\n");


           // // d.Close the Cinema.

           // cinema1.CloseCinema(projector);
            #endregion
        }
    }
}

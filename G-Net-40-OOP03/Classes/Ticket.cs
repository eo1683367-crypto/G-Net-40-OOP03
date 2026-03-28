using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03.Classes
{
//    1. Create a base class Ticket with:
//a.MovieName(string), Price(decimal, must be > 0), TicketId(int, read-only, auto-incremented).
 public class Ticket
    {
        #region Attributes
        private string movieName;
        private decimal price;
        private static int ticketCounter = 0;
        #endregion


        #region Properties

      //  c. A computed property PriceAfterTax that returns the price with 14% tax.
        public decimal PriceAfterTax => Price * 1.14m;

        public int TicketId { get; private set; }

        public string MovieName
        {
            get => movieName;
            set
            {
                // Validation: cannot be null or empty
                if (!string.IsNullOrWhiteSpace(value))
                {
                    movieName = value;
                }
                // If invalid, keep the previous value (do nothing)
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                // Validation: must be greater than 0
                if (value > 0)
                {
                    price = value;
                }
                // If invalid, keep the previous value (do nothing)
            }
        }
        #endregion

       // b.A constructor that takes movieName and price.
        #region Contructor
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            ticketCounter++;
            TicketId = ticketCounter;
        }
        #endregion

        #region Methods

      //  d.Override ToString() to return the ticket info.
       public override string ToString() => $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:0.00}";

       // e.A static int GetTotalTickets() method that returns the total number of tickets created.
        public static int GetTotalTickets() => ticketCounter;

        #endregion
    }
}

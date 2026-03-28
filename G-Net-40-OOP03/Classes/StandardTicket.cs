using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03.Classes
{
//    2. Create three child classes that inherit from Ticket:
//a.StandardTicket — adds SeatNumber(string).

    internal class StandardTicket : Ticket
    {
        #region Property
        public string SeatNumber { get; set; } 
        #endregion
        #region Consructor
        public StandardTicket( string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        #endregion


        #region Method
        // Each child class should override ToString() to include its own extra info.
        public override string ToString()
        {
            return base.ToString() + $"| Seat: {SeatNumber}";
        } 
        #endregion
    }
}

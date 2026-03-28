using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03.Classes
{
    //2. Create three child classes that inherit from Ticket:
    //    b.VIPTicket — adds LoungeAccess(bool) and ServiceFee(decimal) = 50.

    internal class VIPTicket : Ticket
    {
        #region Property
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }
        #endregion
        #region Contructor
        public VIPTicket( string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = 50;
        }
        #endregion

        #region Method
        // Each child class should override ToString() to include its own extra info.
        public override string ToString()
        {
            return base.ToString() + $"| Lounge : {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        } 
        #endregion
    }
}

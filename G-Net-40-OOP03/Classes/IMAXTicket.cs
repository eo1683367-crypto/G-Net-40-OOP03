using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03.Classes
{
//    2. Create three child classes that inherit from Ticket:
//c.IMAXTicket — adds Is3D(bool). If true, the price increases by 30 EGP.

    internal class IMAXTicket : Ticket
    {

        #region Proterty
        public bool Is3D { get; set; }
        #endregion

        #region Constructor
        public IMAXTicket( string movieName, decimal price, bool is3D) : base(movieName, price)
        {
            Is3D = is3D;

            if (Is3D)
            {
                Price += 30;
            }
        }
        #endregion

        #region Method
        // Each child class should override ToString() to include its own extra info.
        public override string ToString()
        {
            return base.ToString() + $"| IMAX 3D: {(Is3D ? "Yes" : "No")}";

        } 
        #endregion
    }
}

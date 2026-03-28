using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03.Classes
{
    internal class Cienma
    {
       

        #region Attribute

        private Ticket[] tickets = new Ticket[20];
        public string CienmaName { get; set; }

        private Projector projector;

        #endregion

       

        #region Constructor
        public Cienma(string cinemaName, Projector projector)
        {
            CienmaName = cinemaName;
            projector = new Projector();
        } 
        #endregion

        #region Methods
        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] is null)
                {
                    tickets[i] = ticket;
                    return true;
                }
            }
            return false;
        }

        //------------------------------------------------------------------


        public void PrintAllTickets()
        {
            Console.WriteLine("========== All Tickets ==========");

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    Console.WriteLine(tickets[i]);
                }
            }
        }

        //------------------------------------------------------------------
        public void  OpenCinema( Projector projector)
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
            Console.WriteLine();
        }
        //------------------------------------------------------------------
        public void CloseCinema(Projector projector)
        {
            Console.WriteLine("========== Cinema Closed ==========");
            projector.Stop();
        }
        #endregion
    }
}

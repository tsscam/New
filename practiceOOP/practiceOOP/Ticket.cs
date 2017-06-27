using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP
{
    class Ticket
    {
        private float ticketPrice;
        private DateTime concertDate;

        public float TicketPrice
        {
            get
            {
                return ticketPrice;
            }
            set
            {
                ticketPrice = value;
            }
        }
        public DateTime ConcertDate
        {
            get
            {
                return concertDate;
            }
            set
            {
                concertDate = value;
            }
        }
        public Ticket()
        {
            ticketPrice = 0;
            concertDate = new DateTime(1,1,2017);
        }
      
        public Ticket(float tprice, DateTime cdate)
        {
            ticketPrice = tprice;
            concertDate = cdate;
        }
        
    }
}
     

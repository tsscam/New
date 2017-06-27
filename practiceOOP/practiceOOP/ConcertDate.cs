using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP
{
    class ConcertDate
    {
        private DateTime ticketConcertDate;

        public int Month { get; set; }
        public int Date { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }


        public ConcertDate()
        {
            Month = 00;
            Date = 00;
            Hour = 0;
            Minutes = 00;


        }

        public override string ToString()
            {
                return String.Format

                ( "{00}/{00},{0}:{00}",
                    this.Month, this.Date, this.Hour, this.Minutes);
            }
        }
    }

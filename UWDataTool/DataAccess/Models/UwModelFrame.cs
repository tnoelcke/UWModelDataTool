using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class UwModelFrame: IEntity
    { 
        public DateTime Date { get; set; }

        public int Tempurature { get; set; }

        public int WindSpeedSustained { get; set; }

        public int WindSpeedGust { get; set; }

        public int mb850Temp { get; set; }

        public int mb500Temp { get; set; }

        public double Preciptiation3hour { get; set; }

        public double Preciptiation24Hour { get; set; }

        public double Snow3Hour { get; set; }

        public double Snow24Hour { get; set; }

        public int FreezingLevel { get; set; }

    }
}

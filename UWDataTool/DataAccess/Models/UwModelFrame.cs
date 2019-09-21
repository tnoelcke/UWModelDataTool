using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    class UwModelFrame
    { 
        DateTime Date { get; set; }

        int Tempurature { get; set; }

        int WindSpeedSustained { get; set; }

        int WindSpeedGust { get; set; }

        int mb850Temp { get; set; }

        int mb500Temp { get; set; }

        double Preciptiation3hour { get; set; }

        double Preciptiation24Hour { get; set; }

        double Snow3Hour { get; set; }

        double Snow24Hour { get; set; }

        int FreezingLevel { get; set; }

    }
}

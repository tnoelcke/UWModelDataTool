using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    class UwModelRun
    {
        public UwModelRun()
        {
            Frames = new List<UwModelFrame>();
        }

        string Run { get; set; }

        string ProductName { get; set; }

        DateTime RunDate { get; set; }

        IList<UwModelFrame> Frames { get; set; }


    }
}

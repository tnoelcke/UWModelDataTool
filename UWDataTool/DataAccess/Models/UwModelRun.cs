using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class UwModelRun
    {
        public UwModelRun()
        {
            Frames = new List<UwModelFrame>();
        }

        public string Id { get; set; }

        public string Run { get; set; }

        public string ProductName { get; set; }

        public DateTime RunDate { get; set; }

        public IList<UwModelFrame> Frames { get; set; }


    }
}

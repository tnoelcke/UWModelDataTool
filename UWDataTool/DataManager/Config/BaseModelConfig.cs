using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Config
{
    class BaseModelConfig
    {
        public string url { set; get; }

        public string DateFormatString { get; set; }

        public string constructUrl(DateTime date)
        {
            return "";
        }

    }
}

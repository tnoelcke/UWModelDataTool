using System;
using System.Collections.Generic;
using System.Text;

namespace DataManager.Config
{
    /// <summary>
    /// Class that holds the configuration for the UW models that we will be processing
    /// </summary>
    class UWConfig : BaseModelConfig
    {
        /// <summary>
        /// Path where the images for the UW MM5 model can be found
        /// </summary>
        public string MM5_Path { get; set; }

        /// <summary>
        /// Path where the WRF images can be found
        /// </summary>
        public string WRF_Path { get; set; }
    }
}

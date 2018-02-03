using System.Collections;
using System.Collections.Generic;
using log4net;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the TacoBells
    /// </summary>
    public class TacoParser
    {
        public TacoParser()
        {

        }

        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ITrackable Parse(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return null;
            }

            var cells = line.Split(',');

            if (cells.Length < 2) {return null;}

            var lonString = cells[0];
            var latString = cells[1];
            var name = cells.Length > 2 ? cells[2] : null;
        }
    }
}
using System;
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
        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ITrackable Parse(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return null;
            }

            var cells = line.Split(',');

            if (cells.Length < 2) { return null; }

            var lonString = cells[0];
            var latString = cells[1];

            try
            {
                var lon = double.Parse(lonString);
                var lat = double.Parse(latString);

                return new TacoBell
                {
                    Name = cells.Length > 2 ? cells[2] : null,
                    Location = new Point
                    {
                        Latitude = lat,
                        Longitude = lon
                    }
                };
            }
            catch (Exception e)
            {
                Logger.Error("Failed to Parse lat and lon", e);
                return null;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TraccarClientSimulator
{
    /// <summary>
    /// GPS coordinate
    /// </summary>
    public struct COORD_POINT
    {
        public double lat;
        public double lon;
    }

    /// <summary>
    /// GPX coordinate file loader
    /// </summary>
    public class GPXLoader
    {
        /// <summary> 
        /// Load the Xml document for parsing 
        /// </summary> 
        /// <param name="sFile">Fully qualified file name (local)</param> 
        /// <returns>XDocument</returns> 
        private XDocument GetGpxDoc(string sFile)
        {
            XDocument gpxDoc = XDocument.Load(sFile);
            return gpxDoc;
        }

        /// <summary> 
        /// Load the namespace for a standard GPX document 
        /// </summary> 
        /// <returns></returns> 
        private XNamespace GetGpxNameSpace()
        {
            XNamespace gpx = XNamespace.Get("http://www.topografix.com/GPX/1/1");
            return gpx;
        }

        /// <summary> 
        /// When passed a file, open it and parse all waypoints from it. 
        /// </summary> 
        /// <param name="sFile">Fully qualified file name (local)</param> 
        public List<COORD_POINT> Load_WP_Coordinates(string sFile)
        {
            List < COORD_POINT > listCoordinate = new List<COORD_POINT>();

            XDocument gpxDoc = GetGpxDoc(sFile);
            XNamespace gpx = GetGpxNameSpace();

            var waypoints = from waypoint in gpxDoc.Descendants(gpx + "wpt")
                            select new
                            {
                                Latitude = waypoint.Attribute("lat").Value,
                                Longitude = waypoint.Attribute("lon").Value,
                                Elevation = waypoint.Element(gpx + "ele") != null ?
                                  waypoint.Element(gpx + "ele").Value : null,
                                Name = waypoint.Element(gpx + "name") != null ?
                                  waypoint.Element(gpx + "name").Value : null,
                                Dt = waypoint.Element(gpx + "cmt") != null ?
                                  waypoint.Element(gpx + "cmt").Value : null
                            };


            StringBuilder sb = new StringBuilder();
            foreach (var wpt in waypoints)
            {
                COORD_POINT coordPoint;
                Double.TryParse(wpt.Latitude.Replace('.', ','), out coordPoint.lat);
                Double.TryParse(wpt.Longitude.Replace('.', ','), out coordPoint.lon);
                listCoordinate.Add(coordPoint);
            }

            return listCoordinate;
        }


        /// <summary> 
        /// When passed a file, open it and parse all trackpoints from it. 
        /// </summary> 
        /// <param name="sFile">Fully qualified file name (local)</param> 
        public List<COORD_POINT> Load_TP_coordinates(string sFile)
        {
            XDocument gpxDoc = GetGpxDoc(sFile);
            XNamespace gpx = GetGpxNameSpace();
            var tracks = from track in gpxDoc.Descendants(gpx + "trk")
                         select new
                         {
                             Name = track.Element(gpx + "name") != null ?
                            track.Element(gpx + "name").Value : null,
                             Segs = (
                                from trackpoint in track.Descendants(gpx + "trkpt")
                                select new
                                {
                                    Latitude = trackpoint.Attribute("lat").Value,
                                    Longitude = trackpoint.Attribute("lon").Value,
                                    Elevation = trackpoint.Element(gpx + "ele") != null ?
                                    trackpoint.Element(gpx + "ele").Value : null,
                                    Time = trackpoint.Element(gpx + "time") != null ?
                                    trackpoint.Element(gpx + "time").Value : null
                                }
                              )
                         };

            List<COORD_POINT> listaCoordinate = new List<COORD_POINT>();
            foreach (var trk in tracks)
            {
                // Populate track data objects. 
                foreach (var trkSeg in trk.Segs)
                {
                    COORD_POINT coordPoint;
                    Double.TryParse(trkSeg.Latitude.Replace('.', ','), out coordPoint.lat);
                    Double.TryParse(trkSeg.Longitude.Replace('.', ','), out coordPoint.lon);
                    listaCoordinate.Add(coordPoint);
                }
            }

            return listaCoordinate;
        }

    }// end class
}// end namespace



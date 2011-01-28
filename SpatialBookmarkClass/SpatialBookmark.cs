using System;

using System.Collections.Generic;
using System.Text;
using ESRI.ArcGIS.Mobile;
using ESRI.ArcGIS.Mobile.Geometries;
using System.Xml;
using System.IO;

namespace SpatialBookmarkClass
{
    public class SpatialBookmark
    {
        private Dictionary<string, Envelope> _bookmarks = new Dictionary<string, Envelope>();
        private Map _map = null;
        
        public SpatialBookmark(Map map)
        {
            _map = map;
        }
        public Exception CreateBookmark(string name, Envelope envelope)
        {
            try
            {
                _bookmarks.Add(name,envelope);

                return null;
            }

            catch (Exception ex) { return ex; }

        }

        public Exception ZoomtoBookmark(string name)
        {
            try
            {
                Envelope envelope = _bookmarks[name];
                _map.SetExtent(envelope);
                _map.Refresh();
                return null;
            }

            catch (Exception ex) { return ex; }

        }
        public Exception DeleteBookmark(string name)
        {
            try
            {
                _bookmarks.Remove(name);
                return null;
            }

            catch (Exception ex) { return ex; }

        }

        public Exception WritetoXML(string fileName)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                XmlProcessingInstruction xPI;
                XmlElement xElmntRoot;
                XmlElement xElmntEnvelope;

                xPI = xDoc.CreateProcessingInstruction("xml", "version='1.0'");
                xDoc.AppendChild(xPI);
                xElmntRoot = xDoc.CreateElement("xml");
                xDoc.AppendChild(xElmntRoot);
                xElmntEnvelope = (XmlElement)(xElmntRoot.AppendChild(xDoc.CreateElement("Envelope")));
                xElmntEnvelope.SetAttribute("SpatialReference", _map.SpatialReference.CoordinateSystemString);
                xElmntEnvelope.SetAttribute("Xmin", _map.GetExtent().MinX.ToString());
                xElmntEnvelope.SetAttribute("Ymin", _map.GetExtent().MinY.ToString());
                xElmntEnvelope.SetAttribute("Xmax", _map.GetExtent().MaxX.ToString());
                xElmntEnvelope.SetAttribute("Ymax", _map.GetExtent().MaxY.ToString());
                xDoc.Save(fileName);

                return null;
            }

            catch (Exception ex) { return ex; }

        }

        public Envelope ReadXML(string fileName)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(fileName);
                Envelope envelope = new Envelope();
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (reader.Name.ToLower() == "envelope")
                            {
                                while (reader.MoveToNextAttribute()) // Read the attributes.
                                    if (reader.Name.ToLower() == "spatialreference")
                                    {
                                        if (_map.SpatialReference.CoordinateSystemString.ToLower() != reader.Value.ToLower())
                                        {
                                            throw new Exception("Spatial reference mismatch");
                                        }
                                    }
                                    else if (reader.Name.ToLower() == "xmin")
                                    {                                      
                                         envelope.MinX=double.Parse(reader.Value);
                                    }
                                    else if (reader.Name.ToLower() == "ymin")
                                    {
                                            envelope.MinY = double.Parse(reader.Value);
                                    }
                                    else if (reader.Name.ToLower() == "xmax")
                                    {
                                        envelope.MaxX=double.Parse(reader.Value);
                                    }
                                    else if (reader.Name.ToLower() == "ymax")
                                    {
                                        envelope.MaxY = double.Parse(reader.Value);
                                    }
                                 
                                break;
                            }
                            break;
                    }

                }
                return envelope;
            }

            catch (Exception ex) { throw; }

        }
    }
}

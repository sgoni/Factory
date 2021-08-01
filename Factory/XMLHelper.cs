using System.Linq;
using System.Xml.Linq;

namespace FactoryStandard
{
    public static class XMLHelper
    {
        /// <summary>
        /// Remove the namespaces of an XML content.
        /// </summary>
        /// <param name="e">XElement to parse.</param>
        /// <returns>XElement</returns>
        public static XElement RemoveAllNamespaces(XElement e)
        {
            return new XElement(e.Name.LocalName,
               (from n in e.Nodes()
                select ((n is XElement) ? RemoveAllNamespaces(n as XElement) : n)),
               (e.HasAttributes) ? (from a in e.Attributes()
                                    where (!a.IsNamespaceDeclaration)
                                    select new XAttribute(a.Name.LocalName, a.Value)) : null);
        }

        /// <summary>
        /// Return a XML to string format.
        /// </summary>
        /// <param name="e">XElement to convert to string</param>
        /// <returns>XML string format</returns>
        public static string InnerXML(this XElement e)
        {
            System.Xml.XmlReader reader = e.CreateReader();
            reader.MoveToContent();
            return reader.ReadInnerXml();
        }

        /// <summary>
        /// eturn a XML to string format.
        /// </summary>
        /// <param name="e">XElement to convert to string<</param>
        /// <returns>XML string format</returns>
        public static string OuterXML(this XElement e)
        {
            System.Xml.XmlReader reader = e.CreateReader();
            reader.MoveToContent();
            return reader.ReadOuterXml();
        }
    }
}

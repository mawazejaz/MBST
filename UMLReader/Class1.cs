using System.Xml.Linq;

namespace UMLReader
{
	public class Reader
	{
		public XDocument GetDiagramXml(string diagramName, string diagramXmlFile)
		{
			XNamespace UML = "omg.org/UML1.3/";
			XDocument diagramElements = XDocument.Load(diagramXmlFile);
			XElement test = XElement.Load(diagramXmlFile);
	//	C:\Users\Mawaz\Downloads\Untitled Diagram.drawio.xml
			IEnumerable<XElement> elements =
	diagramElements.Descendants("XMI.content");
			foreach (XElement element in elements)
			{
				XElement xmiElement2 = element.Element(UML + "Diagram");
				XElement xmiElement3 = null;
				if (xmiElement2.Attribute("name").Value == diagramName)
					xmiElement3 = xmiElement2.Element(UML +
	"Diagram.element");
				var output = xmiElement3.Descendants(UML + "DiagramElement");
				diagramElements = XDocument.Load(xmiElement3.CreateReader());
			}

			return diagramElements;
		}
		public Dictionary<string, string> GetDiagramElments(XDocument
	   diagramRawXml)
		{
			Dictionary<string, string> diagramExtractedElements = new
	Dictionary<string, string>();

			return diagramExtractedElements;
		}
		public Dictionary<string, Dictionary<string, string>>
		GetDiagramMessages(Dictionary<string, string> diagramExtractedElement,
		string diagramXmlFile)
		{
			Dictionary<string, Dictionary<string, string>> messagesList = new
	Dictionary<string, Dictionary<string, string>>();

			return messagesList;

		}
	}
}
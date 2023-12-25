using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLReader;
using System.Xml;
using System.Xml.Linq;
using PlantUml.Net;

namespace AUMLReader
{
	public class XMLReader
	{
		public void readfile()
		{
			string address = @"C:\\Users\\Mawaz\\Downloads\\Untitled Diagram.drawio.xml";
			XDocument diagramElements = XDocument.Load(address);
			XElement test = XElement.Load(address);
			//while (reader.Read())
			//{
			//	if (reader.NodeType == XmlNodeType.Element)
			//	{
			//		switch (reader.Name)
			//		{
			//			case "class":
			//				string className = reader.GetAttribute("name");
			//				// Create a C# class object here
			//				break;
			//			case "association":
			//				// Extract association details
			//				break;
			//				// ... handle other UML elements
			//		}
			//	}
			//}
			//reader.Close();
		}

		public void writefile()
		{
			// Load the UML XML document
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(@"C:\\Users\\Mawaz\\Downloads\\Statediagram.drawio.xml");

			XmlNodeList edgeNodes = xmlDoc.SelectNodes("//mxCell[@edge='1']");

			Dictionary<string, List<string>> stateTransitions = new Dictionary<string, List<string>>();

			foreach (XmlNode edgeNode in edgeNodes)
			{
				string sourceVertexId = edgeNode.Attributes["source"].Value;
				string targetVertexId = edgeNode.Attributes["target"].Value;

				// Assuming vertices have 'Activity' as their value
				string sourceVertexValue = xmlDoc.SelectSingleNode($"//*[@id='{sourceVertexId}']/@value")?.Value;
				string targetVertexValue = xmlDoc.SelectSingleNode($"//*[@id='{targetVertexId}']/@value")?.Value;

				// Extract other relevant information about the transition
				string transitionLabel = edgeNode.SelectSingleNode("mxGeometry/@label")?.Value ?? "No Label";

				// Print or process the extracted information
				Console.WriteLine($"Transition from {sourceVertexValue} to {targetVertexValue} with label '{transitionLabel}'");
			}
		}
	}
}
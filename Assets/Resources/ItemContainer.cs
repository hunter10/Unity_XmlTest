using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml.Serialization;
using System.IO;

using System.Xml;

[XmlRoot("ChipEventItemTable")]
public class ChipEventItemContainer
{
    [XmlArray("ChipEventItems")]
    [XmlArrayItem("ChipEventItem")]
    public List<ChipEventItem> items = new List<ChipEventItem>();

    // XmlSerializer 방식
    public static ChipEventItemContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(ChipEventItemContainer));

        StringReader reader = new StringReader(_xml.text);

        ChipEventItemContainer items = serializer.Deserialize(reader) as ChipEventItemContainer;

        reader.Close();

        return items;
    }
}

[XmlRoot("ItemCollection")]
public class ItemContainer
{
    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<Item> items = new List<Item>();

    // XmlSerializer 방식
    public static ItemContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer));

        StringReader reader = new StringReader(_xml.text);

        ItemContainer items = serializer.Deserialize(reader) as ItemContainer;

        reader.Close();

        return items;
    }

    public static List<Item> Load2(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlDocument Document = new XmlDocument();
        Document.LoadXml(_xml.text);


        /*
        XmlElement ItemListElement = Document["ItemCollection"];
        Debug.Log("ItemCollection Count:" + ItemListElement.ChildNodes.Count);
        foreach (XmlElement ItemElement in ItemListElement.ChildNodes)
        {
            Debug.Log("     Items Count:" + ItemElement.ChildNodes.Count);
            Debug.Log("     " + ItemElement.GetAttribute("name"));
            Debug.Log("     " + ItemElement.GetElementsByTagName("name"));
            foreach (XmlElement SubItemElement in ItemElement.ChildNodes)
            {
                Debug.Log("         Sub Items Count:" + SubItemElement.ChildNodes.Count);
            }
        }
        */



        // 값만 모을때
        //XmlElement root = Document.DocumentElement;
        //XmlNodeList damageNode = root.GetElementsByTagName("Damage");
        //foreach(XmlNode d in damageNode)
        //{
        //    Debug.Log(d.InnerXml);
        //}




        //XmlElement xmlElement = Document["ItemCollection"]["Items"];
        //Debug.Log("Items Count:" + xmlElement.ChildNodes.Count);

        

        XmlNodeList xmlNodeList = Document.SelectNodes("ItemCollection");
        //Debug.Log("ItemCollection Count:" + xmlNodeList.Count);
        foreach (XmlNode node in xmlNodeList)
        {
            //Debug.Log("" + node.Name);
            //Debug.Log("     Items Count:" + node.ChildNodes.Count);
            foreach (XmlNode subnode in node.ChildNodes)
            {
                //Debug.Log("     " + subnode.Name);
                //Debug.Log("     " + subnode.ChildNodes.Count);
                foreach (XmlNode item in subnode)
                {
                    Debug.Log("         " + item.Name + ", " + item.Attributes.GetNamedItem("name").Value);
                    var a = item.SelectSingleNode("Damage").FirstChild.Value;
                    Debug.Log(a);
                    foreach (XmlNode subitem in item.ChildNodes)
                    {
                        var b = subnode.FirstChild.Value;
                        Debug.Log("             " + subitem.Name + ", " + b);
                    }
                }
            }
        }

        return null;
        
        

        //XmlNodeList nodes = xmldoc.SelectNodes("Items/Item");
        //foreach(XmlNode node in nodes)
        //{
        //    Debug.Log("name : " + node.SelectSingleNode("name").InnerText);
        //}
    }
}

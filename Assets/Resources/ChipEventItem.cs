using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;

public class ChipEventItem
{
    [XmlElement("Index")]
    public int Index;

    [XmlElement("Type")]
    public string Type;

    [XmlElement("SpriteIcon")]
    public string SpriteIcon;

    [XmlElement("SpriteBg")]
    public string SpriteBg;

    [XmlElement("IconType")]
    public string IconType;

    [XmlElement("Chips")]
    public double Chips;

    [XmlElement("Price")]
    public int Price;

    [XmlElement("Discount")]
    public int Discount;

    [XmlElement("Url_fb")]
    public int Url_fb;

    [XmlElement("Url_fbdev")]
    public int Url_fbdev;
}

namespace MusenalmConverter.Migration.AlteDBXML;

using System.Xml;
using System.Xml.Serialization;

[XmlRoot("REALNAME-Tab")]
public class REALNAMETab {
    public const string NAME = "REALNAME-Tab";
    [XmlElement]
    public string REALNAME;
    [XmlElement]
    public string? Daten;
    [XmlElement]
    public string? Nachweis;
    [XmlElement]
    public string? Beitrag;
    [XmlElement]
    public string? Pseudonym;
}

[XmlRoot("INH-TAB")]
public class INHTab {
    public const string NAME = "INH-TAB";
    [XmlElement]
    public long? ID;
    [XmlElement]
    public string? AUTOR;
    [XmlElement]
    public string? TITEL;
    [XmlElement]
    public string? SEITE;
    [XmlElement]
    public string? INCIPIT;
    [XmlElement]
    public long INHNR;
    [XmlElement]
    public string? ANMERKINH;
    [XmlElement]
    public string? OBJEKT;
    [XmlElement]
    public string? AUTORREALNAME;
    [XmlElement]
    public string? PAG;
    [XmlElement]
    public string? OBJZAEHL;
    [XmlElement]
    public bool BILD;
}

[XmlRoot("AlmNeu")]
public class AlmNeu {
    public const string NAME = "AlmNeu";
    [XmlElement]
    public long NUMMER;
    [XmlElement("BIBLIO-NR")]
    public string? BIBLIONR;
    [XmlElement("ALM-TITEL")]
    public string? ALMTITEL;
    [XmlElement]
    public string? REIHENTITEL;
    [XmlElement]
    public string? ORT;
    [XmlElement]
    public long? JAHR;
    [XmlElement]
    public string? HERAUSGEBER;
    [XmlElement("BEARBEITET AM")]
    public DateTime? BEARBEITETAM;
    [XmlElement("BEARBEITET VON")]
    public string? BEARBEITETVON;
    [XmlElement]
    public string? ANMERKUNGEN;
    [XmlElement]
    public bool AUTOPSIE;
    [XmlElement]
    public bool VORHANDEN;
    [XmlElement("VORHANDEN ALS")]
    public string? VORHANDENALS;
    [XmlElement]
    public string? NACHWEIS;
    [XmlElement]
    public string? STRUKTUR;
    [XmlElement]
    public string? NORM;
    [XmlElement("VOLLSTÄNDIG ERFASST")]
    public bool VOLSTAENDIGERFASST;
    [XmlElement]
    public string? HRSGREALNAME;
}
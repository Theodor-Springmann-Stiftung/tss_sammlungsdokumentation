namespace MusenalmConverter.Migration.MittelDBXML;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

[XmlRoot("Akteure")]
public class Akteure {
    // [XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    // public string noNamespaceSchemaLocation = "../muster/Akteure.xsd";

    [XmlElement]
    public long ID;
    [XmlElement]
    public string? NAME;
    [XmlElement]
    public bool? ORGANISATION = false;
    [XmlElement]
    public string? NACHWEIS;
    [XmlElement]
    public string? LEBENSDATEN;
    [XmlElement]
    public string? BERUF;
    [XmlElement]
    public string? PSEUDONYM;
    [XmlElement]
    public string? ANMERKUNGEN;
    [XmlElement]
    public string? GND;

    public bool ShouldSerializeNAME() => !String.IsNullOrWhiteSpace(NAME);
    public bool ShouldSerializeLEBENSDATEN() => !String.IsNullOrWhiteSpace(LEBENSDATEN);
    public bool ShouldSerializeNACHWEIS() => !String.IsNullOrWhiteSpace(NACHWEIS);
    public bool ShouldSerializeBERUF() => !String.IsNullOrWhiteSpace(BERUF);
    public bool ShouldSerializePSEUDONYM() => !String.IsNullOrWhiteSpace(PSEUDONYM);
    public bool ShouldSerializeANMERKUNGEN() => !String.IsNullOrWhiteSpace(ANMERKUNGEN);
    public bool ShouldSerializeGND() => !String.IsNullOrWhiteSpace(GND);
}

[XmlRoot("Status")]
public class Status {
    [XmlElement]
    public string? Value;
}

[XmlRoot("Typ")]
public class Typ {
    [XmlElement]
    public string? Value;
}

[XmlRoot("Paginierung")]
public class Paginierung {
    [XmlElement]
    public string? Value;
}

[XmlRoot("Inhalte")]
public class Inhalte {
    [XmlElement]
    public long ID;
    [XmlElement]
    public long? BAND;
    [XmlElement]
    public string? TITEL;
    [XmlElement]
    public string? AUTOR;
    [XmlElement]
    public string? PAGINIERUNG;
    [XmlElement]
    public string? SEITE;
    [XmlElement]
    public string? INCIPIT;
    [XmlElement]
    public string? ANMERKUNGEN;
    [XmlElement]
    public Typ[]? TYP;
    [XmlElement]
    public bool? DIGITALISAT;
    [XmlElement]
    public float? OBJEKTNUMMER;

    public bool ShouldSerializeTITEL() => !String.IsNullOrWhiteSpace(TITEL);
    public bool ShouldSerializeAUTOR() => !String.IsNullOrWhiteSpace(AUTOR);
    public bool ShouldSerializePAGINIERUNG() => !String.IsNullOrWhiteSpace(PAGINIERUNG);
    public bool ShouldSerializeSEITE() => !String.IsNullOrWhiteSpace(SEITE);
    public bool ShouldSerializeINCIPIT() => !String.IsNullOrWhiteSpace(INCIPIT);
    public bool ShouldSerializeANMERKUNGEN() => !String.IsNullOrWhiteSpace(ANMERKUNGEN);
    public bool ShouldSerializeTYP() => TYP != null;
    public bool ShouldSerializeOBJEKTNUMMER() => OBJEKTNUMMER != null;
}

[XmlRoot("Reihen")]
public class Reihen {
    [XmlElement]
    public long ID;
    [XmlElement]
    public string? NAME;
    [XmlElement]
    public string? SORTIERNAME;
    [XmlElement]
    public string? Anmerkungen;
    [XmlElement]
    public string? NACHWEIS;

    public bool ShouldSerializeNAME() => !String.IsNullOrWhiteSpace(NAME);
    public bool ShouldSerializeANMERKUNGEN() => !String.IsNullOrWhiteSpace(Anmerkungen);
    public bool ShouldSerializeSORTIERNAME() => !String.IsNullOrWhiteSpace(SORTIERNAME);
    public bool ShouldSerializeNACHWEIS() => !String.IsNullOrWhiteSpace(NACHWEIS);
}

[XmlRoot("Baende")]
public class Baende {
    [XmlElement]
    public long ID;
    [XmlElement("BIBLIO-ID")]
    public string? BIBLIOID;
    [XmlElement]
    public string? SORTIERTITEL;
    [XmlElement]
    public string? TITEL;
    [XmlElement]
    public string? HERAUSGEBER;
    [XmlElement("ORT-ALT")]
    public string? ORT;
    [XmlElement]
    public long? JAHR = null;
    [XmlElement]
    public string? STRUKTUR;
    [XmlElement]
    public string? NACHWEIS;
    [XmlElement]
    public string? NORM;
    [XmlElement]
    public bool AUTOPSIE;
    [XmlElement]
    public string? ANMERKUNGEN;
    [XmlElement("REIHENTITEL-ALT")]
    public string? REIHENTITELALT;
    [XmlElement]
    public Status[]? STATUS;
    [XmlElement]
    public bool ERFASST;
    public bool VORHANDEN;

    [XmlElement]
    public Ort[]? ORTE;

    public bool ShouldSerializeJAHR() => JAHR != null;
    public bool ShouldSerializeSORTIERTITEL() => !String.IsNullOrWhiteSpace(SORTIERTITEL);
    public bool ShouldSerializeHERAUSGEBER() => !String.IsNullOrWhiteSpace(HERAUSGEBER);
    public bool ShouldSerializeTITEL() => !String.IsNullOrWhiteSpace(TITEL);
    public bool ShouldSerializeORT() => !String.IsNullOrWhiteSpace(ORT);
    public bool ShouldSerializeSTRUKTUR() => !String.IsNullOrWhiteSpace(STRUKTUR);
    public bool ShouldSerializeNACHWEIS() => !String.IsNullOrWhiteSpace(NACHWEIS);
    public bool ShouldSerializeNORM() => !String.IsNullOrWhiteSpace(NORM);
    public bool ShouldSerializeORTE() => ORTE != null;

    public bool ShouldSerializeANMERKUNGEN() => !String.IsNullOrWhiteSpace(ANMERKUNGEN);
    public bool ShouldSerializeSTATUS() => STATUS != null;
}

[XmlRoot("ORTE")]
public class Ort {
    [XmlElement]
    public long? Value;
}

[XmlRoot("Orte")]
public class Orte {
    [XmlElement]
    public long? ID;
    [XmlElement]
    public string? NAME;
    [XmlElement]
    public string? Anmerkungen;

    public bool ShouldSerializeAnmerkungen() => !String.IsNullOrWhiteSpace(Anmerkungen);
}


[XmlRoot("*RELATION_InhalteAkteure")]
public class RELATION_InhalteAkteure {
    [XmlElement]
    public long INHALT;
    [XmlElement]
    public long BEZIEHUNG;
    [XmlElement]
    public long AKTEUR;
    [XmlElement]
    public string? ANMERKUNG;
    public bool ShouldSerializeANMERKUNG() => !String.IsNullOrWhiteSpace(ANMERKUNG);
}

[XmlRoot("*RELATION_BaendeAkteure")]
public class RELATION_BaendeAkteure {
    [XmlElement]
    public long BAND;
    [XmlElement]
    public long BEZIEHUNG;
    [XmlElement]
    public long AKTEUR;
    [XmlElement]
    public string? ANMERKUNG;
    public bool ShouldSerializeANMERKUNG() => !String.IsNullOrWhiteSpace(ANMERKUNG);
}

[XmlRoot("*RELATION_BaendeReihen")]
public class RELATION_BaendeReihen {
    [XmlElement]
    public long BAND;
    [XmlElement]
    public long BEZIEHUNG;
    [XmlElement]
    public long REIHE;
    [XmlElement]
    public string? ANMERKUNG;
    public bool ShouldSerializeANMERKUNG() => !String.IsNullOrWhiteSpace(ANMERKUNG);
}
﻿using System;
using System.Xml.Serialization;

namespace ManifestoDocumentoFiscalEletronico.Classes
{
    [Serializable]
    public class MDFeLacUnidTransp
    {
        [XmlElement(ElementName = "nLacre")]
        public string NLacre { get; set; }
    }
}
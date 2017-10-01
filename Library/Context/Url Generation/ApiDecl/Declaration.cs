using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BuyBuddy.Context.UrlGeneration.ApiDecl {
    [XmlRoot]
    public sealed class Declaration {
        [XmlElement]
        public Scope scope;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BuyBuddy.Context.UrlGeneration.ApiDecl {
    [XmlRoot]
    public sealed class Scope {
        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public string PermissionPrefix;

        [XmlAttribute]
        public string Path;

        [XmlArray]
        public Route routes;
    }
}

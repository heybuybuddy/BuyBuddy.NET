using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Net.Http;

namespace BuyBuddy.Context.UrlGeneration.ApiDecl {
    [XmlRoot]
    public sealed class Route {
        public enum ActionType {
            [XmlEnum(Name = "index")]
            Index,
            [XmlEnum(Name = "show")]
            Show,
            [XmlEnum(Name = "create")]
            Create,
            [XmlEnum(Name = "update")]
            Update,
            [XmlEnum(Name = "delete")]
            Delete
        }

        public enum AuthenticationType {
            [XmlEnum]
            Nil,
            [XmlEnum]
            Default
        }

        [XmlAttribute]
        public string PermissionGroup { get; private set; }

        [XmlAttribute]
        public ActionType Action { get; private set; }

        [XmlAttribute]
        public HttpMethod Method { get; private set; }

        [XmlAttribute]
        public AuthenticationType Authentication { get; private set; }

        [XmlText]
        public string Path { get; private set; }
    }
}

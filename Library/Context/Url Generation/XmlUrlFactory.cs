using System.IO;
using System.Xml.Serialization;

namespace BuyBuddy.Context.UrlGeneration {
    internal class XmlUrlFactory : UrlFactory {
        public static readonly string Path = "ApiRoutes.xml";
        public ApiDecl.Declaration Declaration { get; private set; }

        internal XmlUrlFactory(string baseUrl)
            : base(baseUrl) {
            var serializer = new XmlSerializer(typeof(ApiDecl.Declaration));
            var fs = new FileStream(Path, FileMode.Open);

            Declaration = serializer.Deserialize(fs) as ApiDecl.Declaration;
        }
    }
}

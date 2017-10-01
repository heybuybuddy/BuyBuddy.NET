using System;
using System.Collections.Generic;
using System.Text;

namespace BuyBuddy.Context.UrlGeneration {
    internal abstract class UrlFactory {
        internal string BaseUrl { get; private set; }

        internal UrlFactory(string baseUrl) {
            BaseUrl = baseUrl;
        }
    }
}

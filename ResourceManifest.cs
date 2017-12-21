using Orchard.UI.Resources;

namespace Orchard.Cw.Bootstrap4 {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineStyle("Bootstrap.Cw.Style").SetUrl("cw.min.css", "cw.css");
        }
    }
}

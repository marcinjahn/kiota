namespace Kiota.Builder.Tests {
    public static class CodeDomExtensions {
        public static void AddBackingStoreProperty(this CodeClass codeClass) {
            codeClass?.AddProperty(new CodeProperty(codeClass) {
                Name = "backingStore",
                PropertyKind = CodePropertyKind.BackingStore
            });
        }
    }
}

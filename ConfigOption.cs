namespace ArktiLight {
    public class ConfigOption {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString() {
            return Name + " => " + Value;
        }
    }
}

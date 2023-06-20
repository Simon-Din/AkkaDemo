namespace ActorComm.DataModel
{
    public class SelectItem
    {
        public string Key { get; private set; } = string.Empty;

        public string Value { get; private set; } = string.Empty;

        public SelectItem(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}

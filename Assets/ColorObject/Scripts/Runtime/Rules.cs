namespace ColorObject
{
    public static class Rules
    {
        public const string Select = "Select<UnityEngine.Object, Color>(x => (ColorObject.ColorObject)x)";
        public const string _Select = "." + Select;
        public const string Select_ = Select + ".";
    }
}

namespace GetSet
{
    public class Foo
    {
        public int ImplicitProperty { get; set; }

        private string explicitField;
        public string ExplicitProperty
        {
            get
            {
                return explicitField;
            }

            set
            {
                explicitField = value;
            }
        }

        public bool Method(bool b)
        {
            if (b)
            {
                ExplicitProperty = "foo";
            }
            else
            {
                ImplicitProperty = 1;
            }
            return b;
        }
    }
}

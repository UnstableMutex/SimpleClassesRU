using System;

namespace SimpleClasses
{
    [Serializable]
    public class SimpleAddress
    {
        public string Index { get; set; }
        public string Address { get; set; }
        public short RegionID { get; set; }
    }
}
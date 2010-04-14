using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// Feature Data Structure.
    /// </summary>
    [Serializable]
    public class Feature : BaseObject
    {
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}

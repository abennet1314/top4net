using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.list.add
    /// </summary>
    public class TraderateListAddRequest : ITopRequest
    {
        public Nullable<bool> Anony { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }
        public string Role { get; set; }
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.list.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("anony", this.Anony);
            parameters.Add("content", this.Content);
            parameters.Add("result", this.Result);
            parameters.Add("role", this.Role);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}

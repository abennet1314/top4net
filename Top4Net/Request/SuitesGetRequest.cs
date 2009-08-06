using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.suites.get
    /// </summary>
    public class SuitesGetRequest : ITopRequest
    {
        /// <summary>
        /// 用户订购服务的服务码(申请服务的时候会得到)。
        /// </summary>
        public string ServiceCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.suites.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("service_code", this.ServiceCode);

            return parameters;
        }

        #endregion
    }
}
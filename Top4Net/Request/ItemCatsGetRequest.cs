using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.get.v2
    /// </summary>
    public class ItemCatsGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 类目编号列表。
        /// </summary>
        public string Cids { get; set; }

        /// <summary>
        /// 父商品类目编号。
        /// </summary>
        public string ParentCid { get; set; }

        /// <summary>
        /// 时间戳。
        /// </summary>
        public DateTime DateTime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.get.v2";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("parent_cid", this.ParentCid);
            parameters.Add("cids", this.Cids);
            parameters.Add("datetime", this.DateTime.ToString(Constants.DATE_TIME_FORMAT));

            return parameters;
        }

        #endregion
    }
}

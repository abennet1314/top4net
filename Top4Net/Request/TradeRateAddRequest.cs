using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.add
    /// </summary>
    public class TradeRateAddRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 交易ID。
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// 子订单ID。
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 评价内容。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评价结果。
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 是否匿名（是:true;否:false;）卖家评不能匿名。
        /// </summary>
        public string Anony { get; set; }

        /// <summary>
        /// 评价角色。
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public TradeRateAddRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("tid", this.TradeId);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("content", this.Content);
            parameters.Add("result", this.Result);
            parameters.Add("anony", this.Anony);
            parameters.Add("role", this.Role);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}

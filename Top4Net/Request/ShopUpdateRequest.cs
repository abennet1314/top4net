using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shop.update
    /// </summary>
    public class ShopUpdateRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 店铺标题(title、bulletin和desc至少必须传一个)。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 店铺公告。
        /// </summary>
        public string Bulletin { get; set; }

        /// <summary>
        /// 店铺描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ShopUpdateRequest(string sessionKey)
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
            return "taobao.shop.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("title", this.Title);
            parameters.Add("bulletin", this.Bulletin);
            parameters.Add("desc", this.Description);

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

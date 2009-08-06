using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.get
    /// </summary>
    public class TradesGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的交易数据结构字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品id。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数 (每页返回最多返回100条,默认值为20)。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// fixed,一口价;auction,拍卖;guarantee_trade,一口价、拍卖;auto_delivery,自动发货;independent_shop_trade,外部网店的交易;ec 直充 ;cod 货到付款。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("iid", this.Iid);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
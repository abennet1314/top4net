using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextra.add
    /// </summary>
    public class ItemextraAddRequest : ITopUploadRequest
    {
        public string ApproveStatus { get; set; }
        public Nullable<DateTime> DelistTime { get; set; }
        public string Desc { get; set; }
        public string Feature { get; set; }
        public string Iid { get; set; }
        public FileItem Image { get; set; }
        public Nullable<DateTime> ListTime { get; set; }
        public string Memo { get; set; }
        public Nullable<long> NumIid { get; set; }
        public Nullable<long> Options { get; set; }
        public string PicUrl { get; set; }
        public string ReservePrice { get; set; }
        public string SellerCids { get; set; }
        public Nullable<long> ShopId { get; set; }
        public string SkuExtraIds { get; set; }
        public string SkuIds { get; set; }
        public string SkuMemos { get; set; }
        public string SkuPrices { get; set; }
        public string SkuProperties { get; set; }
        public string SkuQuantities { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextra.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("delist_time", this.DelistTime);
            parameters.Add("desc", this.Desc);
            parameters.Add("feature", this.Feature);
            parameters.Add("iid", this.Iid);
            parameters.Add("list_time", this.ListTime);
            parameters.Add("memo", this.Memo);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("options", this.Options);
            parameters.Add("pic_url", this.PicUrl);
            parameters.Add("reserve_price", this.ReservePrice);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("sku_extra_ids", this.SkuExtraIds);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("sku_memos", this.SkuMemos);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_properties", this.SkuProperties);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("title", this.Title);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}

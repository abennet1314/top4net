using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update
    /// </summary>
    public class ItemUpdateRequest : ITopUploadRequest
    {
        /// <summary>
        /// 需要修改的商品id。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品上传后的状态。Onsale出售中，instock库中。
        /// </summary>
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 叶子类目id。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 商品属性列表。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 商品数量。
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// 商品价格。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 宝贝标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 商品描述。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 所在地省份,如浙江。
        /// </summary>
        public string LocationState { get; set; }

        /// <summary>
        /// 所在地城市,如杭州。
        /// </summary>
        public string LocationCity { get; set; }

        /// <summary>
        /// 运费承担方式,seller（卖家承担），buyer(买家承担)。
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 有效期,7或者14。
        /// </summary>
        public string ValidTerm { get; set; }

        /// <summary>
        /// 是否有发票,true/false。
        /// </summary>
        public string HasInvoice { get; set; }

        /// <summary>
        /// 是否有保修,true/false。
        /// </summary>
        public string HasWarranty { get; set; }

        /// <summary>
        /// 自动上架,true/false。
        /// </summary>
        public string AutoRepost { get; set; }

        /// <summary>
        /// 橱窗推荐,true/false。
        /// </summary>
        public string HasShowcase { get; set; }

        /// <summary>
        /// 店铺类目列表。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 支持会员打折,true/false。
        /// </summary>
        public string HasDiscount { get; set; }

        /// <summary>
        /// 平邮费用,如5.00。
        /// </summary>
        public string PostFee { get; set; }

        /// <summary>
        /// 快递费用,如15.00。
        /// </summary>
        public string ExpressFee { get; set; }

        /// <summary>
        /// ems费用,如25.00。
        /// </summary>
        public string EmsFee { get; set; }

        /// <summary>
        /// 上架时间,如2008-05-26 09:12:00。
        /// </summary>
        public string EnlistTime { get; set; }

        /// <summary>
        /// 加价幅度。
        /// </summary>
        public string Increment { get; set; }

        /// <summary>
        /// 商品图片，要先上传图片后再提交测试，否则商品图片不会被修改。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 商品新旧程度(全新:new，闲置:unused，二手：second)。
        /// </summary>
        public string StuffStatus { get; set; }

        /// <summary>
        /// 商品的积分返点比例 例：5 表示5%的返点比例。
        /// </summary>
        public string AuctionPoint { get; set; }

        /// <summary>
        /// 属性值别名，如pid:vid:别名; pid1:vid1:别名1 pid:属性id vid:值id。总长度不超过512字节。
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性ID串，结构如：pid1,pid2。
        /// </summary>
        public string InputPids { get; set; }

        /// <summary>
        /// xx山寨|系列|xx系列,材质|xx材质,……，input_str需要与input_pids一一对应，因为有可能一件商品有多个可以自输入的属性。 长度小于4000字节。
        /// </summary>
        public string InputStr { get; set; }

        /// <summary>
        /// 更新的sku的数量串，结构如：2,3,.。
        /// </summary>
        public string SkuQuantities { get; set; }

        /// <summary>
        /// 更新的sku的价格串，结构如：10.00,5.00,.。
        /// </summary>
        public string SkuPrices { get; set; }

        /// <summary>
        /// 更新的sku的属性串，结构如：pid11:vid11;pid12:vid12,pid21:vid21;pid22:vid22,…。
        /// </summary>
        public string SkuProps { get; set; }

        /// <summary>
        /// 宝贝所属的运费模板ID，如果没有返回则说明没有使用运费模板。
        /// </summary>
        public string PostageId { get; set; }

        /// <summary>
        /// 商品文字的版本，繁体传入”zh_HK”，简体传入”zh_CN”，不传默认为简体。
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// 商家外部编码。
        /// </summary>
        public string OuterId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("cid", this.Cid);
            parameters.Add("props", this.Props);
            parameters.Add("num", this.Num);
            parameters.Add("price", this.Price);
            parameters.Add("title", this.Title);
            parameters.Add("desc", this.Desc);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("location.city", this.LocationCity);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("valid_thru", this.ValidTerm);
            parameters.Add("has_invoice", this.HasInvoice);
            parameters.Add("has_warranty", this.HasWarranty);
            parameters.Add("auto_repost", this.AutoRepost);
            parameters.Add("has_showcase", this.HasShowcase);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("express_fee", this.ExpressFee);
            parameters.Add("ems_fee", this.EmsFee);
            parameters.Add("list_time", this.EnlistTime);
            parameters.Add("increment", this.Increment);
            parameters.Add("stuff_status", this.StuffStatus);
            parameters.Add("auction_point", this.AuctionPoint);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("input_pids", this.InputPids);
            parameters.Add("input_str", this.InputStr);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_properties", this.SkuProps);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("lang", this.Lang);
            parameters.Add("outer_id", this.OuterId);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
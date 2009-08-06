using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.get
    /// </summary>
    public class PictureGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段，根据Picture中的以下字段：picture_id,picture_category_id,picture_path,title,sizes,pixel,status,deleted,created,modified，多个字段用,分隔。如：picture_path,title,sizes。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 图片ID。
        /// </summary>
        public string PicId { get; set; }

        /// <summary>
        /// 图片分类ID。
        /// </summary>
        public string PicCategoryId { get; set; }

        /// <summary>
        /// 是否删除,unfroze代表没有删除。
        /// </summary>
        public string Deleted { get; set; }

        /// <summary>
        /// 图片编辑时间,返回的是图片最后修改（包括标题、分类、内容）时间为大于这个时间点的图片。
        /// </summary>
        public string Modified { get; set; }

        /// <summary>
        /// 图片标题,最大长度50字符,中英文都算一字符。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图片查询结果排序,time:desc按上传时间从晚到早(默认), time:asc按上传时间从早到晚,sizes:desc按图片从大到小，sizes:asc按图片从小到大,默认time:desc。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码.传入值为1代表第一页,传入值为2代表第二页,依此类推,默认值为1。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数.每页返回最多返回100条,默认值40。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 查询上传开始时间点,格式:yyyy-MM-dd HH:mm:ss。
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 查询上传结束时间点,格式:yyyy-MM-dd HH:mm:ss。
        /// </summary>
        public string EndDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("picture_id", this.PicId);
            parameters.Add("picture_category_id", this.PicCategoryId);
            parameters.Add("deleted", this.Deleted);
            parameters.Add("modified_time", this.Modified);
            parameters.Add("title", this.Title);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("end_date", this.EndDate);

            return parameters;
        }

        #endregion
    }
}

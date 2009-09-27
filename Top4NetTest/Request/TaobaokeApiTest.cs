﻿using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class TaobaokeApiTest
    {
        [TestMethod]
        public void GetTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url";
            request.Nick = "sns";
            request.Keyword = "sns";
            request.StartPrice = "100";
            request.EndPrice = "200";
            request.AutoSend = false;
            request.Area = "杭州";
            request.StartCredit = "1crown";
            request.EndCredit = "3crown";
            request.OrderBy = "commissionNum_desc";
            request.IsGuarantee = true;
            request.PageSize = 6;
            request.PageNo = 1;
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListJsonParser()).Content;
            Assert.AreEqual(6, items.Count);
        }

        [TestMethod]
        public void GetTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url";
            request.Nick = "12345678_0_0";
            request.Keyword = "test";
            request.PageSize = 5;

            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListXmlParser()).Content;
            Assert.AreEqual(5, items.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeItemsConvertRequest request = new TaobaokeItemsConvertRequest();
            request.Fields = "iid,click_url,iid,commission,commission_rate,commission_num,commission_volume";
            request.Iids = "18052f24da6a89ef989cdc401036300f,18052f24da6a89ef989cdc401036300f";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListJsonParser()).Content;
            Assert.AreEqual(2, items.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeItemsConvertRequest request = new TaobaokeItemsConvertRequest();
            request.Fields = "iid,click_url,iid,commission,commission_rate,commission_num,commission_volume";
            request.Iids = "18052f24da6a89ef989cdc401036300f,18052f24da6a89ef989cdc401036300f";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListXmlParser()).Content;
            Assert.AreEqual(2, items.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeShopsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeShopsConvertRequest request = new TaobaokeShopsConvertRequest();
            request.Fields = "user_id,shop_title,click_url,shop_commission.rate";
            request.Sids = "79852143,456,789";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeShop> shops = client.Execute(request, new TaobaokeShopListJsonParser()).Content;
            Assert.AreEqual(3, shops.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeShopsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeShopsConvertRequest request = new TaobaokeShopsConvertRequest();
            request.Fields = "user_id,shop_title,click_url,shop_commission.rate";
            request.Sids = "79852143,456,789";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeShop> shops = client.Execute(request, new TaobaokeShopListXmlParser()).Content;
            Assert.AreEqual(3, shops.Count);
        }

        [TestMethod]
        public void GetTaobaokeListUrlByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            TaobaokeListUrlGetRequest request = new TaobaokeListUrlGetRequest();
            request.Query = "三星";
            request.Nick = "tbtest520";
            request.OuterCode = "123456";
            string rsp = client.Execute(request, new TaobaokeListUrlJsonParser());
            Assert.IsNotNull(rsp);
        }

        [TestMethod]
        public void GetTaobaokeListUrlByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            TaobaokeListUrlGetRequest request = new TaobaokeListUrlGetRequest();
            request.Query = "三星";
            request.Nick = "tbtest520";
            request.OuterCode = "123456";
            string rsp = client.Execute(request, new TaobaokeListUrlXmlParser());
            Assert.IsNotNull(rsp);
        }

        [TestMethod]
        public void GetTaobaokeReportByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeReportGetRequest request = new TaobaokeReportGetRequest();
            request.Fields = "trade_id,pay_time,pay_price,auction_id";
            request.Date = "20090322";
            string session = TestUtils.GetSandboxSessionKey("alipublic05");
            string rsp = client.Execute(request, new StringParser(), session);
            Console.WriteLine(rsp);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace web.Controllers
{
    public class BoxController : Controller
    {
        private sqlsvr db = new sqlsvr();

        public BoxController(ILogger<BoxController> logger)
        {
        }

        public ActionResult Init()
        {
            // TODO 現在の予約済み席を設定
            ViewBag.reserved = NowReserved();

            return View("box");
        }

        [HttpPost]
        public ActionResult Register(String register, String box_num)
        {
            // TODO 現在の予約済み席を設定
            ViewBag.reserved = NowReserved();

            // 単項目チェック
            if (box_num == null || box_num.Equals("")) {
                return View("box");
            }

            // 半角数字チェック
            if (!Regex.IsMatch(box_num, @"^[0-9a-zA-Z]+$")) {
                return View("box");
            }

            // 限界値チェック
            if (int.Parse(box_num) < 0 || int.Parse(box_num) > 60) {
                return View("box");
            }

            if ("予約".Equals(register)) {
                Reserve(box_num);
            }

            if ("予約取消".Equals(register)) {
                Cancel();
            }

            return View("box");
        }

        private List<string> NowReserved() {
            return new List<string>() { "1", "10", "50" };
        }

        private void Reserve(String box_num) {
            // 予約済みじゃないかチェック
            // OKなら登録
        }

        private void Cancel() {
            // 予約済みかチェック
            // OKなら削除
        }
    }
}

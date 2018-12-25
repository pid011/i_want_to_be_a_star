﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IWantToBeAStar
{
    internal class GameStrings
    {
        private static readonly Dictionary<string, string> values
            = new Dictionary<string, string>()
            {
                {
                    "ScoreStatusHeader_NotAccomplish",
                    "이런!"
                },
                {
                    "ScoreStatusHeader_Accomplish", 
                    "(박수 짝짝)"
                },
                {
                    "ScoreStatusBody_NotAccomplish",
                    "기본 상품을 받을려면 400점을 넘기셔야 해요..!"
                },
                {
                    "ScoreStatusBody_Accomplish",
                    "기본상품을 아직 받지 못했을 경우 스태프에게 " +
                    "해당 점수를 보여주시면 기본상품을 드립니다." +
                    "\n\n(기본상품은 한번만 받을 수 있습니다.)"
                }
            };

        internal static string GetString(string name)
        {
            return values[name];
        }
    }
}

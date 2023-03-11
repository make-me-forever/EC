using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace HwEcAuto
{
    class PS
    {
        // ----------------------------------白系列---------------------------------
        public Color White          = Color.FromArgb(255, 255, 255, 255); // 纯白
        public Color YueBai         = Color.FromArgb(255, 212, 229, 239); // 月白

        public Color XiYu           = Color.FromArgb(255, 235, 238, 232); // 皦玉
        public Color JiLiang        = Color.FromArgb(255, 235, 237, 223); // 吉量
        public Color ShaoFen        = Color.FromArgb(100, 224, 224, 208); // 韶粉
        public Color ShuangDi       = Color.FromArgb(255, 199, 198, 182); // 霜地

        public Color ShanFan        = Color.FromArgb(255, 245, 243, 242); // 山矾
        
        public Color BangRouBai     = Color.FromArgb(255, 249, 241, 219); // 蚌肉白
        public Color LiRouBai       = Color.FromArgb(255, 242, 230, 206); // 荔肉白
        public Color MiSe           = Color.FromArgb(255, 249, 223, 205); // 米色
        public Color FenBai         = Color.FromArgb(255, 251, 242, 227); // 粉白
        public Color YinBai         = Color.FromArgb(255, 241, 240, 237); // 银白
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------红系列---------------------------------
        public Color Red            = Color.FromArgb(255, 255, 000, 000); // 纯红

        public Color YingHua        = Color.FromArgb(255, 228, 184, 213); // 樱花
        public Color LianHong       = Color.FromArgb(255, 217, 160, 179); // 莲红
        public Color YinHong        = Color.FromArgb(255, 231, 202, 211); // 银红

        public Color TaoYao         = Color.FromArgb(255, 246, 190, 200); // 桃夭
        public Color YangFei        = Color.FromArgb(255, 240, 145, 160); // 杨妃
        public Color ChangChun      = Color.FromArgb(255, 220, 107, 130); // 长春
        public Color YaFei          = Color.FromArgb(255, 195, 092, 093); // 牙绯

        public Color HaiTianXia     = Color.FromArgb(255, 243, 166, 148); // 海天霞
        public Color JinYun         = Color.FromArgb(255, 238, 121, 089); // 缙云
        //public Color ChangChun      = Color.FromArgb(255, 186, 081, 064); // 长春
        public Color ShanHuHe       = Color.FromArgb(255, 193, 044, 031); // 珊瑚赫

        public Color YingYing       = Color.FromArgb(255, 249, 211, 227); // 盈盈
        public Color ShuiHong       = Color.FromArgb(255, 236, 176, 193); // 水红
        public Color SuMei          = Color.FromArgb(255, 221, 118, 148); // 苏梅
        public Color ZJPF           = Color.FromArgb(255, 167, 098, 131); // 紫茎屏风

        public Color ShuiHong1      = Color.FromArgb(255, 241, 196, 205); // 水红
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------黄系列---------------------------------
        public Color Yellow         = Color.FromArgb(255, 255, 255, 000); // 纯黄

        public Color HuangBaiYou    = Color.FromArgb(255, 255, 247, 153); // 黄白游
        public Color SongHua        = Color.FromArgb(255, 255, 238, 111); // 松花
        public Color XiangYe        = Color.FromArgb(255, 236, 212, 082); // 缃叶
        public Color CangHuang      = Color.FromArgb(255, 182, 160, 020); // 苍黄
        
        public Color XingRenHuang   = Color.FromArgb(255, 249, 236, 195); // 杏仁黄
        public Color MoLiHuang      = Color.FromArgb(255, 248, 223, 114); // 茉莉黄
        public Color MaiGanHuang    = Color.FromArgb(255, 248, 223, 112); // 麦秆黄
        public Color YCHH           = Color.FromArgb(255, 248, 223, 114); // 油菜花黄
        public Color RouSe          = Color.FromArgb(255, 247, 193, 115); // 肉色
        public Color NingMengHuang  = Color.FromArgb(255, 252, 211, 055); // 柠檬黄
        public Color JinGuaHuang    = Color.FromArgb(255, 252, 210, 023); // 金瓜黄
        public Color YouHuang       = Color.FromArgb(255, 241, 202, 023); // 柚黄
        public Color HuPo           = Color.FromArgb(255, 254, 186, 007); // 琥珀黄
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------蓝系列---------------------------------
        public Color Blue           = Color.FromArgb(255, 000, 000, 255); // 纯蓝
        public Color Cyan           = Color.FromArgb(255, 000, 255, 255); // 青色
        public Color QieLan         = Color.FromArgb(255, 212, 229, 239); // 窃蓝
        public Color ShanLan        = Color.FromArgb(255, 190, 210, 187); // 山岚
        public Color BiLuo          = Color.FromArgb(255, 174, 208, 238); // 碧落
        public Color LongGaoZhu     = Color.FromArgb(255, 212, 229, 239); // 龙膏烛

        public Color HuShuiLan      = Color.FromArgb(255, 176, 213, 223); // 湖水蓝
        public Color QiuBoLan       = Color.FromArgb(255, 138, 188, 209); // 秋波蓝
        public Color JianShiLan     = Color.FromArgb(255, 102, 169, 201); // 涧石蓝
        public Color JiLan          = Color.FromArgb(255, 099, 187, 208); // 霁青
        public Color BiQing         = Color.FromArgb(255, 092, 179, 204); // 碧青
        public Color HaiQing        = Color.FromArgb(100, 034, 162, 195); // 海青
        public Color HaiTianLan     = Color.FromArgb(255, 198, 230, 232); // 海天蓝
        public Color QingShuiLan    = Color.FromArgb(255, 147, 213, 220); // 清水蓝
        public Color PuBuLan        = Color.FromArgb(255, 081, 196, 211); // 瀑布蓝
        public Color WeiLan         = Color.FromArgb(255, 041, 183, 203); // 蔚蓝
        public Color KongQueLan     = Color.FromArgb(255, 014, 176, 201); // 孔雀蓝
        public Color DianZiLan      = Color.FromArgb(255, 016, 174, 194); // 甸子蓝
        //public Color HaiQing        = Color.FromArgb(255, 034, 162, 195); // 蓝
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------绿系列---------------------------------
        public Color Green          = Color.FromArgb(255, 000, 255, 000); // 纯绿
        public Color CangJia        = Color.FromArgb(255, 168, 191, 143); // 苍葭
        public Color TingWuLv       = Color.FromArgb(255, 104, 148, 092); // 庭芜绿
        public Color CuiWei         = Color.FromArgb(255, 076, 128, 069); // 翠微

        public Color TianPiao       = Color.FromArgb(255, 213, 235, 225); // 天缥
        public Color CangLang       = Color.FromArgb(255, 177, 213, 200); // 沧浪
        public Color CangLang2      = Color.FromArgb(255, 153, 188, 172); // 苍筤
        public Color PiaoBi         = Color.FromArgb(255, 128, 164, 146); // 缥碧

        public Color OuBi           = Color.FromArgb(255, 192, 214, 000); // 欧碧
        public Color ChunChen       = Color.FromArgb(255, 169, 190, 123); // 春辰
        public Color BiShan         = Color.FromArgb(255, 119, 150, 073); // 碧山
        public Color QingQing       = Color.FromArgb(255, 079, 111, 070); // 青青

        // 
        public Color ZhuHuangLv     = Color.FromArgb(255, 185, 222, 201); // 竹篁绿
        public Color FenLv          = Color.FromArgb(255, 131, 203, 172); // 粉绿
        public Color MaoLv          = Color.FromArgb(255, 102, 193, 140); // 毛绿
        public Color KouShaoLv      = Color.FromArgb(255, 093, 190, 138); // 蔻梢绿
        public Color MaiMiaoLv      = Color.FromArgb(255, 085, 187, 138); // 麦苗绿
        public Color WaLv           = Color.FromArgb(100, 069, 183, 135); // 蛙绿
        public Color TongLv         = Color.FromArgb(255, 043, 174, 133); // 铜绿
        public Color ZhuLv          = Color.FromArgb(255, 027, 167, 132); // 竹绿
        public Color LanLv          = Color.FromArgb(255, 018, 161, 130); // 蓝绿
        public Color MeiDieLv       = Color.FromArgb(255, 041, 183, 203); // 美蝶绿
        public Color ShiLv          = Color.FromArgb(255, 087, 195, 194); // 石绿
        public Color KongQueLv      = Color.FromArgb(255, 034, 148, 083); // 孔雀绿
        public Color HEX       = Color.FromArgb(255, 0x83, 0xcb, 0xac); // 美蝶绿
        public Color CMYK          = Color.FromArgb(64, 0, 46, 0); // 石绿
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------紫系列---------------------------------
        public Color Purple         = Color.FromArgb(255, 160, 032, 240); // 纯紫
        public Color ChangRong      = Color.FromArgb(255, 220, 199, 225); // 昌荣
        public Color ZiBaoHan       = Color.FromArgb(255, 220, 199, 225); // 紫薄汗
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂

        // ----------------------------------黑系列---------------------------------
        public Color Black          = Color.FromArgb(255, 000, 000, 000); // 纯黑
        // ⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂⌂
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    public enum WeChatEmotionType
    {
        Smile, //微笑
        TwitchMouth, //撇嘴
        Mad, //抓狂
        SpitOut, //吐
        Flirt, //色
        Giggle, //偷笑
        Gloat, //得意
        Daze, //发呆
        WhiteEyes, //白眼
        Weep, //流泪
        Proud, //傲慢
        Shy, //害羞
        Hungry, //饥饿
        Shutup, //闭嘴
        Sleepy, //困
        FallAsleep, //睡
        Frighten, //惊恐
        Cry, //大哭
        Swear, //流汗
        Embarrassed, //尴尬
        Simper, //憨笑
        Angry, //发怒
        Relaxed, //悠闲
        Naughty, //调皮
        Strive, //奋斗
        Toothy, //呲牙
        Curse, //咒骂
        Surprised, //惊讶
        Question, //疑问
        Sad, //难过
        Shh, //嘘
        Cool, //酷
        Faint, //晕
        ColdSweat, //冷汗
        Crazy, //疯了
        Decline, //衰
        BasketBall, //篮球
        Skeleton, //骷髅
        Pinpang, //乒乓
        Beat, //敲打
        Coffee, //咖啡
        Bye, //再见
        EatRice, //饭
        WipeOffSwear, //擦汗
        Pig, //猪头
        PickNose, //抠鼻
        Rose, //玫瑰
        Applause, //鼓掌
        Fade, //凋谢
        LoseFace, //糗大了
        ShowLove, //嘴唇
        BadAss, //坏笔
        Heart, //爱心
        LeftHum, //左哼哼
        RightHum, //右哼哼
        BreakHeart, //心碎
        Cake, //蛋糕
        Yawn, //哈欠
        Lightning, //闪电
        Disdain, //鄙视
        Bomb, //炸弹
        Knife, //刀
        HurtLook, //委屈
        Football, //足球
        AlmostCry, //快哭了
        LadyBug, //瓢虫
        Devious, //阴险
        Shit, //便便
        KissKiss, //亲亲
        Scared, //吓
        Moon, //月亮
        Sun, //太阳
        Poor, //可怜
        KitchenKnife, //菜刀
        Gift, //礼物
        Hug, //拥抱
        WaterMelon, //西瓜
        Beer, //啤酒
        Strong, //强
        Weak, //弱
        Trembling, //发抖
        ShakeHand, //握手
        ChokeWithAngry, //怄火
        Victory, //胜利
        Circle, //转圈
        HoldFist, //抱拳
        Kotow, //磕头
        Fist, //拳头
        Seduce, //勾引
        TurnBack, //回头
        SkipRope, //跳绳
        Bad, //差劲
        Surrender, //投降
        LoveYou, //爱你
        Excited, //激动
        No, //No
        Dance, //乱舞
        OK, //OK
        Kiss, //献吻
        Love, //爱情
        LeftTaiji, //左太极
        RightTaiji, //右太极
        AirKiss, //飞吻
        Jump //跳跳
    }
    public class WeChatEmotions
    {
        private static readonly Dictionary<string, WeChatEmotion> Emotions = new Dictionary<string, WeChatEmotion>();

        static WeChatEmotions()
        {
            Emotions.Add("Smile",new WeChatEmotion("/微笑","/::)"));
            Emotions.Add("TwitchMouth", new WeChatEmotion("/撇嘴", "/::~"));
            Emotions.Add("Mad", new WeChatEmotion("/抓狂", "/::Q"));
            Emotions.Add("SpitOut", new WeChatEmotion("/吐", "/::T"));
            Emotions.Add("Flirt", new WeChatEmotion("/色", "/::B"));
            Emotions.Add("Giggle", new WeChatEmotion("/偷笑", "/:,@P"));
            Emotions.Add("Gloat", new WeChatEmotion("/得意", "/:8-)"));
            Emotions.Add("Daze", new WeChatEmotion("/发呆", "/::|"));
            Emotions.Add("WhiteEyes", new WeChatEmotion("/白眼", "/::d"));
            Emotions.Add("Weep", new WeChatEmotion("/流泪", "/::<"));
            Emotions.Add("Proud", new WeChatEmotion("/傲慢", "/:,@o"));
            Emotions.Add("Shy", new WeChatEmotion("/害羞", "/::$"));
            Emotions.Add("Hungry", new WeChatEmotion("/饥饿", "/::g"));
            Emotions.Add("Shutup", new WeChatEmotion("/闭嘴", "/::X"));
            Emotions.Add("Sleepy", new WeChatEmotion("/困", "/:|-)"));
            Emotions.Add("FallAsleep", new WeChatEmotion("/睡", "/::Z"));
            Emotions.Add("Frighten", new WeChatEmotion("/惊恐", "/::!"));
            Emotions.Add("Cry", new WeChatEmotion("/大哭", "/::'("));
            Emotions.Add("Swear", new WeChatEmotion("/流汗", "/::L"));
            Emotions.Add("Embarrassed", new WeChatEmotion("/尴尬", "/::-|"));
            Emotions.Add("Simper", new WeChatEmotion("/憨笑", "/::>"));
            Emotions.Add("Angry", new WeChatEmotion("/发怒", "/::@"));
            Emotions.Add("Relaxed", new WeChatEmotion("/悠闲", "/::,@"));
            Emotions.Add("Naughty", new WeChatEmotion("/调皮", "/::P"));
            Emotions.Add("Strive", new WeChatEmotion("/奋斗", "/:,@f"));
            Emotions.Add("Toothy", new WeChatEmotion("/呲牙", "/::D"));
            Emotions.Add("Curse", new WeChatEmotion("/咒骂", "/::-S"));
            Emotions.Add("Surprised", new WeChatEmotion("/惊讶", "/::O"));
            Emotions.Add("Question", new WeChatEmotion("/疑问", "/:?"));
            Emotions.Add("Sad", new WeChatEmotion("/难过", "/::("));
            Emotions.Add("Shh", new WeChatEmotion("/嘘", "/:,@x"));
            Emotions.Add("Cool", new WeChatEmotion("/酷", "/::+"));
            Emotions.Add("Faint", new WeChatEmotion("/晕", "/:,@@"));
            Emotions.Add("ColdSweat", new WeChatEmotion("/冷汗", "/:--b"));
            Emotions.Add("Crazy", new WeChatEmotion("/疯了", "/::8"));
            Emotions.Add("Decline", new WeChatEmotion("/衰", "/:,@!"));
            Emotions.Add("BasketBall", new WeChatEmotion("/篮球", "/:basketb"));
            Emotions.Add("Skeleton", new WeChatEmotion("/骷髅", "/:!!!"));
            Emotions.Add("Pinpang", new WeChatEmotion("/乒乓", "/:oo"));
            Emotions.Add("Beat", new WeChatEmotion("/敲打", "/:xx"));
            Emotions.Add("Coffee", new WeChatEmotion("/咖啡", "/:coffee"));
            Emotions.Add("Bye", new WeChatEmotion("/再见", "/:bye"));
            Emotions.Add("EatRice", new WeChatEmotion("/饭", "/:eat"));
            Emotions.Add("WipeOffSwear", new WeChatEmotion("/擦汗", "/:wipe"));
            Emotions.Add("Pig", new WeChatEmotion("/猪头", "/:pig"));
            Emotions.Add("PickNose", new WeChatEmotion("/抠鼻", "/:dig"));
            Emotions.Add("Rose", new WeChatEmotion("/玫瑰", "/:rose"));
            Emotions.Add("Applause", new WeChatEmotion("/鼓掌", "/:handclap"));
            Emotions.Add("Fade", new WeChatEmotion("/凋谢", "/:fade"));
            Emotions.Add("LoseFace", new WeChatEmotion("/糗大了", "/:&-("));
            Emotions.Add("ShowLove", new WeChatEmotion("/嘴唇", "/:showlove"));
            Emotions.Add("BadAss", new WeChatEmotion("/坏笔", "/:B-)"));
            Emotions.Add("Heart", new WeChatEmotion("/爱心", "/:heart"));
            Emotions.Add("LeftHum", new WeChatEmotion("/左哼哼", "/:<@"));
            Emotions.Add("RightHum", new WeChatEmotion("/右哼哼", "/:@>"));
            Emotions.Add("BreakHeart", new WeChatEmotion("/心碎", "/:break"));
            Emotions.Add("Cake", new WeChatEmotion("/蛋糕", "/:cake"));
            Emotions.Add("Yawn", new WeChatEmotion("/哈欠", "/::-O"));
            Emotions.Add("Lightning", new WeChatEmotion("/闪电", "/:li"));
            Emotions.Add("Disdain", new WeChatEmotion("/鄙视", "/:>-|"));
            Emotions.Add("Bomb", new WeChatEmotion("/炸弹", "/:bome"));
            Emotions.Add("Knife", new WeChatEmotion("/刀", "/:kn"));
            Emotions.Add("HurtLook", new WeChatEmotion("/委屈", "/:P-("));
            Emotions.Add("Football", new WeChatEmotion("/足球", "/:footb"));
            Emotions.Add("AlmostCry", new WeChatEmotion("/快哭了", "/::'|"));
            Emotions.Add("LadyBug", new WeChatEmotion("/瓢虫", "/:ladybug"));
            Emotions.Add("Devious", new WeChatEmotion("/阴险", "/:X-)"));
            Emotions.Add("Shit", new WeChatEmotion("/便便", "/:shit"));
            Emotions.Add("KissKiss", new WeChatEmotion("/亲亲", "/::*"));
            Emotions.Add("Scared", new WeChatEmotion("/吓", "/:@x"));
            Emotions.Add("Moon", new WeChatEmotion("/月亮", "/:moon"));
            Emotions.Add("Sun", new WeChatEmotion("/太阳", "/:sun"));
            Emotions.Add("Poor", new WeChatEmotion("/可怜", "/:8*"));
            Emotions.Add("KitchenKnife", new WeChatEmotion("/菜刀", "/:pd"));
            Emotions.Add("Gift", new WeChatEmotion("/礼物", "/:gift"));
            Emotions.Add("Hug", new WeChatEmotion("/拥抱", "/:hug"));
            Emotions.Add("WaterMelon", new WeChatEmotion("/西瓜", "/:<W>"));
            Emotions.Add("Beer", new WeChatEmotion("/啤酒", "/:beer"));
            Emotions.Add("Strong", new WeChatEmotion("/强", "/:strong"));
            Emotions.Add("Weak", new WeChatEmotion("/弱", "/:weak"));
            Emotions.Add("Trembling", new WeChatEmotion("/发抖", "/:shake"));
            Emotions.Add("ShakeHand", new WeChatEmotion("/握手", "/:share"));
            Emotions.Add("ChokeWithAngry", new WeChatEmotion("/怄火", "/:<O>"));
            Emotions.Add("Victory", new WeChatEmotion("/胜利", "/:v"));
            Emotions.Add("Circle", new WeChatEmotion("/转圈", "/:circle"));
            Emotions.Add("HoldFist", new WeChatEmotion("/抱拳", "/:@)"));
            Emotions.Add("Kotow", new WeChatEmotion("/磕头", "/:kotow"));
            Emotions.Add("Fist", new WeChatEmotion("/拳头", "/:@@"));
            Emotions.Add("Seduce", new WeChatEmotion("/勾引", "/:jj"));
            Emotions.Add("TurnBack", new WeChatEmotion("/回头", "/:turn"));
            Emotions.Add("SkipRope", new WeChatEmotion("/跳绳", "/:skip"));
            Emotions.Add("Bad", new WeChatEmotion("/差劲", "/:bad"));
            Emotions.Add("Surrender", new WeChatEmotion("/投降", "/:oY"));
            Emotions.Add("LoveYou", new WeChatEmotion("/爱你", "/:lvu"));
            Emotions.Add("Excited", new WeChatEmotion("/激动", "/:#-0"));
            Emotions.Add("No", new WeChatEmotion("/No", "/:no"));
            Emotions.Add("Dance", new WeChatEmotion("/乱舞", "/:hiphot"));
            Emotions.Add("OK", new WeChatEmotion("/OK", "/:ok"));
            Emotions.Add("Kiss", new WeChatEmotion("/献吻", "/:kiss"));
            Emotions.Add("Love", new WeChatEmotion("/爱情", "/:love"));
            Emotions.Add("LeftTaiji", new WeChatEmotion("/左太极", "/:<&"));
            Emotions.Add("RightTaiji", new WeChatEmotion("/右太极", "/:&>"));
            Emotions.Add("AirKiss", new WeChatEmotion("/飞吻", "/:<L>"));
            Emotions.Add("Jump", new WeChatEmotion("/跳跳", "/:jump"));
        }

        public class WeChatEmotion {
            public WeChatEmotion(string textCode, string symbolCode)
            {
                this.TextCode = textCode;
                this.SymbolCode = symbolCode;
            }
            public string TextCode { get; set; }
            public string SymbolCode { get; set; }
        }

        public static WeChatEmotion GetEmotion(WeChatEmotionType emotion) {
            return Emotions[emotion.ToString()];
        }
    }
}

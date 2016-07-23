using Neuzilla.Wex.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wex.Core.Tests
{
    [TestFixture]
    public class WeChatEmotionTest
    {
        [Test]
        public void TestGetOneEmotion()
        {
            var x=WeChatEmotions.GetEmotion(WeChatEmotionType.AirKiss);
            Assert.AreEqual("/飞吻", x.TextCode);
            Assert.AreEqual("/:<L>", x.SymbolCode);
        }
    }
}

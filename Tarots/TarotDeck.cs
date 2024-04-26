
public class TarotDeck
{
    private static Random random = new Random();

    public List<TarotCard> GenerateThreeCards()
    {
        // 韦特塔罗牌的图案和描述，您可以根据需要自定义
        List<TarotCard> tarotCards = new List<TarotCard>
        {
            new TarotCard {No = 0, Name = "愚人", Description = "愚人代表着一种新的开始，一种新的旅程。"},
            new TarotCard {No = 1, Name = "魔术师", Description = "魔术师代表着行动力、自信和创造力。"},
            new TarotCard {No = 2, Name = "女祭司", Description = "女祭司代表着直觉、智慧和秘密。"},
            new TarotCard {No = 3, Name = "皇后", Description = "皇后代表着女性、母性和丰富。"},
            new TarotCard {No = 4, Name = "皇帝", Description = "皇帝代表着男性、父性和权威。"},
            new TarotCard {No = 5, Name = "教皇", Description = "教皇代表着信仰、慈悲和传统。"},
            new TarotCard {No = 6, Name = "恋人", Description = "恋人代表着爱情、关系和决定。"},
            new TarotCard {No = 7, Name = "战车", Description = "战车代表着意志、决心和胜利。"},
            new TarotCard {No = 8, Name = "力量", Description = "力量代表着勇气、耐心和自制。"},
            new TarotCard {No = 9, Name = "隐士", Description = "隐士代表着独处、寻求和思考。"},
            new TarotCard {No = 10, Name = "命运之轮", Description = "命运之轮代表着改变、转折和运气。"},
            new TarotCard {No = 11, Name = "正义", Description = "正义代表着公平、平衡和判断。"},
            new TarotCard {No = 12, Name = "倒吊人", Description = "倒吊人代表着牺牲、放弃和暂停。"},
            new TarotCard {No = 13, Name = "死神", Description = "死神代表着结束、转变和新的开始。"},
            new TarotCard {No = 14, Name = "节制", Description = "节制代表着平衡、和谐和调和。"},
            new TarotCard {No = 15, Name = "恶魔", Description = "恶魔代表着恐惧、束缚和烦恼。"},
            new TarotCard {No = 16, Name = "高塔", Description = "高塔代表着破坏、混乱和重建。"},
            new TarotCard {No = 17, Name = "星星", Description = "星星代表着希望、信心和灵感。"},
            new TarotCard {No = 18, Name = "月亮", Description = "月亮代表着幻觉、不安和恐惧。"},
            new TarotCard {No = 19, Name = "太阳", Description = "太阳代表着快乐、成功和荣誉。"},
            new TarotCard {No = 20, Name = "审判", Description = "审判代表着觉醒、决定和悔恨。"},
            new TarotCard {No = 21, Name = "世界", Description = "世界代表着成就、完成和成功。"},
            new TarotCard {No = 22, Name = "宝剑1", Description = "宝剑1代表着新的思想、新的观点和新的计划。"},
            new TarotCard {No = 23, Name = "宝剑2", Description = "宝剑2代表着不稳定、不安和无法决定。"},
            new TarotCard {No = 24, Name = "宝剑3", Description = "宝剑3代表着失望、悲伤和悔恨。"},
            new TarotCard {No = 25, Name = "宝剑4", Description = "宝剑4代表着疾病、不幸和痛苦。"},
            new TarotCard {No = 26, Name = "宝剑5", Description = "宝剑5代表着失败、损失和破坏。"},
            new TarotCard {No = 27, Name = "宝剑6", Description = "宝剑6代表着旅行、逃避和远离。"},
            new TarotCard {No = 28, Name = "宝剑7", Description = "宝剑7代表着谣言、谎言和欺骗。"},
            new TarotCard {No = 29, Name = "宝剑8", Description = "宝剑8代表着不幸、失败和分离。"},
            new TarotCard {No = 30, Name = "宝剑9", Description = "宝剑9代表着焦虑、忧虑和悲伤。"},
            new TarotCard {No = 31, Name = "宝剑10", Description = "宝剑10代表着痛苦、悲伤和悔恨。"},
            new TarotCard {No = 32, Name = "宝剑侍从", Description = "宝剑侍从代表着不成熟、不安和不稳定。"},
            new TarotCard {No = 33, Name = "宝剑骑士", Description = "宝剑骑士代表着思想、行动和冒险。"},
            new TarotCard {No = 34, Name = "宝剑皇后", Description = "宝剑皇后代表着思想、分析和独立。"},
            new TarotCard {No = 35, Name = "宝剑国王", Description = "宝剑国王代表着权威、判断和领导。"},
            new TarotCard {No = 36, Name = "圣杯1", Description = "圣杯1代表着新的爱、新的关系和新的机会。"},
            new TarotCard {No = 37, Name = "圣杯2", Description = "圣杯2代表着和谐、和平和合作。"},
            new TarotCard {No = 38, Name = "圣杯3", Description = "圣杯3代表着幸福、满足和喜悦。"},
            new TarotCard {No = 39, Name = "圣杯4", Description = "圣杯4代表着不稳定、不安和不满足。"},
            new TarotCard {No = 40, Name = "圣杯5", Description = "圣杯5代表着失望、损失和悲伤。"},
            new TarotCard {No = 41, Name = "圣杯6", Description = "圣杯6代表着慈善、无私和帮助。"},
            new TarotCard {No = 42, Name = "圣杯7", Description = "圣杯7代表着幻觉、不安和欺骗。"},
            new TarotCard {No = 43, Name = "圣杯8", Description = "圣杯8代表着失望、不满和悲伤。"},
            new TarotCard {No = 44, Name = "圣杯9", Description = "圣杯9代表着幻觉、不安和幻想。"},
            new TarotCard {No = 45, Name = "圣杯10", Description = "圣杯10代表着满足、和谐和幸福。"},
            new TarotCard {No = 46, Name = "圣杯侍从", Description = "圣杯侍从代表着幼稚、不成熟和不负责任。"},
            new TarotCard {No = 47, Name = "圣杯骑士", Description = "圣杯骑士代表着情感、热情和浪漫。"},
            new TarotCard {No = 48, Name = "圣杯皇后", Description = "圣杯皇后代表着感情、直觉和善良。"},
            new TarotCard {No = 49, Name = "圣杯国王", Description = "圣杯国王代表着感情、直觉和善良。"},
            new TarotCard {No = 50, Name = "权杖1", Description = "权杖1代表着新的机遇、新的开始和新的计划。"},
            new TarotCard {No = 51, Name = "权杖2", Description = "权杖2代表着合作、平衡和和谐。"},
            new TarotCard {No = 52, Name = "权杖3", Description = "权杖3代表着成功、荣耀和荣誉。"},
            new TarotCard {No = 53, Name = "权杖4", Description = "权杖4代表着不稳定、不安和不满足。"},
            new TarotCard {No = 54, Name = "权杖5", Description = "权杖5代表着失败、损失和破坏。"},
            new TarotCard {No = 55, Name = "权杖6", Description = "权杖6代表着成功、荣耀和荣誉。"},
            new TarotCard {No = 56, Name = "权杖7", Description = "权杖7代表着谣言、谎言和欺骗。"},
            new TarotCard {No = 57, Name = "权杖8", Description = "权杖8代表着失败、损失和破坏。"},
            new TarotCard {No = 58, Name = "权杖9", Description = "权杖9代表着疯狂、焦虑和不安。"},
            new TarotCard {No = 59, Name = "权杖10", Description = "权杖10代表着成功、荣耀和荣誉。"},
            new TarotCard {No = 60, Name = "权杖侍从", Description = "权杖侍从代表着幼稚、不成熟和不负责任。"},
            new TarotCard {No = 61, Name = "权杖骑士", Description = "权杖骑士代表着行动、勇气和冒险。"},
            new TarotCard {No = 62, Name = "权杖皇后", Description = "权杖皇后代表着活力、热情和独立。"},
            new TarotCard {No = 63, Name = "权杖国王", Description = "权杖国王代表着活力、热情和独立。"},
            new TarotCard {No = 64, Name = "宝剑1", Description = "宝剑1代表着新的思想、新的想法和新的计划。"},
            new TarotCard {No = 65, Name = "宝剑2", Description = "宝剑2代表着不和谐、不稳定和不安。"},
            new TarotCard {No = 66, Name = "宝剑3", Description = "宝剑3代表着失望、失去和悲伤。"},
            new TarotCard {No = 67, Name = "宝剑4", Description = "宝剑4代表着不稳定、不安和不满足。"},
            new TarotCard {No = 68, Name = "宝剑5", Description = "宝剑5代表着失败、损失和破坏。"},
            new TarotCard {No = 69, Name = "宝剑6", Description = "宝剑6代表着成功、荣耀和荣誉。"},
            new TarotCard {No = 70, Name = "宝剑7", Description = "宝剑7代表着谣言、谎言和欺骗。"},
            new TarotCard {No = 71, Name = "宝剑8", Description = "宝剑8代表着失败、损失和破坏。"},
            new TarotCard {No = 72, Name = "宝剑9", Description = "宝剑9代表着焦虑、疯狂和不安。"},
            new TarotCard {No = 73, Name = "宝剑10", Description = "宝剑10代表着失败、损失和破坏。"},
            new TarotCard {No = 74, Name = "宝剑侍从", Description = "宝剑侍从代表着幼稚、不成熟和不负责任。"},
            new TarotCard {No = 75, Name = "宝剑骑士", Description = "宝剑骑士代表着行动、勇气和冒险。"},
            new TarotCard {No = 76, Name = "宝剑皇后", Description = "宝剑皇后代表着独立、果断和坚定。"},
            new TarotCard {No = 77, Name = "宝剑国王", Description = "宝剑国王代表着独立、果断和坚定。"},
        };

        // 随机选择三张牌，并随机确定正位或逆位
        List<TarotCard> threeCards = new List<TarotCard>();
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(tarotCards.Count);
            TarotCard selectedCard = tarotCards[index];
            selectedCard.IsUpright = random.Next(2) == 0; // 50% 的概率决定是否正位
            threeCards.Add(selectedCard);
            tarotCards.RemoveAt(index);
        }

        return threeCards;
    }
}
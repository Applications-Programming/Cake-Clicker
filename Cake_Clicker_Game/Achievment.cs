using DataBaseManagerLibrary;

namespace Cake_Clicker_Game
{
    public class Achievement
    {
        public struct AchievementInfo
        {
            public string Name;
            public bool Active;
        }

        static private int achievementCount = 4;
        public AchievementInfo[] achievements = new AchievementInfo[achievementCount];

        public Achievement()
        {
            achievements[0].Name = "Cake Novice";
            achievements[0].Active = false;

            achievements[1].Name = "Cake Master";
            achievements[1].Active = false;

            achievements[2].Name = "Bakery Legend";
            achievements[2].Active = false;

            achievements[3].Name = "Recipe Book";
            achievements[3].Active = false;
        }

        public void GetGameData(UserData data)
        {
            if (data.amountOfCake >= 100)
            {
                achievements[0].Active = true;
            }

            if (data.amountOfCake >= 1000)
            {
                achievements[1].Active = true;
            }

            if (data.amountOfCake >= 10000)
            {
                achievements[2].Active = true;
            }

            if (achievements[3].Active == false)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (data.upgradeCount[i] == 0)
                    {
                        achievements[3].Active = false;
                        break;
                    }
                    achievements[3].Active = true;
                }
            }
        }

        public bool IsAchievementActive(string achievementName)
        {
            for (int i = 0; i < achievementCount; i++)
            {
                if (achievements[i].Name == achievementName)
                {
                    return true;
                }
            }
            return false;
        }

        public void ResetAchievements()
        {
            for (int i = 0; i < achievementCount; i++)
            {
                achievements[i].Active = false;
            }
        }

        public void ActivateAll()
        {
            for (int i = 0; i < achievementCount; i++)
            {
                achievements[i].Active = true;
            }
        }

        public bool[] GetAchivementsInfo()
        {
            bool[] achivementsStatus = new bool[4];
            for (int i = 0; i < 4; ++i)
            {
                achivementsStatus[i] = achievements[i].Active;
            }
            return achivementsStatus;
        }
    }
}

using System;

namespace Utilities.SavingSystem
{
    [Serializable]
    public class SaveData
    {
        // Mode Standard
        public int levelUnlockedStandard = 1;
        public bool newLevelAnimated = false;
        public int[] scoreListStandard;
    }
}
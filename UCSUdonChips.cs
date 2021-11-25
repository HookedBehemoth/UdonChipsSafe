using UdonSharp;
using MelonLoader;

namespace UCS {
    public class UdonChips : UdonSharpBehaviour {
        private const string Category = nameof(UdonChips);
        private const string Name = "Money";
        static MelonPreferences_Entry<float> entry;
        public float money = 1000;

        public string format = "$ {0:F0}";

        static bool loaded = false;
        public void Start() {
            if (!loaded) {
                MelonPreferences.CreateCategory(Category);
                entry = MelonPreferences.CreateEntry(Category, Name, money);
                loaded = true;
            }
            money = entry.Value;
        }
        public void OnDestroy() {
            entry.Value = money;
            MelonPreferences.Save();
        }
    }
}

using MelonLoader;
using static FakeUdon.FakeUdonRegistry;

[assembly: MelonInfo(typeof(UdonChipsSafe.Starter), nameof(UdonChipsSafe), "1.0", "Behemoth")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace UdonChipsSafe {
    public class Starter : MelonMod {
        public override void OnApplicationStart() {
            RegisterType<UdonChipsSafe.UdonChips>("c266c8322c0c75349b2f2d9a1c44aec1");
        }
    }
}

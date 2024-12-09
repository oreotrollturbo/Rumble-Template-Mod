using MelonLoader;
using BuildInfo = TestMod.BuildInfo;
using RumbleModdingAPI;

[assembly: MelonInfo(typeof(TestMod.Class1), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.Author)]
[assembly: MelonGame(null, null)]

namespace TestMod
{
    public static class BuildInfo
    {
        public const string ModName = "Test mod";
        public const string ModVersion = "1.0";
        public const string Description = "God knows";
        public const string Author = "oreotrollutrbo";
        public const string Company = "Crusalis LLC";
    }

    public class Class1 : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

        }
    }
}
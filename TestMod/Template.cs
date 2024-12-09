using MelonLoader;
using BuildInfo = TestMod.BuildInfo;
using RumbleModdingAPI;

[assembly: MelonInfo(typeof(TestMod.Template), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.Author)]
[assembly: MelonGame("Buckethead Entertainment", "RUMBLE")]

namespace TestMod 
{
    public static class BuildInfo
    {
        public const string ModName = "YOUR MOD NAME";
        public const string ModVersion = "1.0";
        public const string Description = "Your description";
        public const string Author = "You";
        public const string Company = "Can be null or full on deleted";
    }

    public class Template : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "Gym") {
                MelonLogger.Msg("test");
            }
        }
    }
}
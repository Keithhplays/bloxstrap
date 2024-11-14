using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloxstrap.AppData
{
    public class RobloxPlayerData : CommonAppData, IAppData
    {
        public string ProductName => "Roblox";

        public string BinaryType => "Windowsplayer";

        public string RegistryName => "RobloxPlayer";

        public override string ExecutableName => "Roblox.client";

        public override string Directory => Path.Combine(Paths.Roblox, "Player");

        public string OldDirectory => Path.Combine(Paths.Roblox, "Player.old");

        public AppState State => App.State.Prop.Player;

        public override IReadOnlyDictionary<string, string> PackageDirectoryMap { get; set; } = new Dictionary<string, string>()
        {
            { "RobloxApp.zip", @"" }
        };
    }
}

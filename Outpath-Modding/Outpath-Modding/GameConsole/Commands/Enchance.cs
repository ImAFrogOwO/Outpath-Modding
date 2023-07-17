using Outpath_Modding.GameConsole.Components;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Outpath_Modding.GameConsole.Commands
{
    public class Enhance : ICommand
    {
        public string Command { get; set; } = "enhance";
        public string[] Abbreviate { get; set; } = new string[] { };
        public string Description { get; set; } = "Graphics go brrrrr";

        private RLProColormapPalette[] Color;

        public bool Execute(string[] args, out string reply)
        {
            if (args == null || args.Length <= 0)
            {
                string name = SceneManager.GetActiveScene().name;
          			bool flag = name == "Scene_Game";
          			if (flag)
          			{
          				this.Color = Object.FindObjectsOfType<RLProColormapPalette>();
          				foreach (RLProColormapPalette rlproColormapPalette in this.Color)
          				{
          					rlproColormapPalette.resolution.value = new Vector2Int(40000, 40000);
          				}
          			}
                return true;
            }
        }
    }
}

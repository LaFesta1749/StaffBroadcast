using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcByWho
{
    public class Config : IConfig
    {
        [Description("Determines wether the Plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Determines wether the Plugin DEBUG mode is enabled or not (not recommended)")]
        public bool Debug { get; set; } = false;

        [Description("--------------------------------\n'Admin Message' upper text")]
        public string AdminMessage { get; set; } = "<color=#3266a8>[</color><color=#c97b32>ADMIN MESSAGE</color><color=#3266a8>]</color>";

        [Description("Insert the color you want to use to display the 'Staff Name'")]
        public string StaffNameColor { get; set; } = "#b84848";
    }
}
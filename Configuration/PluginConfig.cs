using System.Collections.Generic;
using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;
using BeatSaberMarkupLanguage.Attributes;

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]

namespace RunCommands.Configuration
{

    internal class CommandDefinition
    {
        [UIValue("name")]
        public string Name;
        [UIValue("description")]
        public string Description;
        public string Command;
    };

    internal class RunCommandsPluginConfig
    {
        internal static RunCommandsPluginConfig Instance { get; set; }

        [UseConverter(typeof(ListConverter<CommandDefinition>))]
        public virtual List<CommandDefinition> Commands { get; set; } = new List<CommandDefinition>();

        public virtual void Changed()
        {

        }

        public virtual void OnReload()
        {

        }
    }
}
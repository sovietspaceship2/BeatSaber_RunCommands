using HMUI;
using Zenject;
using System.Diagnostics;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.ViewControllers;
using RunCommands.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPA.Utilities.Async;

namespace RunCommands.Settings.UI
{
    [HotReload(RelativePathToLayout = @"Views\commandList.bsml")]
    [ViewDefinition("RunCommands.Settings.UI.Views.commandList.bsml")]
    internal class RunCommandsViewController : BSMLAutomaticViewController
    {
        public RunCommandsPluginConfig config;
        private CommandDefinition SelectedCommand;

        [UIComponent("commands-list")]
        public CustomCellListTableData customListTableData;

        public RunCommandsViewController()
        {
            AvailableCommands = new List<object>();
        }

        [Inject]
        public void Construct(RunCommandsPluginConfig pluginConfig)
        {
            config = pluginConfig;
        }

        [UIAction("command-Select")]
        public void Select(TableView _, object @object)
        {
            SelectedCommand = @object as CommandDefinition;
        }

        [UIAction("runSelected")]
        public void Run()
        {
            if (SelectedCommand != null)
            {
                Process.Start(SelectedCommand.Command);
            }
        }

        [UIValue("available-commands")]
        internal List<object> AvailableCommands { get; } = new List<object>();

        [UIAction("#post-parse")]
        async public void SetupList()
        {
            if (config.Commands != null)
            {
                await RefreshList();
            }
        }

        async private Task RefreshList()
        {
            AvailableCommands.Clear();
            AvailableCommands.AddRange(config.Commands.OrderByDescending(x => x.Name).ToList());
            await UnityMainThreadTaskScheduler.Factory.StartNew(() => {
                customListTableData.tableView.ReloadData();
            }).ConfigureAwait(false);
        }
    }
}
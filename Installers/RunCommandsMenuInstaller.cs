
using Zenject;
using SiraUtil;
using RunCommands.Settings.UI;
using RunCommands.Managers;
using RunCommands.Configuration;
using IPA.Config.Stores;

namespace RunCommands.Installers
{
    internal class RunCommandsMenuInstaller : Installer<RunCommandsMenuInstaller>
    {
        public override void InstallBindings()
        {
            RunCommandsPluginConfig Config = IPA.Config.Config.GetConfigFor(Plugin.Name).Generated<RunCommandsPluginConfig>();
            Container.BindInstance(Config);

            Container.BindViewController<RunCommandsViewController>();
            Container.BindFlowCoordinator<RunCommandsFlowCoordinator>();

            Container.BindInterfacesAndSelfTo<MenuButtonManager>().AsSingle().NonLazy();
        }
    }
}
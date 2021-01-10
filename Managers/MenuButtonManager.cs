using System;
using Zenject;
using BeatSaberMarkupLanguage;
using RunCommands.Settings.UI;
using BeatSaberMarkupLanguage.MenuButtons;

namespace RunCommands.Managers
{
    internal class MenuButtonManager : IInitializable, IDisposable
    {
        private readonly MenuButton _menuButton;
        private readonly MainFlowCoordinator _mainFlowCoordinator;
        private readonly RunCommandsFlowCoordinator _runCommandsFlowCoordinator;

        public MenuButtonManager(MainFlowCoordinator mainFlowCoordinator, RunCommandsFlowCoordinator runCommandsFlowCoordinator)
        {
            _mainFlowCoordinator = mainFlowCoordinator;
            _runCommandsFlowCoordinator = runCommandsFlowCoordinator;
            _menuButton = new MenuButton("Run Commands", "Run Commands", ShowCommandList, true);
        }

        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose()
        {
            if (MenuButtons.IsSingletonAvailable)
            {
                MenuButtons.instance.UnregisterButton(_menuButton);
            }
        }

        private void ShowCommandList()
        {
            _mainFlowCoordinator.PresentFlowCoordinator(_runCommandsFlowCoordinator);
        }
    }
}
using HMUI;
using Zenject;
using BeatSaberMarkupLanguage;

namespace RunCommands.Settings.UI
{
    internal class RunCommandsFlowCoordinator : FlowCoordinator
    {
        MainFlowCoordinator _mainFlow;
        private RunCommandsViewController _runCommandsListView;

        [Inject]
        public void Construct(MainFlowCoordinator mainFlow, RunCommandsViewController runCommandsListView)
        {
            _mainFlow = mainFlow;
            _runCommandsListView = runCommandsListView;
        }

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (firstActivation)
            {
                SetTitle("Run Commands");
                showBackButton = true;
            }
            ProvideInitialViewControllers(_runCommandsListView);
        }

        protected override void BackButtonWasPressed(ViewController topViewController)
        {
            _mainFlow.DismissFlowCoordinator(this, null);
        }
    }
}
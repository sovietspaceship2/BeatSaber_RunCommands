using IPA;
using SiraUtil.Zenject;
using RunCommands.Installers;
using IPA.Logging;

namespace RunCommands
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        static public Logger Log { get; set; }

        static public string Name => "RunCommands";

        [Init]
        public Plugin(Logger log, Zenjector zenjector)
        {
            Log = log;
            zenjector.OnMenu<RunCommandsMenuInstaller>();
        }
    }
}

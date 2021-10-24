# RunCommands

Beat Saber mod that adds a menu to run custom system commands, accessible in the Mods panel.
Commands can be configured via `UserData/RunCommands.json`. See `RunCommands.example.json` for an example configuration file.
It uses [Process.Start](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start) to run the commands.

## Important Notice

Commands executed using this mod can do anything to your system, not just the game. They can destroy your computer, set your house on fire, or even elect Trump for a second term.
**Do not trust config files with commands you haven't verified yourself.** I'm not responsible for any config files downloaded from a rando on Discord that does something terrible.

## Building

Follow the setup described in [Modding Intro](https://bsmg.wiki/modding/intro.html). Make sure BeatSaberDir is set.

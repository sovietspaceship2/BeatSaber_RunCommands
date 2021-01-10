# RunCommands

Beat Saber mod that adds a menu to run custom system commands, accessible in the Mods panel.
Commands can be configured via `UserData/RunCommands.json`. See `RunCommands.example.json` for an example configuration file.
It uses [Process.Start](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start) to run the commands.

I made this to learn how to make mods for Beat Saber, but I will actually use it, so expect it to be kept up to date with the base game.

## Important Notice

Commands executed using this mod can do anything to your system, not just the game. They can destroy your computer, set your house on fire, or even elect Trump for a second term.
**Do not trust config files with commands you haven't verified yourself.** I'm not responsible for any config files downloaded from a rando on Discord that does something terrible.

## Building

Follow the setup described in [Modding Intro](https://bsmg.wiki/modding/intro.html). Make sure BeatSaberDir is set.

## Things I may add

- [Hide console window](https://stackoverflow.com/a/1469790) (maybe optional)
- Passing custom arguments, with maybe variables that get replaced to something about Beat Saber (idk, player location)
- A panel to view the command output

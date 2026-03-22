# AGENTS.md

## Scope

This file documents the repository rooted at `C:\Users\Rabin\source\repos\TTrainer`.

The repo contains one Visual Studio solution and one WinForms application project under `TTrainer/`.

## Top-Level Layout

- `TTrainer.sln`: Visual Studio 2022 solution with a single project
- `TTrainer/`: application source, resources, move-list data, and local build output
- `.gitignore`: standard Visual Studio ignore rules; `bin/`, `obj/`, `.vs/`, user files, and build output are treated as generated
- `.gitattributes`: default text normalization settings
- `.vs/`: Visual Studio workspace cache; do not edit

## Application Summary

`TTrainer/` is a Windows-only desktop tool for Tekken practice automation.

- Framework: classic WinForms on .NET Framework 4.7.2
- Startup path: `TTrainer/Program.cs` launches `Form1`
- Main logic: `TTrainer/Form1.cs`
- Command parser and key sender: `TTrainer/T7Command.cs`
- Global hotkeys: `TTrainer/KeyboardShortcut.cs`
- Binary dependency: `TTrainer/InputManager.dll`
- Move data: `TTrainer/tekken7/*.txt` and `TTrainer/tekken8/*.txt`

The app loads move lists from text files, displays them in a grid, and replays the selected command as synthetic keyboard input into a running game window.

## Key Source Files

- `TTrainer/Form1.cs`: file loading/saving, grid state, mode selection, player-side toggle, hotkey handlers, background execution loop
- `TTrainer/Form1.Designer.cs`: generated WinForms layout code
- `TTrainer/T7Command.cs`: parses command strings and sends key up/down events with frame timing
- `TTrainer/KeyboardShortcut.cs`: wraps `RegisterHotKey` / `UnregisterHotKey`
- `TTrainer/TTrainer.csproj`: old-style project file, content-copy rules, framework target, bundled binary reference
- `TTrainer/Properties/`: assembly metadata plus generated resource/settings files

## Move-List File Format

Move files use a two-line record format:

```text
#<frequency> <description>
<command string>
```

Blank lines between records are allowed.

Example:

```text
#50 1,1,2
1 w(5) 1 w(29) 2
```

Supported tokens in `TTrainer/T7Command.cs`:

- directions: `f`, `b`, `d`, `u`
- sidestep/random vertical: `s`
- attack buttons: `1`, `2`, `3`, `4`
- waits: `w`, `n`, `,`
- optional frame counts: `(number)` immediately after a token
- spaces are ignored

Anything else triggers an error dialog with line and character position information.

Keyboard layout depends on `T7Config`:

- `K1`: movement on `WASD`, buttons on `U I J K`
- `K2`: movement on arrow keys, buttons on numpad `7 8 4 5`

Player side flips the forward/back direction mapping.

## Runtime Behavior

`Form1` stores each loaded move as:

- enabled flag
- 1-based index
- description
- frequency
- hidden raw command string

Execution modes:

- randomize moves, weighted by frequency
- cycle through enabled moves
- repeat the selected move

Current global hotkeys:

- `Ctrl+Shift+E`: toggle auto-execution
- `Ctrl+Shift+S`: toggle P1/P2
- `Ctrl+Shift+Z`: advance to the next move, optionally starting execution
- `Ctrl+Shift+Alt+Z`: select the previous move

The app uses `Microsoft.VisualBasic.Interaction.AppActivate` to focus the target window. `Form1.cs` initializes the window title for Tekken 8 even though some UI labels still refer to Tekken 7.

## Build And Run

Preferred workflow:

1. Open `TTrainer.sln` in Visual Studio.
2. Build or run the `TTrainer` project with the .NET Framework 4.7.2 toolchain.

Important notes:

- This is an old-style .NET Framework project, not an SDK-style project
- `dotnet build` is not the reliable path here; in this environment it failed during WinForms resource generation because the older MSBuild/.NET Framework toolchain is expected
- No NuGet restore step is currently required
- `TTrainer/InputManager.dll` must be present beside the built executable
- `TTrainer/tekken7/*.*` and `TTrainer/tekken8/*.*` are copied to the output directory by the project file

## Editing Guidance

Prefer editing these handwritten files:

- `TTrainer/Form1.cs`
- `TTrainer/T7Command.cs`
- `TTrainer/KeyboardShortcut.cs`
- `TTrainer/Program.cs`
- `TTrainer/tekken7/*.txt`
- `TTrainer/tekken8/*.txt`

Treat these as generated, derived, or tool-managed:

- `TTrainer/Form1.Designer.cs`
- `TTrainer/Form1.resx`
- `TTrainer/Properties/Resources.Designer.cs`
- `TTrainer/Properties/Settings.Designer.cs`
- `TTrainer/bin/`
- `TTrainer/obj/`
- `.vs/`

Avoid editing `TTrainer/InputManager.dll`; the repository does not include its source.

If local build output exists under `TTrainer/bin/`, do not treat it as source of truth. Update move-list source files under `TTrainer/tekken7/` or `TTrainer/tekken8/` instead.

## Known Risks And Quirks

- Legacy naming mismatch: the form title is `T7Trainer`, config menu labels say `Tekken 7`, but the target window name is initialized for Tekken 8
- Worker threads are stopped with `Thread.Abort()`
- Frame timing in `TTrainer/T7Command.cs` uses a busy-wait loop and is timing-sensitive
- Global hotkeys affect the whole desktop session while the app is running
- Local output can drift from source; for example, a generated file such as `TTrainer/bin/Release/tekken8/lee.txt` may exist even when there is no matching source file under `TTrainer/tekken8/`

## Validation

There is no automated test suite in this repository.

Recommended manual checks after code changes:

1. Build in Visual Studio from `TTrainer.sln`.
2. Launch the app and load a sample file from `TTrainer/tekken7/` or `TTrainer/tekken8/`.
3. Verify add, update, delete, reorder, save, and load behavior in the grid.
4. Verify command execution against a safe target window before sending input to the actual game.
5. Re-test any hotkey or timing change carefully because it affects the desktop session and external application focus.

## Good First Reading Order

1. `TTrainer.sln`
2. `TTrainer/TTrainer.csproj`
3. `TTrainer/Program.cs`
4. `TTrainer/Form1.cs`
5. `TTrainer/T7Command.cs`
6. one sample file from `TTrainer/tekken8/` or `TTrainer/tekken7/`

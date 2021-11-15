using InputManager;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace TTrainer
{
    internal class T7Command
    {
        string command;
        T7Config config;
        bool p1;
        int line;
        List<PressedKey> pressed = new List<PressedKey>();
        int pos = 0;

        T7Command(string _command, T7Config _config, bool _p1, int _line)
        {
            command = _command;
            config = _config;
            p1 = _p1;
            line = _line;
        }

        void Execute()
        {
            for (; pos < command.Length; pos++)
            {
                var key = Keys.None;
                switch (command[pos])
                {
                    case 'f':
                    case 'F':
                        key = config == T7Config.K1 ? (p1 ? Keys.D : Keys.A) : (p1 ? Keys.Right : Keys.Left);
                        break;
                    case 'b':
                    case 'B':
                        key = config == T7Config.K1 ? (p1 ? Keys.A : Keys.D) : (p1 ? Keys.Left : Keys.Right);
                        break;
                    case 'd':
                    case 'D':
                        key = config == T7Config.K1 ? Keys.S : Keys.Down;
                        break;
                    case 'u':
                    case 'U':
                        key = config == T7Config.K1 ? Keys.W : Keys.Up;
                        break;
                    case '1':
                        key = config == T7Config.K1 ? Keys.U : Keys.NumPad7;
                        break;
                    case '2':
                        key = config == T7Config.K1 ? Keys.I : Keys.NumPad8;
                        break;
                    case '3':
                        key = config == T7Config.K1 ? Keys.J : Keys.NumPad4;
                        break;
                    case '4':
                        key = config == T7Config.K1 ? Keys.K : Keys.NumPad5;
                        break;
                    case 'n':
                    case 'N':
                    case 'w':
                    case 'W':
                    case ',':
                        int frames = GetFrames();
                        SleepUpTo(frames);
                        continue;
                    case ' ':
                        continue;
                    default:
                        throw new Exception($"Invalid character '{command[pos]}' at line {line} pos {pos + 1}.");
                }

                Keyboard.KeyDown(key);

                pressed.Add(new PressedKey
                {
                    key = key,
                    frames = GetFrames(),
                });
            }

            // clear remaining inputs
            SleepUpTo(-1);
        }

        private int GetFrames()
        {
            if (pos + 1 >= command.Length || command[pos + 1] != '(')
            {
                return 1;
            }

            pos++;

            for (int i = 1; pos + i < command.Length; i++)
            {
                if (command[pos + i] == ')')
                {
                    if (i == 1)
                    {
                        throw new Exception($"Unexpected '{command[pos + i]}' at line {line} pos {pos + i + 1}.");
                    }
                    var str = command.Substring(pos + 1, i - 1);
                    pos += i;
                    return int.Parse(str);
                }
                else if (!char.IsDigit(command[pos + i]))
                {
                    throw new Exception($"Invalid character '{command[pos + i]}' at line {line} pos {pos + i + 1}.");
                }
            }
            throw new Exception($"Missing closing ')' opened at line {line} pos {pos + 1}.");
        }

        private void SleepUpTo(int maxFrames)
        {
            // wait up to 600 frames (10 seconds) max
            for (var i = 0; i < 600 && (maxFrames == -1 || i < maxFrames); i++)
            {
                Thread.Sleep(TimeSpan.FromTicks(166_667)); // 1 frame = 16.6667 msec (60 fps)

                // release pressed keys
                var count = pressed.Count;
                if (count > 0)
                {
                    for (var j = count - 1; j >= 0; j--)
                    {
                        var el = pressed[j];
                        el.frames -= 1;
                        pressed[j] = el;
                        if (el.frames <= 0)
                        {
                            Keyboard.KeyUp(el.key);
                            pressed.RemoveAt(j);
                        }
                    }
                }
                else if (maxFrames == -1)
                {
                    break;
                }
            }
        }

        public static Thread ExecuteCmd(string _command, T7Config _config, bool _p1, int _line = 1)
        {
            var thread = new Thread(() =>
            {
                var t7cmd = new T7Command(_command, _config, _p1, _line);
                try
                {
                    t7cmd.Execute();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t7cmd.SleepUpTo(-1);
                }
            });
            thread.Start();
            return thread;
        }
        struct PressedKey
        {
            public Keys key;
            public int frames;
        }
    }

    public enum T7Config
    {
        K1, K2
    }
}

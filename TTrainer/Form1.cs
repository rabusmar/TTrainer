﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TTrainer
{
    public partial class Form1 : Form
    {
        int line = 0;
        string filename = null;
        bool updateLine = false, dirty = false;
        Thread thread = null;
        KeyboardShortcut hook1 = new KeyboardShortcut(), hook2 = new KeyboardShortcut();
        string term = "";

        public Form1()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook1.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook1_KeyPressed);
            // register the control + shift + e combination as hot key.
            hook1.RegisterHotKey(ModKeys.Control | ModKeys.Shift, Keys.E);

            // register the event that is fired after the key press.
            hook2.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook2_KeyPressed);
            // register the control + shift + s combination as hot key.
            hook2.RegisterHotKey(ModKeys.Control | ModKeys.Shift, Keys.S);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (activateApp())
            {
                Thread.Sleep(500);
                executeCmd(txtCmd.Text, line);
            }
        }

        private bool activateApp()
        {
            try
            {
                Interaction.AppActivate("TEKKEN 7");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("'TEKKEN 7' is not running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Thread executeCmd(string cmd, int index)
        {
            if (mnuT7K1.Checked)
            {
                return T7Command.ExecuteCmd(cmd, T7Config.K1, rbP1.Checked, index);
            }
            else if (mnuT7K2.Checked)
            {
                return T7Command.ExecuteCmd(cmd, T7Config.K2, rbP1.Checked, index);
            }
            else
            {
                throw new Exception();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var count = grdCommands.Rows.Count;
            if (count == 0)
            {
                line = 1;
            }
            else if (line == 0 || line > count)
            {
                line = grdCommands.Rows.Count + 1;
            }
            else
            {
                grdCommands.Rows[line - 1].Selected = false;
                line++;
            }
            grdCommands.Rows.Insert(line - 1, new object[] {
                $"{line}",
                txtDescription.Text,
                int.TryParse(txtFreq.Text, out var f) ? f.ToString() : "0",
                txtCmd.Text,
            });
            grdCommands.Rows[line - 1].Selected = true;
            //grdCommands.CurrentCell = grdCommands.Rows[line - 1].Cells[0];
            reindexGrid();
            dirty = true;
        }

        private void grdCommands_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            line = e.RowIndex + 1;
        }

        private void grdCommands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow(e.RowIndex);
        }

        private void selectRow(int index, bool setCurrentCell = false)
        {
            line = index + 1;
            var row = grdCommands.Rows[index];
            txtCmd.Text = row.Cells["colCmd"].Value.ToString();
            txtFreq.Text = row.Cells["colFreq"].Value.ToString();
            txtDescription.Text = row.Cells["colText"].Value.ToString();
            if (setCurrentCell)
            {
                grdCommands.CurrentCell = row.Cells[0];
                grdCommands.Refresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (line == 0 || line > grdCommands.Rows.Count)
            {
                return;
            }
            var row = grdCommands.Rows[line - 1];
            row.Cells["colText"].Value = txtDescription.Text;
            row.Cells["colFreq"].Value = txtFreq.Text;
            row.Cells["colCmd"].Value = txtCmd.Text;
            grdCommands.Refresh();
            dirty = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (line == 0 || line > grdCommands.Rows.Count)
            {
                return;
            }
            grdCommands.Rows.RemoveAt(line - 1);
            if (grdCommands.Rows.Count == 0)
            {
                line = 0;
            }
            else
            {
                if (line > grdCommands.Rows.Count)
                {
                    line = grdCommands.Rows.Count;
                }
                var row = grdCommands.Rows[line - 1];
                txtDescription.Text = row.Cells["colText"].Value.ToString();
                txtFreq.Text = row.Cells["colFreq"].Value.ToString();
                txtCmd.Text = row.Cells["colCmd"].Value.ToString();
                //row.Selected = true;
                grdCommands.CurrentCell = row.Cells[0];
            }
            reindexGrid();
            dirty = true;
        }

        private void reindexGrid()
        {
            var i = 1;
            foreach (DataGridViewRow row in grdCommands.Rows)
            {
                row.Cells["colIndex"].Value = (i++).ToString();
            }
            grdCommands.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (grdCommands.Rows.Count > 0 && MessageBox.Show("Are you sure?", "Confirm clear list", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                line = 0;
                grdCommands.Rows.Clear();
                grdCommands.Refresh();
                dirty = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (line - 1 <= 0 || line > grdCommands.Rows.Count)
            {
                return;
            }
            swapRows(line - 2, line - 1);
            //grdCommands.Rows[--line - 1].Selected = true;
            grdCommands.CurrentCell = grdCommands.Rows[--line - 1].Cells[0];
            grdCommands.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (line == 0 || line + 1 > grdCommands.Rows.Count)
            {
                return;
            }
            swapRows(line - 1, line);
            //grdCommands.Rows[++line - 1].Selected = true;
            grdCommands.CurrentCell = grdCommands.Rows[++line - 1].Cells[0];
            grdCommands.Refresh();
        }

        private void swapRows(int i, int j)
        {
            object tmp;
            var row1 = grdCommands.Rows[i];
            var row2 = grdCommands.Rows[j];
            tmp = row1.Cells["colText"].Value;
            row1.Cells["colText"].Value = row2.Cells["colText"].Value;
            row2.Cells["colText"].Value = tmp;
            tmp = row1.Cells["colFreq"].Value;
            row1.Cells["colFreq"].Value = row2.Cells["colFreq"].Value;
            row2.Cells["colFreq"].Value = tmp;
            tmp = row1.Cells["colCmd"].Value;
            row1.Cells["colCmd"].Value = row2.Cells["colCmd"].Value;
            row2.Cells["colCmd"].Value = tmp;
            //row1.Selected = row2.Selected = false;
            dirty = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dirty && MessageBox.Show("Are you sure you want to discard unsaved changes?", "Confirm load file", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //dialog.FilterIndex = 2;
                if (filename == null)
                {
                    dialog.InitialDirectory = Environment.CurrentDirectory;
                }
                else
                {
                    dialog.InitialDirectory = Path.GetDirectoryName(filename);
                    dialog.FileName = filename;
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    grdCommands.Rows.Clear();

                    filename = dialog.FileName;
                    var stream = dialog.OpenFile();
                    using (var reader = new StreamReader(stream))
                    {
                        int index = 1;
                        string str = null, freq = null, desc = null, cmd = null;
                        Regex regex = new Regex(@"#(\d+)\s+(.+)"), empty = new Regex(@"^\s*$");
                        while (!reader.EndOfStream)
                        {
                            str = reader.ReadLine();
                            var match = regex.Match(str);
                            if (match.Success)
                            {
                                freq = match.Groups[1].Value;
                                desc = match.Groups[2].Value;
                                cmd = reader.ReadLine();

                                grdCommands.Rows.Add(new object[] { $"{index++}", desc, freq, cmd });
                            }
                            else if (!empty.IsMatch(str))
                            {
                                MessageBox.Show($"Unexpected line: {str}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    grdCommands.Refresh();
                    dirty = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //dialog.FilterIndex = 2;
                if (filename == null)
                {
                    dialog.InitialDirectory = Environment.CurrentDirectory;
                }
                else
                {
                    dialog.InitialDirectory = Path.GetDirectoryName(filename);
                    dialog.FileName = filename;
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.FileName;
                    var stream = dialog.OpenFile();
                    using (var writer = new StreamWriter(stream))
                    {
                        foreach (DataGridViewRow row in grdCommands.Rows)
                        {
                            writer.WriteLine($"#{row.Cells["colFreq"].Value} {row.Cells["colText"].Value}");
                            writer.WriteLine(row.Cells["colCmd"].Value);
                            writer.WriteLine();
                        }
                    }
                    dirty = false;
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (true)
            {
                term = Interaction.InputBox("Search term", "Search", term);
                if (string.IsNullOrEmpty(term))
                {
                    return;
                }

                var n = grdCommands.Rows.Count;
                for (var i = 0; i < n; i++)
                {
                    var row = grdCommands.Rows[(line + i) % n];
                    var text = row.Cells["colText"].Value.ToString();
                    if (text.IndexOf(term, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        txtCmd.Text = row.Cells["colCmd"].Value.ToString();
                        txtFreq.Text = row.Cells["colFreq"].Value.ToString();
                        txtDescription.Text = text;
                        grdCommands.CurrentCell = row.Cells[0];
                        grdCommands.Refresh();
                        return;
                    }
                }
            }
        }

        private void hook1_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            chkActivate.Checked = !chkActivate.Checked;
        }

        private void hook2_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (rbP1.Checked)
            {
                rbP2.Checked = true;
            }
            else
            {
                rbP1.Checked = true;
            }
        }

        private void chkActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivate.Checked)
            {
                if (grdCommands.Rows.Count == 0) return;
                thread = new Thread(() =>
                {
                    var index = line > 0 ? line - 1 : 0;
                    var random = new Random();
                    List<int> list = null;

                    if (!activateApp()) return;

                    try
                    {
                        while (true)
                        {
                            // get next random index
                            if (mnuRandomize.Checked)
                            {
                                if (list == null)
                                {
                                    list = new List<int>();
                                    var n = grdCommands.Rows.Count;
                                    for (var i = 0; i < n; i++)
                                    {
                                        var freq = int.TryParse(grdCommands.Rows[i].Cells["colFreq"].Value.ToString(), out int f) ? f : 0;
                                        for (var j = 0; j < freq; j++)
                                        {
                                            list.Add(i);
                                        }
                                    }
                                }
                                var r = random.Next(list.Count);
                                index = list[r];
                            }

                            // execute 2 times to practice punish if repeat is enabled
                            for (var i = 0; i < (mnuRepeat.Checked ? 2 : 1); i++)
                            {
                                // try to clean previous state as much as possible
                                Thread.Sleep(2000);
                                executeCmd("b", 1).Join();
                                Thread.Sleep(1000);

                                line = index + 1;

                                // execute command
                                var cmd = grdCommands.Rows[index < grdCommands.Rows.Count ? index : 0].Cells["colCmd"].Value.ToString();
                                executeCmd(cmd, index + 1).Join();
                            }

                            if (mnuCycle.Checked)
                            {
                                index++;
                                if (index >= grdCommands.Rows.Count)
                                {
                                    index = 0;
                                }
                            }
                        }
                    }
                    catch (ThreadAbortException)
                    {
                        return;
                    }
                });
                thread.Start();
                updateLine = true;
            }
            else if (thread != null)
            {
                thread.Abort();
                thread = null;
            }
        }

        private void mnuT7K1_Click(object sender, EventArgs e)
        {
            mnuT7K1.Checked = true;
            mnuT7K2.Checked = false;
        }

        private void mnuRandomize_Click(object sender, EventArgs e)
        {
            mnuRandomize.Checked = true;
            mnuCycle.Checked = false;
            mnuSame.Checked = false;
        }

        private void mnuCycle_Click(object sender, EventArgs e)
        {
            mnuRandomize.Checked = false;
            mnuCycle.Checked = true;
            mnuSame.Checked = false;
        }

        private void mnuSame_Click(object sender, EventArgs e)
        {
            mnuRandomize.Checked = false;
            mnuCycle.Checked = false;
            mnuSame.Checked = true;

        }

        private void mnuRepeat_Click(object sender, EventArgs e)
        {
            mnuRepeat.Checked = !mnuRepeat.Checked;
        }

        private void mnuT7K2_Click(object sender, EventArgs e)
        {
            mnuT7K2.Checked = true;
            mnuT7K1.Checked = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (updateLine)
            {
                var index = line > 0 ? line - 1 : 0;
                var count = grdCommands.Rows.Count;
                if (count > 0)
                {
                    selectRow(index < count ? index : 0, true);
                }
                if (thread == null)
                {
                    updateLine = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dirty && MessageBox.Show("Are you sure you want to discard unsaved changes?", "Confirm discard changes", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

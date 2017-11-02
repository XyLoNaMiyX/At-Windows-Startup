using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace At_Windows_Startup
{
    public partial class MainF : Form
    {
        public MainF() { InitializeComponent(); }

        //RegistryKey rklm = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        RegistryKey rkcu = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

        void MainF_Load(object sender, EventArgs e) { RefreshEntries(); }
        
        #region Check buttons

        void startupLB_SelectedIndexChanged(object sender, EventArgs e) { CheckButtons(); }

        void CheckButtons()
        {
            bool enabled = startupLB.SelectedIndex > -1;
            editGB.Enabled = removeB.Enabled = enabled;
            if (enabled)
            {
                string key = (string)startupLB.SelectedItem;
                enameTB.Text = key;
                epathTB.Text = (string)rkcu.GetValue(key);
            }
            else
                enameTB.Text = epathTB.Text = "";
        }

        #endregion

        #region Refresh

        void refreshB_Click(object sender, EventArgs e) { RefreshEntries(); }

        void RefreshEntries() {
            startupLB.Items.Clear();

            foreach (var entry in rkcu.GetValueNames())
                startupLB.Items.Add(entry);

            CheckButtons();
        }

        #endregion

        #region Add

        void anameTB_KeyDown(object sender, KeyEventArgs e) { if (HandleKD(ref e)) apathTB.Focus(); }

        void apathTB_KeyDown(object sender, KeyEventArgs e) { if (HandleKD(ref e)) Add(); }

        bool HandleKD(ref KeyEventArgs e)
        {
            bool handled = e.KeyCode == Keys.Enter;
            if (handled) { e.Handled = true; e.SuppressKeyPress = true; }
            return handled;
        }

        void aaddB_Click(object sender, EventArgs e) { Add(); }

        void Add() {
            string key = anameTB.Text, val = apathTB.Text;
            if (String.IsNullOrEmpty(key))
                return;

            Add(key, val);
            anameTB.Text = apathTB.Text = "";
        }

        void Add(string key, string val) {
            rkcu.SetValue(key, val);
            RefreshEntries();
        }

        #endregion

        #region Edit

        void pacceptB_Click(object sender, EventArgs e) { Edit(); }

        void ppathTB_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Edit(); }

        void Edit()
        {
            string key = (string)startupLB.SelectedItem;
            rkcu.SetValue(key, epathTB.Text);
            RefreshEntries();
        }

        #endregion

        #region Remove

        void startupLB_KeyDown(object sender, KeyEventArgs e)
        { if (removeB.Enabled && e.KeyCode == Keys.Delete) Remove(); }

        void removeB_Click(object sender, EventArgs e) { Remove(); }

        void Remove() { rkcu.DeleteValue((string)startupLB.SelectedItem); RefreshEntries(); }

        #endregion

        #region Spam

        void lonamiwebsLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://lonamiwebs.github.io");
        }

        #endregion

        void startupLB_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }

        void startupLB_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
                Add(Path.GetFileNameWithoutExtension(file), "\"" + file + "\"");
        }

        void checkUpdatesB_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "atw").Show();
        }
    }
}

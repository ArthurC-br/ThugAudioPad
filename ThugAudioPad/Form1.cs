using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;
using KeyDownTester.Keys;
using System.Windows.Input;

namespace ThugAudioPad
{

    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private WaveOutEvent MyOutputDevice;
        private void list_device_audio()
        {
            for(int n=-1; n<WaveOut.DeviceCount; n++)
            {
                var cap = WaveOut.GetCapabilities(n);
                CB_list_devices.Items.Add(cap.ProductName);
                if (cap.ProductName.Contains("VB-Audio"))
                {
                    CB_list_devices.SelectedIndex = n+1;
                }

            }
        }
        private void list_mp3_files()
        {
            var files = Directory.GetFiles(@"C:\Users\sons");
            foreach(string file in files)
            {
                listView_mp3Files.Items.Add(file);
            }
        }

        public Form1()
        {
            InitializeComponent();
            HotkeysManager.SetupSystemHook();
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad0, () => { stop(); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad1, () => { Play_Sound(listView_mp3Files.Items[1].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad2, () => { Play_Sound(listView_mp3Files.Items[2].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad3, () => { Play_Sound(listView_mp3Files.Items[3].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad4, () => { Play_Sound(listView_mp3Files.Items[4].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad5, () => { Play_Sound(listView_mp3Files.Items[5].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad6, () => { Play_Sound(listView_mp3Files.Items[6].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad7, () => { Play_Sound(listView_mp3Files.Items[7].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.Control, Key.NumPad8, () => { Play_Sound(listView_mp3Files.Items[8].Text.ToString()); });
            HotkeysManager.AddHotkey(System.Windows.Input.ModifierKeys.None, Key.NumPad9, () => { Play_Sound(listView_mp3Files.Items[9].Text.ToString()); });
            list_device_audio();
            list_mp3_files();

        }
        private void Play_Sound(string url)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent() { DeviceNumber = CB_list_devices.SelectedIndex - 1};
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(url.ToString());
                outputDevice.Init(audioFile);
            }

            outputDevice.Volume = 0.5f;
            outputDevice.Play();
        }
    
        private void stop()
        {

            outputDevice?.Stop();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }


    }
}

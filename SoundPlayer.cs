using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace LearnToType
{
    class SoundPlayer
    {
        Mp3FileReader mp3 = null;
        WaveStream waveOut = null;
        WaveOutEvent output = null;
        string mp3FileName = "";
        public SoundPlayer(string mp3FileName)
        {
            this.mp3FileName = mp3FileName;
        }

        private void resetAudioPlayer()
        {
            mp3 = new Mp3FileReader(mp3FileName);
            waveOut = WaveFormatConversionStream.CreatePcmStream(mp3);
            output = new WaveOutEvent();
            output.Init(waveOut);
        }

        public void playSound()
        {
            resetAudioPlayer();
            output.Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectZia
{
    public interface IAudioPlayerService
    {
        void Play();
        void Play(string pathToFile);
        void Pause();
        Action OnFinishedPlaying { get; set; }
    }
}

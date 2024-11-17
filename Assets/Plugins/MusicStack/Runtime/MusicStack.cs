using System;

using UnityEngine;
using UnityEngine.Audio;

namespace Feverfew.MusicStack
{
    public class MusicStack
    {
        public Ticket GetTicket()
        {
            return new Ticket();
        }

        public class Ticket : IDisposable
        {
            public void AddMusic(AudioClip audioClip, AudioMixer audioMixer)
            {

            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}

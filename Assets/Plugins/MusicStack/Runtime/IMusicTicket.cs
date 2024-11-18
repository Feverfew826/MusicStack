using System;

using UnityEngine;

namespace Feverfew.MusicStack
{
    public interface IMusicTicket : IDisposable
    {
        void AddMusic(AudioSource audioSource);
    }
}

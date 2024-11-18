using System;
using System.Collections.Generic;

using UnityEngine;

namespace Feverfew.MusicStack
{
    internal class MusicStack : IMusicStack
    {
        private List<MusicSetting> _musicSettings = new(8);

        public IMusicTicket GetTicket()
        {
            if (_musicSettings.Count > 0)
                _musicSettings[_musicSettings.Count - 1].SetActive(false);

            var musicSetting = new MusicSetting();
            musicSetting.SetActive(true);
            _musicSettings.Add(musicSetting);

            return new MusicTicket(this, musicSetting);
        }

        private void RemoveSetting(MusicSetting musicSetting)
        {
            musicSetting.SetActive(false);
            _musicSettings.Remove(musicSetting);

            if (_musicSettings.Count > 0)
                _musicSettings[_musicSettings.Count - 1].SetActive(true);
        }

        private class MusicSetting
        {
            private bool _isActive = false;
            private List<AudioSource> _audioSources = new List<AudioSource>(4);

            public void SetActive(bool active)
            {
                if (_isActive != active)
                {
                    _isActive = active;

                    if (_isActive == true)
                    {
                        foreach (var audioSource in _audioSources)
                            audioSource.Play();
                    }
                    else
                    {
                        foreach (var audioSource in _audioSources)
                            audioSource.Stop();
                    }
                }
            }

            public void AddMusic(AudioSource audioSource)
            {
                _audioSources.Add(audioSource);

                if (_isActive)
                {
                    audioSource.Play();
                }
                else
                {
                    audioSource.Stop();
                }
            }
        }

        private class MusicTicket : IMusicTicket
        {
            private MusicStack _stack;
            private MusicSetting _setting;

            public MusicTicket(MusicStack stack, MusicSetting setting)
            {
                _stack = stack;
                _setting = setting;
            }

            void IMusicTicket.AddMusic(AudioSource audioSource)
            {
                if (audioSource == null)
                    return;

                _setting?.AddMusic(audioSource);
            }

            void IDisposable.Dispose()
            {
                _stack?.RemoveSetting(_setting);

                _stack = null;
                _setting = null;
            }
        }
    }
}

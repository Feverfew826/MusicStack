using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;

namespace Feverfew.MusicStack
{
    public class MusicStack
    {
        private List<MusicSetting> _musicSettings = new(8);

        public ITicket GetTicket()
        {
            if (_musicSettings.Count > 0)
                _musicSettings[_musicSettings.Count - 1].SetActive(false);

            var musicSetting = new MusicSetting();
            musicSetting.SetActive(true);
            _musicSettings.Add(musicSetting);

            return new Ticket(this, musicSetting);
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

            public void SetActive(bool active)
            {
                if (_isActive != active)
                {
                    _isActive = active;

                    if (_isActive == true)
                    {
                        // Play Music
                    }
                    else
                    {
                        // Stop Music
                    }
                }
            }

            public void AddMusic(AudioClip audioClip, AudioMixer audioMixer)
            {
                if (_isActive)
                {

                }
                else
                {

                }
            }
        }

        private class Ticket : ITicket
        {
            private MusicStack _stack;
            private MusicSetting _setting;

            public Ticket(MusicStack stack, MusicSetting setting)
            {
                _stack = stack;
                _setting = setting;
            }

            void ITicket.AddMusic(AudioClip audioClip, AudioMixer audioMixer)
            {
                _setting?.AddMusic(audioClip, audioMixer);
            }

            void IDisposable.Dispose()
            {
                _stack?.RemoveSetting(_setting);

                _stack = null;
                _setting = null;
            }
        }

        // 외부에 공개하는 인터페이스
        public interface ITicket : IDisposable
        {
            void AddMusic(AudioClip audioClip, AudioMixer audioMixer);
        }
    }
}

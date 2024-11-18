using UnityEngine;

namespace Feverfew.MusicStack
{
    public class MusicStackComponent : MonoBehaviour
    {
        [SerializeField] private AudioSource[] _audioSources;

        private IMusicTicket _musicTicket;

        private void OnEnable()
        {
            _musicTicket = IMusicStack.Default.GetTicket();
            foreach (var audioSource in _audioSources)
                _musicTicket.AddMusic(audioSource);
        }

        private void OnDisable()
        {
            if (_musicTicket != null)
            {
                _musicTicket.Dispose();
                _musicTicket = null;
            }
        }
    }
}

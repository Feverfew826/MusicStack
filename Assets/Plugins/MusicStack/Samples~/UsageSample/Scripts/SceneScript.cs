using System.Collections;

using UnityEngine;

namespace Feverfew.MusicStack.Samples.UsageSample
{
    public class SceneScript : MonoBehaviour
    {
        private MusicStack _musicStack = null;

        private void Awake()
        {
            var musicStack = new MusicStack();
        }

        // Start is called before the first frame update
        private void Start()
        {
            StartCoroutine(CoPlayMusic());
        }

        public IEnumerator CoPlayMusic()
        {
            using var ticket = _musicStack.GetTicket();
            ticket.AddMusic(null, null);
            yield return new WaitForSeconds(10f);
        }
    }
}

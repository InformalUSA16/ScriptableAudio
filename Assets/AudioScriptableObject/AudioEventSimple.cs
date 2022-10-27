using UnityEngine;

namespace DefaultNamespace.AudioScriptableObject
{
    [CreateAssetMenu(fileName = "AudioEventSimple", menuName = "Audio Events/Simple", order = 0)]
    public class AudioEventSimple : AudioEventBase
    {
        public RangedFloat volume;
        public RangedFloat pitch;
        public override void Play(AudioSource _source)
        {
            
        }
    }
}
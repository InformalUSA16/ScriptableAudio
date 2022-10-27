using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AudioEventBase : ScriptableObject
{
    public AudioClip[] clips;
    public abstract void Play(AudioSource _source);
}

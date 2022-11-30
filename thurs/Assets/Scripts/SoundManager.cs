using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S
{

    /// <summary>
    /// 音效管理
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {

        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            //此類別
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        ///<sumary>
        ///播放音效
        ///</sumary>
        ///<param name="sound">音效</param>
        ///<param name="rangeVolume">音量範圍</param>
        public void Playsound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager hInstance;

    AudioSource m_sfx;

    public enum SoundEnum
    {
        swordAttack = 0,
        swordSpell1,
        swordSpell2,
        swordSpell3,

        wizardAttack,
        wizardSpell1,
        wizardSpell2,
        wizardSpell3,

        shieldAttack,
        shieldSpell1,
        shieldSpell2,
        shieldSpell3,
    }

    [System.Serializable]
    public struct SoundClip
    {
        public string SoundName;
        public AudioClip SoundFile;
    }

    public SoundClip[] arraySound;

    private void Start()
    {
        hInstance = this;

        m_sfx = this.GetComponent<AudioSource>();
    }

    public static void PlaySfx(int soundIndex)
    {
        hInstance.m_sfx.PlayOneShot(hInstance.arraySound[soundIndex].SoundFile);
    }
}

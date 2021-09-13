using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controlScript : MonoBehaviour
{
    AudioSource audi;
    public AudioClip[] clip;
    // Start is called before the first frame update
    void Start()
    {
        audi.GetComponent<AudioSource>();
        StartCoroutine(introJingle());
    }
        private void playSound(int sound)
        {
            audi.clip = clip[sound];
            audi.Play();
        }
        private IEnumerator introJingle()
        {
            yield return new WaitForSeconds(3f);
            playSound(0);
            StartCoroutine(quack());
        }
        private IEnumerator quack()
        {
            yield return new WaitForSeconds(1.8f);
            playSound(1);
            StartCoroutine(dog());
        }
        private IEnumerator dog()
        {
            yield return new WaitForSeconds(0.5f);
            playSound(2);
            StartCoroutine(gunShot());
        }
        private IEnumerator gunShot()
        {
            yield return new WaitForSeconds(0.4f);
            playSound(3);
        }
        public void chanceScene()
        {
            SceneManager.LoadScene("main");
        }
}

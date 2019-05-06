using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    AudioClip destroySound;
    [SerializeField]
    int pointsEarned;
    [SerializeField]
    GameObject explosionParticlesVFX;

    private void Start()
    {
        FindObjectOfType<Level>().Blocks++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position, 0.5f);
        Explode();
        FindObjectOfType<GameData>().AddPoints(pointsEarned);
        Destroy(gameObject);
        FindObjectOfType<Level>().Blocks--;
    }

    private void Explode()
    {
        GameObject explosion = Instantiate(explosionParticlesVFX, transform.position, transform.rotation);
        Destroy(explosion, 2f);
    }
}

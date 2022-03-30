using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    AudioSource shootAudioSource;
    [SerializeField] AudioClip shoot;
    
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        shootAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();
            Source();
            
        }
            


    }
     void Source()
    {
                if (!shootAudioSource.isPlaying)
        {
                    shootAudioSource.PlayOneShot(shoot);
            }
        
        else
        {
            shootAudioSource.Stop();
        }

    }




    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }




}

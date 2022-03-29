using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject prefab;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
            audioSource.Play();
            stamina.instance.UseStamina(-100);
            Destroy(gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
            
    }
}

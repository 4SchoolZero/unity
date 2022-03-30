using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject prefab;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
            sound.Play();
            stamina.instance.UseStamina(-100);
            Destroy(gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
            
    }
}

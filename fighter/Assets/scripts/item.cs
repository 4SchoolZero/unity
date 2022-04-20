using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public Animator player;
    public AudioSource regen; 
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
         regen = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider other){
            player.Play("pickupAnimation");
            stamina.instance.UseStamina(-100);
            regen.Play();
            Destroy(gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
    }
}

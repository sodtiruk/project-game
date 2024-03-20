using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correctable : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject player;
    public AudioSource sfx;
    public float ScaleUp = 0.1f;
    public string nameSound;
    void Start()
    { 
        player = GameObject.FindWithTag("Player");
        
        // find gameObject sound
        // and then keep Gameobject into sfx
        GameObject soundObject = GameObject.Find(nameSound);
        sfx = soundObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player") // check tag
        {
            sfx.Play();
            player.transform.localScale = new Vector3(player.transform.localScale.x + ScaleUp, player.transform.localScale.y + ScaleUp, player.transform.localScale.z + ScaleUp);
            Destroy(gameObject);
        } 
    }

}

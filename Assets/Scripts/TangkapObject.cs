using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapObject : MonoBehaviour
{
	public GameObject bola;
	public GameObject tangan;
	public GameObject player;

	bool tertangkap = false;
	Vector3 posisiBola;
    // Start is called before the first frame update
    void Start()
    {
     	posisiBola = bola.transform.position;   
     	player.transform.position = new Vector3(0f,1f, 0f);
     	player.transform.eulerAngles = new Vector3(
     		player.transform.eulerAngles.x,
		    player.transform.eulerAngles.y + 44,
		    player.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
        	if(!tertangkap){
        		bola.GetComponent<Renderer>().material.color = Color.blue;        		
        		bola.transform.SetParent(tangan.transform);
        		bola.transform.localPosition = new Vector3(0.17f,-0.672f, 0f);
        		tertangkap=true;
        	} else if(tertangkap){
        		bola.GetComponent<Renderer>().material.color = Color.red;        		
        		bola.transform.SetParent(null);
        		bola.transform.localPosition =  posisiBola;
        		tertangkap=false;
        	}
        	
        }
    }
}

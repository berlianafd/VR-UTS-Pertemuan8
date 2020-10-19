using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanUtama : MonoBehaviour
{
 	public void pindahHalaman(string halaman){
 		SceneManager.LoadScene(halaman);
 	}   

 	public void keluarAplikasi(){
 		Application.Quit();
 	}
}

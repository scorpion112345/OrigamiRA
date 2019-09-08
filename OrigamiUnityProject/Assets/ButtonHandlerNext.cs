using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerNext : MonoBehaviour {

    public static int nElemento = 0;
    private Sprite[] frames;
    public GameObject ImagenGrulla;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cambiarImagenAdelante()
    {
        nElemento++;

       if(nElemento == 5)
        {
            this.gameObject.SetActive(false);
            nElemento = 0;
        }
        var sprites = Resources.LoadAll<Sprite>("grulla/01");
        switch (nElemento)
        {
            case 1:
                 sprites = Resources.LoadAll<Sprite>("grulla/02");  
                break;
            case 2:
                 sprites = Resources.LoadAll<Sprite>("grulla/03");  
                break;
            case 3:
                sprites = Resources.LoadAll<Sprite>("grulla/04");
                break;
            case 4:
                sprites = Resources.LoadAll<Sprite>("grulla/05");
                break;
            case 5:
                sprites = Resources.LoadAll<Sprite>("grulla/06");
                break;
            case 6:
                sprites = Resources.LoadAll<Sprite>("grulla/07");
                break;
            case 7:
                sprites = Resources.LoadAll<Sprite>("grulla/08");
                break;
            case 8:
                sprites = Resources.LoadAll<Sprite>("grulla/09");
                break;
            case 9:
                sprites = Resources.LoadAll<Sprite>("grulla/10");
                break;
            case 10:
                sprites = Resources.LoadAll<Sprite>("grulla/11");
                break;
            case 11:
                sprites = Resources.LoadAll<Sprite>("grulla/12");
                break;
            case 12:
                sprites = Resources.LoadAll<Sprite>("grulla/13");
                break;
            case 13:
                sprites = Resources.LoadAll<Sprite>("grulla/14");
                break;
            case 14:
                sprites = Resources.LoadAll<Sprite>("grulla/15");
                break;
            case 15:
                sprites = Resources.LoadAll<Sprite>("grulla/16");
                break;
            case 16:
                sprites = Resources.LoadAll<Sprite>("grulla/17");
                break;
            case 17:
                sprites = Resources.LoadAll<Sprite>("grulla/18");
                break;
            case 18:
                sprites = Resources.LoadAll<Sprite>("grulla/19");
                break;
            case 19:
                sprites = Resources.LoadAll<Sprite>("grulla/20");
                break;
            case 20:
                sprites = Resources.LoadAll<Sprite>("grulla/21");
                break;
            case 21:
                sprites = Resources.LoadAll<Sprite>("grulla/22");
                break;
            case 22:
                sprites = Resources.LoadAll<Sprite>("grulla/23");
                break;
            case 23:
                sprites = Resources.LoadAll<Sprite>("grulla/24");
                break;
            case 24:
                sprites = Resources.LoadAll<Sprite>("grulla/25");
                break;
            case 25:
                sprites = Resources.LoadAll<Sprite>("grulla/26");
                break;
            case 26:
                sprites = Resources.LoadAll<Sprite>("grulla/27");
                break;
            case 27:
                sprites = Resources.LoadAll<Sprite>("grulla/28");
                break;
            case 28:
                sprites = Resources.LoadAll<Sprite>("grulla/29");
                break;
            case 29:
                sprites = Resources.LoadAll<Sprite>("grulla/30");
                break;
            case 30:
                sprites = Resources.LoadAll<Sprite>("grulla/31");
                break;
            case 31:
                sprites = Resources.LoadAll<Sprite>("grulla/32");
                break;
            case 32:
                sprites = Resources.LoadAll<Sprite>("grulla/33");
                break;

        }
        for (int i = 0; i < sprites.Length; i++)
        {
            ImagenGrulla.GetComponent<Animacion>().frames[i] = sprites[i];
        }
    }
}

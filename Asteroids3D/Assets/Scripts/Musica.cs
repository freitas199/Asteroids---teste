using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musica : MonoBehaviour


 // créditos da música;
 // Steven F. Allen - Audiochose
 // https://freesound.org/people/audiomirage/;
 //https://soundcloud.com/user-574803010
//https://www.soundclick.com/artist/default.cfm?bandID=768297;
{

    [SerializeField] private Image ButtonsStyle;
  [SerializeField] private AudioSource Fundo;
  [SerializeField] private Sprite somLigadoSprite;
  [SerializeField] private Sprite somDesligadoSprite;
  private bool Som = true;
    
    public void LigarDesligarMusica()
    {
        Som=!Som;
        Fundo.enabled=Som;

        if (Som)
        {
            ButtonsStyle.sprite = somLigadoSprite;
        }
        else
        {
            ButtonsStyle.sprite = somDesligadoSprite;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
{
    public Text lifeText;
    public Text artefactText;
    public Text keyText;
    public GameObject[] artefacts;

    int life = 10;
    int key = 0;
    int artefact = 0;
    public int Life 
    {
        get { return life; }
    }

    private void Start()
    {
        lifeText.text = life.ToString();
        artefactText.text = artefact + "/" + artefacts.Length;
        keyText.text = key + "/" + 1;
    }

    public void UpArtefact()
    {
        artefact++;
        ShowArtefact();
    }
    private void ShowArtefact()
    {
        artefactText.text = artefact + "/" + artefacts.Length;
    }
    public void UpKey()
    {
        key++;
        ShowKey();
    }
    private void ShowKey()
    {
        keyText.text = key + "/" + 1;
    }
    public void TakeLife()
    {
        life--;
        ShowLife();
    }
    private void ShowLife()
    {
        lifeText.text = life.ToString();
    }
}

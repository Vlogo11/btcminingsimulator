using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadController : MonoBehaviour
{
    public GameObject LoadingButton = null;

    public void Start()
    {
        LoadingButton.SetActive(false);

        //ShowCharacters();
        StartCoroutine(WaitBeforeShow());
    }

    private void ShowCharacters()
    {
        LoadingButton.SetActive(true);
    }

    private IEnumerator WaitBeforeShow()
    {
        LoadingButton.SetActive(false);

        yield return new WaitForSeconds(3);

        LoadingButton.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject GetBonus = null;

    public void Start()
    {
        GetBonus.SetActive(false);

        //ShowCharacters();
        StartCoroutine(WaitBeforeShow());
    }

    private void ShowCharacters()
    {
        GetBonus.SetActive(true);
    }

    private IEnumerator WaitBeforeShow()
    {
        GetBonus.SetActive(false);

        yield return new WaitForSeconds(30);

        GetBonus.SetActive(true);
    }
}

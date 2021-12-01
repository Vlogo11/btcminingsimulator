using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomGeneration : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;

    public void RandomGenerate()
    {
        TheNumber = Random.Range(100000, 999999);
        TextBox.GetComponent<Text>().text = "" + TheNumber;
    }
}

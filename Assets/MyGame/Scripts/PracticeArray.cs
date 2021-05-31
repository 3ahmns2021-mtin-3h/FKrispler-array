using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArray : MonoBehaviour
{
    public int[] array1 = new int[4];
    public int[] array2 = new int[4] { 21, 22, 23, 24 };
    public int[] array3 = { 31, 32, 33, 34, 35, 36, 37 };
    public string[] array4 = new string[10];
    public GameObject[] myRedImages;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
         }

        myRedImages = GameObject.FindGameObjectsWithTag("RedImage");

        foreach(GameObject elem in myRedImages)
        {
            Debug.Log(elem.name);
        }


        Debug.Log("Element 0 von array 1 hat den Wert: " + array1[0]);
        Debug.Log("Element 0 von array 2 hat den Wert: " + array2[0]);
        Debug.Log("Element 0 von array 3 hat den Wert: " + array3[0]);
        Debug.Log("Element 0 von array 4 hat den Wert: " + array4[0]);
        Debug.Log("Name des ersten GameObjects: " + myRedImages);

        Debug.Log("Das Letzte Element von array 1 hat den Wert: " + array1[array1.Length - 1]);
        Debug.Log("Das Letzte Element von 2 hat den Wert: " + array2[array2.Length - 1]);
        Debug.Log("Das Letzte Element von 3 hat den Wert: " + array3[array3.Length - 1]);
        Debug.Log("Das Letzte Element von 4 hat den Wert: " + array4[array4.Length - 1]);
        Debug.Log("Name des ersten GameObjects: " + myRedImages[myRedImages.Length - 1].name);

        PrintElements(array4);  
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintElements(string[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            Debug.Log("Element Nummer: " + i + "hate den Wert: " + x[i]);
        }
        
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class toInventory : MonoBehaviour
{
    public GameObject invPanel;

    public void toInv()
    {
        //cycle through children to see if there is text
        foreach (Transform child in invPanel.transform)
        {
            // getting the text from the text panel
            string rockText = child.Find("Text").GetComponent<Text>().text;
            // converting it into an int
            int rockNum = System.Int32.Parse(rockText) + 1;
            // replacing the text with new num
            child.Find("Text").GetComponent<Text>().text = "" + rockNum;
            return;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ListManager : MonoBehaviour
{
    public Canvas questUI;
    public Text todo;
    public Text quest1;
    public Text quest1CO;
    public Text quest2;
    public Text quest2CO;
    public Text quest3;
    public Text quest3CO;

    // Start is called before the first frame update
    void Start()
    {
        questUI.enabled = false;
        quest1CO.enabled = false;
        quest2CO.enabled = false;
        quest3CO.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        SortingGame SG = GetComponent<SortingGame>();
        if (Input.GetKeyDown(KeyCode.B) && questUI.enabled == false)
        {
            questUI.enabled = true;
        } else if (Input.GetKeyDown(KeyCode.B) && questUI.enabled == true)
        {
            questUI.enabled = false;
        }
        if(SG.appleCount == 1)
        {
            quest1CO.enabled=true;
        }
    }
}

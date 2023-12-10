using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public int numberOfLap = 0;
    public GameObject objectName;
    public GameObject panelWin;
    public TMPro.TextMeshProUGUI textWin;

    // Start is called before the first frame update
    void Awake()
    {
        panelWin.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            numberOfLap += 1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (numberOfLap >= 3)
        {
            panelWin.SetActive(true);
            textWin.SetText(objectName.name + " is The Winner!!!");
            Time.timeScale = 0;
        }
    }
}

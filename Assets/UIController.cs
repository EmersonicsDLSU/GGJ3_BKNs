using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject[] gamePanels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            foreach (var panel in gamePanels)
            {
                if (panel.activeSelf)
                    panel.SetActive(false);
            }
        }
    }

    public void CloseApplication()
    {
        Application.Quit();
    }

}

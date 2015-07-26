using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIContainer : MonoBehaviour {

    public GameObject loginPanel;
    public GameObject mailPanel;
    public GameObject fightPanel;
    public GameObject duplicatePanel;
    public GameObject worldPanel;
    public GameObject taskPanel;


    public List<GameObject> panels = new List<GameObject>();

    public List<GameObject> AllPanel
    {
        get
        {
            panels.Clear();
            AddPanel(loginPanel);
            AddPanel(mailPanel);
            AddPanel(fightPanel);
            AddPanel(duplicatePanel);
            AddPanel(worldPanel);
            AddPanel(taskPanel);

            return panels;
        }

    } 



    private void AddPanel(GameObject go)
    {
        if (go!=null)
        {
            this.panels.Add(go);
        }
    }

    public void ClearAll()
    {
        List<GameObject> all = AllPanel;
        foreach(GameObject obj in all)
        {
            if (obj!=null)
            {
                DestroyImmediate(obj, true);
            }
        }

        panels.Clear();
    }


    void Start()
    {
        DontDestroyOnLoad(base.gameObject);
    }
}

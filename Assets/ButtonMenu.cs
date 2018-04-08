using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour {

    string[] resolutions = { "irem", "ipek", "bora" };
    [SerializeField] Transform menuPanel;
    [SerializeField] GameObject buttonPrefab;

	// Use this for initialization
	void Start () {
        resolutions[0] = "irem";
        resolutions[1] = "ipek";
        resolutions[2] = "bora";
        for (int i=0; i<resolutions.Length; i++)
        {
            GameObject button = (GameObject) Instantiate (buttonPrefab);
            button.GetComponentInChildren<Text>().text = (resolutions[i]);
            int index = i;
            button.GetComponent<Button>().onClick.AddListener(
               () => { SetResolution(index); }
               );
            button.transform.parent = menuPanel;
        }
	}

    void SetResolution(int index){
        resolutions[index] = "irem";
    }

   /* string ResToString(Resolution res)
    {
        return res.width + " X " + res.height;
    }*/
	
	// Update is called once per frame
	void Update () {
		
	}
}

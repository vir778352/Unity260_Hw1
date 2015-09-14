using UnityEngine;
using System.Collections;

public class SetDominoe : MonoBehaviour {
    public GameObject domionePrefab;
    public GameObject domioneEnd;
    public int NumDomione = 10;

	// Use this for initialization
	void Start () {
        Vector3 dir = domioneEnd.transform.position - transform.position;
        float interval = dir.magnitude / (NumDomione + 1);
        dir.Normalize();
        for (int i = 0; i < NumDomione; i++) {
            GameObject newDom = (GameObject)Instantiate(domionePrefab);
            newDom.transform.position = transform.position + dir * interval * (i+1);
            newDom.transform.rotation = transform.rotation;
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}

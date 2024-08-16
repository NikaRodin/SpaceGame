using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeToBreak = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var piece in breakablePieces) 
        { 
            piece.SetActive(false);
        }
     
    }

    public void Break()
    {
        timer += Time.deltaTime;

        if(timer > timeToBreak)
        {
            foreach (var piece in breakablePieces)
            {
                piece.SetActive(true);
                piece.transform.parent = null;
            }

            gameObject.SetActive(false);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

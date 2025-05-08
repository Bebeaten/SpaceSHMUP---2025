using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private BoundsCheck bndcheck;
	
	void Awake(){
		bndcheck = GetComponent<BoundsCheck>();
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bndcheck.offUp){
			Destroy(gameObject);
		}
    }
}

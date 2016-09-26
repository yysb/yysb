using UnityEngine;
using System.Collections;

public class jeepRun : MonoBehaviour {
	public GameObject obj;
	public GameObject cc;
	public GameObject cc1;
	public GameObject cc2;
	public GameObject cc3;
	public GameObject body;
	public GameObject tower;
	public Transform a;
	public Transform b;
	public int  x=0;
	// Use this for initialization
	void Start () {

	//zhushi
	}
	
	// Update is called once per frame
	void Update () {
			body.transform.Translate (-1*Time .deltaTime ,0,0,Space .World );
			tower.transform.Rotate (0,2,0,Space .World );
			cc.GetComponent <Transform > ().Rotate (1,0,0 );
			cc1.GetComponent <Transform > ().Rotate (1,0,0 );
			cc2.GetComponent <Transform > ().Rotate (1 ,0,0);
			cc3.GetComponent <Transform > ().Rotate (1,0,0);
			this.GetComponent <Transform > ().Translate (0,0,4*Time .deltaTime);
		if (this.transform.position.x <= (a.position.x+30) && this.transform.position.x >= a.position.x) {
			if (x != 360) {
				this.transform.RotateAround  (b.transform.position, Vector3 .up , -1);
				x++;
			}

		}
	}
	void LateUpdate(){
		obj.GetComponent <Transform > ().Translate (-4*Time .deltaTime ,0,0,Space .World );
	}
}

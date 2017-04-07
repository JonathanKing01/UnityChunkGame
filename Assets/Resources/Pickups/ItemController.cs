using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

	public int stackCount = 1;

	void OnCollisionEnter2D(Collision2D other){
		GameObject obj = other.gameObject;
		if (obj.tag == "Player") {
			obj.GetComponent<Inventory> ().AddItem (this.gameObject);
			//Destroy (this.gameObject);
		}
	}
}

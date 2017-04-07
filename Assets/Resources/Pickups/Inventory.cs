using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public GameObject[] Items = new GameObject[50];
	public int invSize = 50;
	public GameObject test;

	public void AddItem(GameObject item){
		for (int i = 0; i < invSize; i++) {
			if (Items[i] != null && Items [i].name == item.name) {
				Debug.Log (1);
				Items [i].GetComponent<ItemController> ().stackCount += 1;
				Destroy (item);
				break;
			} else {
				Debug.Log (2);
				if (Items [i] == null) {
					Debug.Log (3);
					Items [i] = item;
					item.SetActive (false);
					break;
				}
			}
		}
	}


}

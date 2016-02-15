using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
	private Resources _playerResources = new Resources();
	public Resources PlayerResources {
		get { 
			return _playerResources;
		}
	}

	void Start() {
        _playerResources.Fur += 4;
	}
}

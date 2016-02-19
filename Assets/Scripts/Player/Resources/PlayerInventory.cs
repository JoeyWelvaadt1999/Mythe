using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
	[SerializeField]private Resource _resourceObject; //Set this game object to the gameobject(resource) that is picked up
	private ResourceTypes.ResourceType _resourceType = new ResourceTypes.ResourceType();
	private Resources _playerResources = new Resources();

	public Resource ResourceObject {
		get { 
			return _resourceObject;
		} set { 
			_resourceObject = value;
		}
	}

	public Resources PlayerResources {
		get { 
			return _playerResources;
		}
	}

	void Start() {
		_resourceType = _resourceObject.ResourceType;
//        _playerResources.Fur += 4;
		Debug.Log(_resourceType);
	}

	void SetState(){
		switch (_resourceType) {
		case ResourceTypes.ResourceType._fur:
			_playerResources.Fur += _resourceObject.Value;
			break;
		case ResourceTypes.ResourceType._meat:
			_playerResources.Meat += _resourceObject.Value;
			break;
		case ResourceTypes.ResourceType._stone:
			_playerResources.Stones += _resourceObject.Value;
			break;
		case ResourceTypes.ResourceType._wood:
			_playerResources.Wood += _resourceObject.Value;
			break;
		}
	}
}

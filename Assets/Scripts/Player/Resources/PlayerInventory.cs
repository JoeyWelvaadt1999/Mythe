using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
	private Resource _resourceObject;
	private ResourceTypes.ResourceType _resourceType = new ResourceTypes.ResourceType();
	private Resources _playerResources = new Resources();

	public Resource ResourceObject {
		get { 
			return _resourceObject;
		} set { 
			_resourceObject = value;
			_resourceType = _resourceObject.ResourceType;
		}
	}

	public Resources PlayerResources {
		get { 
			return _playerResources;
		}
	}

	void Start() {
        _playerResources.Fur = 4;

	}

	public void SetState(){
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

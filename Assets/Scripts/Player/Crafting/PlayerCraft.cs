using UnityEngine;
using System.Collections;

public class PlayerCraft : MonoBehaviour
{
    private Craftables _craftables = new Craftables();
	private PlayerInventory _playerInventory;//Variable to PlayerInventory component 
	private Resources _resources;//Empty variable, will be used to store Recourses from te PlayerInventory component

	// Use this for initialization
	void Start ()
    {
		_playerInventory = GetComponent<PlayerInventory> ();//Use GetComponent to get the PlayerInventory component from the player object
		_resources = _playerInventory.PlayerResources;//Put the recources from the PlayerInventory component in the recourses variable in this component
		//Be aware that this needs to be updated incase the player pick's up a new recourse

        print("Resources required to make a fur coat : " + _craftables.FurCoat.fur);
        print("fur resources " + _resources.Fur);

	}

    void CraftItem()
    {
       if (_resources.Fur >= _craftables.FurCoat.fur)
        {
            print("making fur coat");
        } 
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            CraftItem();
        }
	}
}

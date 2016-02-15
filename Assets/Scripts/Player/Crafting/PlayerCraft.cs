using UnityEngine;
using System.Collections;

public class PlayerCraft : MonoBehaviour
{
    Craftables _craftables = new Craftables();

	// Use this for initialization
	void Start ()
    {
        print("Resources required to make a torch : " + "Wood: "+ _craftables.Torch.wood + " Stones: " + _craftables.Torch.stones);
        print("Resources required to make a fur coat : " + _craftables.FurCoat.fur);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}

using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "welcome to our planet!!!", "1");
        Speech.AddDialogue("1", "angry robots attacking us ):", "2");
        Speech.AddDialogue("2", "soo you need to help us", "3");
        Speech.AddDialogue("3", "take ur lazy body and go kill enemys (:");
    }

   

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
        Speech.SetDialogue("0");
    }
}
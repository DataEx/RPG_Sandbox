using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CameraFollow : MonoBehaviour {

    
    public ThirdPersonCharacter player;

	void LateUpdate () {
        this.transform.position = player.transform.position;
    }
}

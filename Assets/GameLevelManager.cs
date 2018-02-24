using UnityEngine;
using System.Collections;

public class GameLevelManager : MonoBehaviour {

	public void ReturnToBeginning(string name){
	Application.LoadLevel(name);
	}
}

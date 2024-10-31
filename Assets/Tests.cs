using System. Collections;
using System. Collections. Generic;
using UnityEngine;


public class Tests: MonoBehaviour
{
    void Start ()
    {
		Debug. Log ("Tests :");
		
		
		// Exercice 1 :
		
        Vector2Int positionActuelle2d = new Vector2Int (5, 8);
        Vector2Int vitesse2d = new Vector2Int (3, 2);
        Vector2Int somme2d = positionActuelle2d + vitesse2d;
		Debug. Log (positionActuelle2d + " + " + vitesse2d + " = " + somme2d);
		
        Vector2Int position2d = new Vector2Int (-1, -3);
        Vector2Int deplacement2d = new Vector2Int (-2, 2);
        Vector2Int difference2d = position2d - deplacement2d;
		Debug. Log (position2d + " - " + deplacement2d + " = " + difference2d);
		
        Vector3Int positionActuelle3d = new Vector3Int (-2, -1, 5);
        Vector3Int vitesse3d = new Vector3Int (1, 4, 3);
        Vector3Int somme3d = positionActuelle3d + vitesse3d;
		Debug. Log (positionActuelle3d + " + " + vitesse3d + " = " + somme3d);
		
        Vector3Int position3d = new Vector3Int (2, -4, 1);
        Vector3Int deplacement3d = new Vector3Int (-1, -1, 3);
        Vector3Int difference3d = position3d - deplacement3d;
		Debug. Log (position3d + " - " + deplacement3d + " = " + difference3d);
    }

    void Update () {}
}

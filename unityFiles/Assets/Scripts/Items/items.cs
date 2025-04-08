


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.tilemaps;

[CreateAssetMenu(menuName = "Scriptable Objects/Items")]
public class items : ScriptableObject {

    [SerializeField] TileBase base;
    [SerializeField] ItemType type;
    [SerializeField] ActionType actionType;
    [SerializeField] Vector2Int range = new Vector2Int(5, 4);

    [SerializeField] bool stackable = true;

    public enum ItemType {

    }

    public enum ActionType {

    }

}
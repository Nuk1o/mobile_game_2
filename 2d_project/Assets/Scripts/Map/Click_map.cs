using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Click_map : MonoBehaviour
{
    [SerializeField] TileBase tileToSet;
    [SerializeField] Tilemap map;
    private void Start()
    {
        map = GetComponent<Tilemap>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int _click_pos = map.WorldToCell(mouse_pos);
            map.SetTile(_click_pos, tileToSet);
        }
    }
}

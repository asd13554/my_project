using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureManature : MonoBehaviour
{
    [SerializeField] private bool isConstructing;

    public GameObject curBuildingPrefab;
    public GameObject buildingParent;

    [SerializeField] private Vector3 cursorPos;
    [SerializeField] private GameObject buildCursor;
    [SerializeField] private GameObject gridPlane;

    void Update()
    {
        cursorPos = Selector.instance.GetCurTilePosition();

        if (isConstructing)
        {
            buildCursor.transform.position = cursorPos;
            gridPlane.SetActive(true);
        }
    }

    public void beginNewBuildingPlacment(GameObject prefab)
    {
        isConstructing = true;
        curBuildingPrefab = prefab;

        buildCursor = Instantiate(curBuildingPrefab, cursorPos, Quaternion.identity);
        buildCursor.SetActive(true);
    }
}

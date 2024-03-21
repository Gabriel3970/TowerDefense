using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public GameObject standardTurretPrefab;
    private GameObject turretToBuild;

    void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
        }
        Instance = this;
    }

    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}

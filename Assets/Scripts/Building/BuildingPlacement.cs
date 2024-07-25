using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BuildingPlacement : MonoBehaviour
{
    public bool isBuildable = true;

    [SerializeField]private int _collisionHit = 0;

    private BuildingData _buildingData;
    private int _woodCost;

    private Material[] materials;
    private Color[] originalColor;


    private void Start()
    {
        SaveOriginalColor();

        _buildingData = gameObject.GetComponent<BuildingData>();
        _woodCost = _buildingData.woodCost;
    }

    private void FixedUpdate()
    {
        if ((_collisionHit < 1) && (_woodCost <= ResourcesManager.instance.woodCound))
        {
            isBuildable = true;
        }
        else
        {
            isBuildable = false;
        }
    }

    private void Update()
    {
        if (isBuildable) 
        {
            SetOriginalColor();
        }
        else 
        {
            SetRedColor();
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;

        if (!go.CompareTag("ground"))
        {
            _collisionHit++;
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        GameObject go = other.gameObject;

        if (!go.CompareTag("ground"))
        {
            _collisionHit--;
        }
    }

    private void SetRedColor() 
    {
        //Pour chaque material
        for (int i = 0; i < materials.Length; i++) 
        {
            GetComponent<MeshRenderer>().materials[i].color = Color.red;
        }
    }

    private void SetOriginalColor()
    {
        //Pour chaque material
        for (int i = 0; i < materials.Length; i++)
        {
            GetComponent<MeshRenderer>().materials[i].color = originalColor[i];
        }
    }

    private void SaveOriginalColor() 
    {
        //Récupération des materials
        materials = GetComponent<MeshRenderer>().materials;
        originalColor = new Color[materials.Length];

        //Récupération couleur correspondante
        for (int i = 0; i < materials.Length; i++) 
        {
            originalColor[i] = materials[i].GetColor("_Color");
        }
    }


}

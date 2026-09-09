using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{
    public Color selectedColor = Color.green;

    Color normalColor;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        normalColor = rend.material.color;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(
                Mouse.current.position.ReadValue()
            );

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    SelectCube();
                }
            }
        }
    }

    void SelectCube()
    { 
        cube[] cubes = FindObjectsOfType<cube>();

        foreach (cube cube in cubes)
        {
            cube.rend.material.color = cube.normalColor;
        }
         
        rend.material.color = selectedColor;
         
        if (spawn.sphere != null)
        {
            sphere move = spawn.sphere.GetComponent<sphere>();

            move.target = transform;
        }
    }
}
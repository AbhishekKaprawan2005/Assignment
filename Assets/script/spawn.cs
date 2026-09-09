using UnityEngine;
using UnityEngine.InputSystem;

public class spawn : MonoBehaviour
{
    public GameObject spherePrefab;

    public static GameObject sphere;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (sphere != null)
            {
                Destroy(sphere);
            }

            sphere = Instantiate(spherePrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
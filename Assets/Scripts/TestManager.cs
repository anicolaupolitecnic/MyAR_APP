using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject sounds;
    private void Start()
    {
        //Invoke("SetCarEnabled", 3f);
    }

    public void SetCarEnabled()
    {
        car.SetActive(true);
        car.transform.position = new Vector3(car.transform.position.x, 0.5f, car.transform.position.z);
        sounds.SetActive(true);
    }
}

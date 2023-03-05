using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuzzleType
{
    Choice,
    Tap,
    Password
}
public class GameManager : MonoBehaviour
{
    public List<GameObject> Platforms;

    public static GameManager Instance;

    public GameObject PointForInstantiate;

    public PlatformProperties properties;

    public float speed = 5f;

    public bool IsSlowMo=false;

    public int currentPlatform = 0;
    private void Awake()
    {
/*        if (Instance == null)
        {
            Instance = this;
        }*/
        if (Instance!=null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    public void SetSlowMo (bool TargetSlowMo)
    {
        IsSlowMo = TargetSlowMo;
        speed = IsSlowMo ? properties.SlowMoSpeed : properties.NormalSpeed;
    }
}

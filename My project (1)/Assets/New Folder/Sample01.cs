using UnityEngine;

public enum Rainbow
{
    빨, 주, 노, 초, 파, 남, 보
}

[AddComponentMenu("LJH/Sample01")]

public class Sample01 : MonoBehaviour
{
    public bool jumpable;
    public string[] basket;
    public int money;
    [Range(1, 99)] public float fieldOfView;
    public Rainbow rainbow;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

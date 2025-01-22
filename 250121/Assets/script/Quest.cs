using UnityEngine;

[AddComponentMenu("LJH / Sample01")]
public class Quest : MonoBehaviour
{
    [Tooltip("점프가능여부")]
    public bool Jump = true;

    [Range(1, 99)]
    public int view;
}




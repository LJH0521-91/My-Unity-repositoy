using UnityEngine;

[AddComponentMenu("LJH / Sample01")]
public class Quest : MonoBehaviour
{
    [Tooltip("�������ɿ���")]
    public bool Jump = true;

    [Range(1, 99)]
    public int view;
}




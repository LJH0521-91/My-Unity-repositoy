using System;
using UnityEngine;

[Flags]
public enum ���Ϲٱ���
{
    None = 0,
    ��� = 1 << 0,
    ���� = 2 << 1,
    ���� = 3 << 2,
    ���� = 4 << 3,
    ������ = 5 << 4
}

public enum ������
{
    ��,��,��,��,��,��,��
}
public class Quest1 : MonoBehaviour
{
    public ���Ϲٱ��� ����;
    public ������ ����;
        
}
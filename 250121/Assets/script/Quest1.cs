using System;
using UnityEngine;

[Flags]
public enum 과일바구니
{
    None = 0,
    사과 = 1 << 0,
    딸기 = 2 << 1,
    수박 = 3 << 2,
    포도 = 4 << 3,
    오렌지 = 5 << 4
}

public enum 무지개
{
    빨,주,노,초,파,남,보
}
public class Quest1 : MonoBehaviour
{
    public 과일바구니 과일;
    public 무지개 색상;
        
}
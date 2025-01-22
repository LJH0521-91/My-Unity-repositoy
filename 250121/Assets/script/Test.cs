using UnityEngine;
// using은 다음에 적힌 것을 코드에서 사용하는 중입니다 라는 뜻입니다.
// 유니티에서 유니티를 활용해 작업하는 스크립트라면
//위의 코드를 반드시 추가해주세요 (자동으로 추가되어 있습니다.
//UnityTutorial 영역에서 만들어진 SampleA 클래스
//유니티 내부에 같은이름의 파일이 있으면 문제가 됨 (namespace UnityTutorial)

namespace TowerDefence
{ 
    //UnityTutorial 영역에서 만들어진 SampleA 클래스 , 영역을 구분해준다. ( namespace 안에있는 public class SampleA / 밖에 있는 public class Sample 는 다름.
    public class SampleA
    {

    }
}

public class SampleA
{

}
/// <summary>
/// 처음으로 만들어본 유니티의 스크립트 에붸붸붸붸붸
/// </summary>
public class Test : MonoBehaviour
    //MonoBehaviour는 클래스에 연결했을경우
    //유니티 씬에 존재하는 오브젝트에 스크립트를 연결할 수 있게 해준다.
    //유니티에서 제공해주는 기능을 사용할 때 사용합니다.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("C#스크립트를 처음 배운 25년 1월 21일");
    }

    int count = 0;
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count}좌우 반복 뛰기");
        count++; //count 가 1씩 증가한다.
    }
}

using UnityEngine;
// using�� ������ ���� ���� �ڵ忡�� ����ϴ� ���Դϴ� ��� ���Դϴ�.
// ����Ƽ���� ����Ƽ�� Ȱ���� �۾��ϴ� ��ũ��Ʈ���
//���� �ڵ带 �ݵ�� �߰����ּ��� (�ڵ����� �߰��Ǿ� �ֽ��ϴ�.
//UnityTutorial �������� ������� SampleA Ŭ����
//����Ƽ ���ο� �����̸��� ������ ������ ������ �� (namespace UnityTutorial)

namespace TowerDefence
{ 
    //UnityTutorial �������� ������� SampleA Ŭ���� , ������ �������ش�. ( namespace �ȿ��ִ� public class SampleA / �ۿ� �ִ� public class Sample �� �ٸ�.
    public class SampleA
    {

    }
}

public class SampleA
{

}
/// <summary>
/// ó������ ���� ����Ƽ�� ��ũ��Ʈ ���޺޺޺޺�
/// </summary>
public class Test : MonoBehaviour
    //MonoBehaviour�� Ŭ������ �����������
    //����Ƽ ���� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� ������ �� �ְ� ���ش�.
    //����Ƽ���� �������ִ� ����� ����� �� ����մϴ�.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("C#��ũ��Ʈ�� ó�� ��� 25�� 1�� 21��");
    }

    int count = 0;
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count}�¿� �ݺ� �ٱ�");
        count++; //count �� 1�� �����Ѵ�.
    }
}

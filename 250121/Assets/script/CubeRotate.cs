using UnityEngine;
/// <summary>
/// ť�긦 ȸ����Ű�� Ŭ����(������Ʈ)
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region �ʱ� ����
    //�ڷ���(type)
    //��ǻ�� ���α׷��� �����͸� �Ǵ��ϴ� ����
    //���� ���Ǵ� �ڷ���(tpye) ://
    //int = ����(integer) =  �Ҽ����� ���� ����
    //float : �Ǽ� = �Ҽ����� ���Ե� ����
    //bool : ��(Boolean) : �� / ���� , �´��� �ƴ���(True, False)
    //String : ���ڿ� : ������ ������ ǥ��(����) 

    //����(variable) 
    //���� ������ �� �ִ� ���� , � Ư�� �� �ϳ��� �����ϱ� ���� �̸��� ���� �������
    
    //����� ���
    //�ڷ��� ������;
    //������ �� ����(�ʱ�ȭ)
    //������ ���� �����Ű�� �۾��� �ǹ��մϴ�.
    //������ = Ÿ�Կ� �´� ���� �־����

    #endregion
    #region ����
    public float x; //����Ƽ �����Ϳ��� �����Ǵ� ����
    public float y;
    private int sample; //����Ƽ �����Ϳ��� �������� �ʴ� ����
    #endregion

    #region ��ŸƮ �Լ�
    void Start()
    {
        sample = 10; //������ ������� ��� �ڵ� ���ο��� �����Ǵ� ��찡 ����
        Debug.Log(sample);
        //""���� ������ ������ �� ���� ���� ���
    }

    #endregion
    #region ������Ʈ �Լ�
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime,y * Time.deltaTime,0));
        //FPS(Frame Per Second) : �� �� ������
        //deltaTime : �� ������ �Ϸ�Ǳ���� �ɸ��� �ð�
    }
    #endregion
}

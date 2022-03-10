using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

	public static CursorManager _instance;//����ģʽ

	public Texture2D cursor_normal;
	public Texture2D cursor_npc_talk;
	//����Ҫ�������״����ഴ������ Texture2D���͵�
	//�����ز�

	private Vector2 hotSpot = Vector2.zero;
	private CursorMode mode = CursorMode.Auto;//���ù��ʹ��������ֻ�����֧�ֵ�ƽ̨��ʹ��Ӳ������


	// Use this for initialization
	void Start()
	{
		_instance = this;
	}
	public void SetNormal()//������ͨ�������״
	{
		Cursor.SetCursor(cursor_normal, hotSpot, mode);
	}

	public void SetNpcTalk()//���ô���������������״
	{
		Cursor.SetCursor(cursor_npc_talk, hotSpot, mode);
	}

	//������Զഴ����������������ķ���
	//��ʽΪ
	//public void SetNpcTalk()�����������������
	//{
	//	Cursor.SetCursor(����Ϊ��������������״, hotSpot, mode);
	//}

	// Update is called once per frame

}

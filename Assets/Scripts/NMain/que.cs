using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class que : MonoBehaviour
{

    private Queue<int> queue = new Queue<int>();

    // Use this for initialization
    void Start()
    {
        //�@�l��ǉ�
        queue.Enqueue(0);
        queue.Enqueue(1);
        foreach (var item in queue)
        {
            Debug.Log("Queue��: " + item);
        }
        //�@�擪����l���擾���f�[�^���폜
        int dequeue = queue.Dequeue();
        Debug.Log("Dequeue�����l: " + dequeue);
        foreach (var item in queue)
        {
            Debug.Log("Dequeue��: " + item);
        }
        queue.Enqueue(10);
        foreach (var item in queue)
        {
            Debug.Log("10Enqueue��: " + item);
        }
        int peekValue = queue.Peek();
        Debug.Log("Peek�����l�F " + peekValue);
        foreach (var item in queue)
        {
            Debug.Log("Peek��: " + item);
        }
        //�@�L���[�f�[�^���N���A
        queue.Clear();
        queue.Enqueue(0);
        //�@�L���[��0�����݂��邩�H
        Debug.Log("�L���[�f�[�^��0�����݂��邩�H: " + queue.Contains(0));
        Debug.Log("�L���[�ɓo�^����Ă��鐔�F " + queue.Count);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateServer : MonoBehaviour
{
    private Button CreateServerBT;
    private AGCC ag;                          //�����D����
    // Start is called before the first frame update
    void Start()
    {
        CreateServerBT = GetComponent<Button>();          //�۰ʧ������
        CreateServerBT.onClick.AddListener(Create);        //���U�ӫ��s���U���ɭԷ|�I�sLogin()
    }

    void Create() {
        if (ag == null)
            ag = FindObjectOfType<AGCC>();  //������D������
        ag.EnterScene();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class JoinServer: MonoBehaviour {
    private Button JoinServerBT;
    public TMP_InputField InputSID;
    private AGCC ag;                          //�����D����
    // Start is called before the first frame update
    void Start() {
        JoinServerBT = GetComponent<Button>();          //�۰ʧ������
        JoinServerBT.onClick.AddListener(Create);        //���U�ӫ��s���U���ɭԷ|�I�sLogin()
    }

    void Create() {
        if (ag == null)
            ag = FindObjectOfType<AGCC>();  //������D������
        if (InputSID.text != null) {
            ag.MatchScene(Convert.ToUInt32(InputSID.text,10));
        }
    }
}
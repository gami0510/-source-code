using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBackBox : MonoBehaviour
{
    //�X�N���v�g�̌Ăяo���E�ϐ���`
    public ItemBox itembox;
    public int ItemNum;
    
    
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //ItemBox�̒��̃A�C�e�����N���b�N�����ۂɂ��̃A�C�e����߂�
    public void BoxBackItemSet()
    {
     if(itembox.itemBox[ItemNum] == -1)
     {
      return;
     }
     
     itembox.itemBox[ItemNum] = -1;
     itembox.ItemBoxDisplay();
    }
}

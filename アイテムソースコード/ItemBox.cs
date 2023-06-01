using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    //�X�N���v�g�Ăяo���@�A�C�e���̔��쐬�@�A�C�e���ۑ��ꏊ�쐬
    public ItemDisplay itemdisplay;
    
    public GameObject[] itemboxSlots;
    
    public int[] itemBox = new int[2];
    
    
    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; itemBox.Length > i; i++)
       {
        itemBox[i] = -1;
       } 
       
       ItemBoxDisplay();
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //�A�C�e��Box�\��
    public void ItemBoxDisplay()
    {
      ItemBoxFalse();
      
      for(int i = 0; i < itemboxSlots.Length; i++)
      {
       if(itemBox[i] == -1)
       {
        continue;
       }
       itemboxSlots[i].gameObject.SetActive(true);
       itemboxSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = ItemData.GetItemData(itemBox[i]).image;
       itemboxSlots[i].transform.GetChild(1).GetComponent<Text>().text = ItemData.GetItemData(itemBox[i]).name;
      }
    }
    
    public void ItemSet(int i)
    {
        for(int j=0; j<itemBox.Length; j++)
        {
            if (itemBox[j] == -1)
            {
                itemBox[j] = i;
                return;
            }
        }
        
    }
    
    
    
    public void ItemBoxFalse()
    {
     for(int i = 0; i < itemboxSlots.Length; i++)
     {
      itemboxSlots[i].gameObject.SetActive(false);
     }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
   //Save�f�[�^�Q��
 
  
  

   public GameObject[] ItemsSlots;
   public GameObject ItemsDisplaySlot;
  

   
    // Start is called before the first frame update
    void Start()
    {
       //�A�C�e���ꗗ�\��
       DisplayItems();
       //�A�C�e���g���\��
       BigDisplayItems();
       //�A�C�e�������[�h
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public  void DisplayItems()
    {
     //ItemData��Items��Ui����Item��Slots�Ɋ��蓖�ā�
     for(int i = 0; i<ItemsSlots.Length; i++)
     {
     ItemsSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = ItemData.GetItemData(i).image;
     ItemsSlots[i].transform.GetChild(1).GetComponent<Text>().text = ItemData.GetItemData(i).name;
     }
    
    }
    
    public void BigDisplayItems()
    {
     //�A�C�e���g���\�����\�b�h
     ItemsDisplaySlot.gameObject.SetActive(false);   
    }
    
    //�A�C�e���g��g��\��
    public void BigDisplayItemsSet(int i)
    {
      ItemsDisplaySlot.gameObject.SetActive(true);
      ItemsDisplaySlot.transform.GetChild(0).GetComponent<Image>().sprite = ItemData.GetItemData(i).image;
      ItemsDisplaySlot.transform.GetChild(1).GetComponent<Text>().text = ItemData.GetItemData(i).name;
    }
    
}

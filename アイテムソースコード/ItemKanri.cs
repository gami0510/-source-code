using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemKanri : MonoBehaviour
{
    //�X�N���v�g�̌Ăяo��
    public ItemDisplay itemdisplay;
    public ItemSetButton itemSetButton;
    
    public int itemID;
    
    // Start is called before the first frame update
    void Start()
    {
      itemdisplay = GameObject.Find("ItemManager").GetComponent<ItemDisplay>();
      itemSetButton = GameObject.Find("ItemSet").GetComponent<ItemSetButton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //�A�C�e���ۑ�����
    public void ItemSave()
    {
    }
    
    public void ItemClick()
    {
     itemdisplay.BigDisplayItemsSet(itemID);
     itemSetButton.ItemsId = itemID;
    }
}

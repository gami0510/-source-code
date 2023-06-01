using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemKanri : MonoBehaviour
{
    //スクリプトの呼び出し
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
    
    //アイテム保存処理
    public void ItemSave()
    {
    }
    
    public void ItemClick()
    {
     itemdisplay.BigDisplayItemsSet(itemID);
     itemSetButton.ItemsId = itemID;
    }
}

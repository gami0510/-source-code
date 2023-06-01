using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
   //Saveデータ参照
 
  
  

   public GameObject[] ItemsSlots;
   public GameObject ItemsDisplaySlot;
  

   
    // Start is called before the first frame update
    void Start()
    {
       //アイテム一覧表示
       DisplayItems();
       //アイテム拡大非表示
       BigDisplayItems();
       //アイテムをロード
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public  void DisplayItems()
    {
     //ItemDataのItemsのUi情報をItemｓSlotsに割り当て↓
     for(int i = 0; i<ItemsSlots.Length; i++)
     {
     ItemsSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = ItemData.GetItemData(i).image;
     ItemsSlots[i].transform.GetChild(1).GetComponent<Text>().text = ItemData.GetItemData(i).name;
     }
    
    }
    
    public void BigDisplayItems()
    {
     //アイテム拡大非表示メソッド
     ItemsDisplaySlot.gameObject.SetActive(false);   
    }
    
    //アイテム拡大拡大表示
    public void BigDisplayItemsSet(int i)
    {
      ItemsDisplaySlot.gameObject.SetActive(true);
      ItemsDisplaySlot.transform.GetChild(0).GetComponent<Image>().sprite = ItemData.GetItemData(i).image;
      ItemsDisplaySlot.transform.GetChild(1).GetComponent<Text>().text = ItemData.GetItemData(i).name;
    }
    
}

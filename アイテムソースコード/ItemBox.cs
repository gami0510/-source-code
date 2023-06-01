using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    //スクリプト呼び出し　アイテムの箱作成　アイテム保存場所作成
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
    
    //アイテムBox表示
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

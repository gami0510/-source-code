using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSetButton : MonoBehaviour
{
    //スクリプト呼び出し
    public ItemBox itembox;


    public int ItemsId = -1;
    
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //アイテムをセットボタン
    public void ItemSetButtonClick()
    {
      if(ItemsId == -1)
      {
       return;
      }
     
      itembox.ItemSet(ItemsId);
      itembox.ItemBoxDisplay();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBackBox : MonoBehaviour
{
    //スクリプトの呼び出し・変数定義
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
    
    //ItemBoxの中のアイテムをクリックした際にそのアイテムを戻す
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

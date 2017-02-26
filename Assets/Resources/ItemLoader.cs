using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour {

    public const string path = "items";
    public const string path1 = "ChipEventItemTableMgr";

    // Use this for initialization
    void Start ()
    {
        //ChipEventItemContainer ic = ChipEventItemContainer.Load(path1);
        //foreach (ChipEventItem item in ic.items)
        //{
        //    print(item.Index + ", " + item.SpriteIcon + ", " + item.Chips);
        //}

        //ItemContainer ic = ItemContainer.Load(path);
        //foreach(Item item in ic.items)
        //{
        //    print(item.name);
        //}

        ItemContainer.Load2(path);
   }

}

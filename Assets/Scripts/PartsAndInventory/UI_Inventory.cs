using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{

    private PlayerInventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Awake()
    {
        itemSlotContainer = transform.Find("ItemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("ItemSlotTemplate");
    }

    public void SetInventory(PlayerInventory inventory)
    {

        this.inventory = inventory;
        RefreshInventoryItems();

    }

    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotXCellSize = 150f;
        float itemSlotYCellSize = 40f;
        foreach (Part part in inventory.GetPartList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotXCellSize, y * itemSlotYCellSize);
            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = part.Getsprite();
            y--;
        }
    }

}

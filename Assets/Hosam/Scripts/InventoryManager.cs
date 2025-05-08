using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // The initial number of items in the inventory
    [SerializeField] int InitialItemsCount = 5;

    // the prefab of the item to be added to the inventory
    [SerializeField] GameObject ItemPrefab;
    int ItemsCount = 0; // The current number of items in the inventory

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize the inventory with the initial number of items
        for (int i = 0; i < InitialItemsCount; i++)
        {
            AddItem();
        }
    }

    public void AddItem()
    {
        // Create a new item and Set the parent of the item to this inventory manager
        GameObject item = Instantiate(ItemPrefab, transform);

        // Update the ItemsCount to reflect the new item added
        ItemsCount++;

        //update the size of the scroll content to fit the new item
        //UpdateScrollContentSize();
    }

    private void UpdateScrollContentSize()
    {
        gameObject.transform.parent.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, transform.GetComponent<RectTransform>().rect.height);
    }
}

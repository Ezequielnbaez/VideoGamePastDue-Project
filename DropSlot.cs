using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public bool ocupado=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(!item && ocupado==false)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            ocupado = true;
            SoundManager.PlaySound("NoteSound");
        }
    }

    void Update()
    {
        if(item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}

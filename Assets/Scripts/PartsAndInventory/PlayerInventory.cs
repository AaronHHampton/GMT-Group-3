using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory 
{

    private List<Part> partList;

    public PlayerInventory()
    {
        partList = new List<Part>();

        AddItem(new Part { partType = Part.PartTypes.Head, amount = 1 });
        AddItem(new Part { partType = Part.PartTypes.Torso, amount = 1 });
        AddItem(new Part { partType = Part.PartTypes.LeftLeg, amount = 1 });
        AddItem(new Part { partType = Part.PartTypes.RightLeg, amount = 1 });

        Debug.Log(partList.Count);
    }

    public void AddItem(Part part)
    {
        partList.Add(part);
    }

    public List<Part> GetPartList()
    {
        return partList;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions {
 
    /*
    public static GameObject FindGameObjectWithTag(this GameObject go, string nameToFind, bool bSearchInChildren)
    {
        if (bSearchInChildren)
        {
            var transform = go.transform;
            var childCount = transform.GetChildCount();
            //Debug.LogError( go.name + " ChildCount: " + childCount);
            for (int i = 0; i < childCount; ++i)
            {
                var child = transform.GetChild(i);
                if (child.gameObject.name == nameToFind)
                    return child.gameObject;
                GameObject result = child.gameObject.Find(nameToFind, bSearchInChildren);
                if (result != null) return result;
            }
            return null;
        }
        else
        {
            return GameObject.Find(nameToFind);
        }
    }

    public static int GetNum(this GameObject go, int a)
    {
        return a++;
    }
    */
}
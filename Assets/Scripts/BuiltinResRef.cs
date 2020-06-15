using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuiltinResRef")]
public class BuiltinResRef : ScriptableObject
{
    public List<UnityEngine.Object> List;

    public void Add(UnityEngine.Object res)
    {
        if (List == null)
            List = new List<UnityEngine.Object>();
        if (List.Contains(res))
            return;
        else
            List.Add(res);
    }

    public UnityEngine.Object Load(Type t, string name)
    {
        foreach (var i in List)
        {
            if (i != null && i.GetType() == t && i.name == name)
                return i;
        }
        Debug.LogErrorFormat("对内置资源的引用中不存在{0},Type:{1}", name, t);
        return null;
    }
}

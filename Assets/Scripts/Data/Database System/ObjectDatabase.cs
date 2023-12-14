using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ObjectDatabase : ScriptableObject
{
    public List<ObjectData> objectData;
}

[Serializable]
public class ObjectData
{
    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField]

    public int ID { get; private set; }

    [field: SerializeField]

    public Vector2 Size { get; private set; } = Vector2.zero;

    [field: SerializeField]

    public int Mana_Cost { get; private set; }

    [field: SerializeField]

    public int Wood_Cost { get; private set; }

    [field: SerializeField]

    public int Steel_Cost { get; private set; }

    [field: SerializeField]

    public GameObject Prefab { get; private set; }
}
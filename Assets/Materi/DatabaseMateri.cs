using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DatabaseMateri : ScriptableObject
{
    public MateriMateri[] materi;

    public int materiCount
    {
        get
            {
            return materi.Length;
        }
    }

    public MateriMateri GetMateri(int index)
    {
        return materi[index];
    }
}

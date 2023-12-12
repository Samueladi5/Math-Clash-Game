using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MateriManagement : MonoBehaviour
{
    public DatabaseMateri MateriDB;

    public Text Halaman;
    public Text Materi2;

    private int pilihan;

    void Start()
    {
        UpdateMateri(pilihan);
    }

    public void NextOpt()
    {
        pilihan++;

        if(pilihan >= MateriDB.materiCount)
        {
            pilihan = 0;

        }
        UpdateMateri(pilihan);
    }

    public void BackOpt()
    {
        pilihan--;
        if(pilihan < 0)
        {
            pilihan = MateriDB.materiCount - 1;
        }
        UpdateMateri(pilihan);
    }

    private void UpdateMateri(int pilihan)
    {
        MateriMateri materi = MateriDB.GetMateri(pilihan);
        Halaman.text = materi.Page;
        //Materi2.text = materi.Materi;
        Materi2.text = materi.Materi.Replace("\\n", "\n");
    }
}

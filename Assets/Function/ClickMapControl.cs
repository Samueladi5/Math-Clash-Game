using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickMapControl : MonoBehaviour
{
    public TextMeshProUGUI keteranganText;

    private void OnMouseDown()
    {
        // Aktifkan teks keterangan
        keteranganText.gameObject.SetActive(true);

        // Tambahkan kode lain yang ingin Anda eksekusi saat sprite diklik
        // Misalnya, mengubah sprite atau melakukan tindakan lainnya
    }

    private void OnMouseUp()
    {
        // Nonaktifkan teks keterangan
        keteranganText.gameObject.SetActive(false);

        // Tambahkan kode lain yang ingin Anda eksekusi saat klik dihentikan
    }
}

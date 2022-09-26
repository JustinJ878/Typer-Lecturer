using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsGenerator : MonoBehaviour
{
    private static string[] ListWords = { "investasi", "administrasi", "akuntansi", "pembukuan", "anggaran", "modal", "kredit", "piutang",
                                            "pengeluaran", "beban", "laba", "pendapatan", "faktur", "asuransi", "saham", "pajak"};

    public static string RandomWord ()
    {
        int randomIndex = Random.Range(0, ListWords.Length);
        string random = ListWords[randomIndex];

        return random;
    }
}

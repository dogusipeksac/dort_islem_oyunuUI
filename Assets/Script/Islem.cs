using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Islem : MonoBehaviour {
    public UnityEngine.UI.Text ilkSayi,ikinciSayi,islem,cevap,sonuc;
    public UnityEngine.UI.InputField sonucField;
    int sayi1, sayi2,islemisareti,islemSonuc;
	// Use this for initialization
	void Start () {
        yeniSoru();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
  
    public void yeniSoru()
    {
        sonuc.text = "";
        sonucField.text = "";
        sayi1 = Random.Range(1, 100);
        sayi2 = Random.Range(1, 100);
        islemisareti = Random.Range(1, 4);
        switch (islemisareti)
        {
            case 1:
                islem.text = "+";
                islemSonuc = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonuc = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "/";
                islemSonuc = sayi1 / sayi2;
                break;
            case 4:
                islem.text = "*";
                islemSonuc = sayi1 * sayi2;
                break;
        }

        ilkSayi.text = "" + sayi1;
        ikinciSayi.text = "" + sayi2;
    }
    public void cevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonuc)
        {
            sonuc.text = "TEBRIKLER DOGRU";
        }
        else
        {
            sonuc.text = "MALESEF YANLIS";
        }
    }
}

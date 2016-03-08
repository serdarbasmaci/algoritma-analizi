using System;
using System.Collections;

class MainClass {
  public static int binarySearch(int[] liste, int eleman) {
    int baslangic = 0;
    int bitis = liste.Length - 1;
    int sayac = 0;
	while (baslangic <= bitis) {
		sayac++;

		int orta = (baslangic + bitis) / 2;
		int ortanca_eleman = liste[orta];
		if (ortanca_eleman == eleman) {
			return sayac;
		}
		else if (ortanca_eleman > eleman) {
			bitis = orta - 1;
		}
		else {
			baslangic = orta + 1;
		}
	}
	return 0;
  }
  public static void Main (string[] args) {
    Random rnd = new Random();
    for (int kuvvet=0; kuvvet < 6; kuvvet++){
        int dizi_boyutu = (int)Math.Pow(10.0, kuvvet);
        int[] dizi = new int[dizi_boyutu];
        for (int i=0; i < dizi_boyutu; i++){
            dizi[i] = i+1;
        }
        
        int sayac = 0;
        for (int i=0; i < 100; i++) {
            int aranacak_eleman = rnd.Next(1, dizi_boyutu);
            sayac += binarySearch(dizi, aranacak_eleman);
        }
        Console.WriteLine(dizi_boyutu + " " + ((float)sayac / 100));
        
    }

  }
}
      
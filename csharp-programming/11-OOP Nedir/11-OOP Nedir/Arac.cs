using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP_Nedir
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakitTip;
        public int VitesTip;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        public Arac()
        { }

        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }

        public Arac(string _marka, string _model, int _modelyil)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyil;
        }

        public Arac(string _marka, string _model, int _modelyil, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyil;
            this.Km = _km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yil {2}", Marka, Model, ModelYil);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi");
            }
        }
    }
}

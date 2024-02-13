// Functions

function yasHesapla(dogumYili) {
  return 2023 - dogumYili;
}

let agetest = yasHesapla(2012);
let agesinan = yasHesapla(2010);
let ageuser = yasHesapla(2017);

console.log(agetest);
console.log(agesinan);
console.log(ageuser);

function EmekligeKacYilKaldi(dogumYili, isim) {
  let yas = yasHesapla(dogumYili);
  let emeklilik = 65 - yas;

  if (emeklilik > 0) {
    console.log(`${isim} emekli olmana ${emeklilik} yıl kaldı`);
  } else {
    console.log("Zaten emekli oldunuz");
  }
}

EmekligeKacYilKaldi(2012, "test");
EmekligeKacYilKaldi(2010, "sinan");
EmekligeKacYilKaldi(1950, "user");

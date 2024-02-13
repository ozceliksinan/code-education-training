// // Operatörler

// let val;
// const a=10;
// const b=5;
// const c=5;
// let   d=3;

// // 1- Aritmetik Operatörler

// val = a+b;
// val = a-b;
// val = a*b;
// val = a/b;
// val = a%b;
// val = d++;
// val = ++d;
// val = --d;
// val = d--;

// // 2- Atama Operatörleri

// val = a;
// val +=a; // val = val + a;
// val -=a; // val = val - a;
// val *=a; // val = val * a;
// val /=a; // val = val / a;
// val %=a; // val = val % a;

// // 3- Karşılaştırma Operatörleri

// val = a==b;
// val = b==c;
// val = b===c; // değer kontrolü & type
// val = 5 === '5';
// val = a!=b;
// val = a!==b;
// val = a > b;
// val = b < a;
// val = a >= b;
// val = 5 >= 5;
// val = a <= b;

// // 4- Mantıksal Operatörler

//    // && (And)
//    // true  && true  => true
//    // true  && false => false
//    // false && false => false

//    val=  (a>b) && (a>c)
//    val = (a>b) || (a<c)
//    val = !(a>b)

//    // || (Or)

//    // true  && true  => true
//    // true  && false => true
//    // false && false => false

//    // ! (Not)

//    // !true  => false
//    // !false => true

// console.log(val);
// console.log(typeof val);

// Demo : Operators

// 1 - Sinan ve User 'nın boy ve kg bilgilerini alın.
// 2 - Alınan bilgilere göre kilo indekslerini hesaplayınız.
//  ** Formül : Kişinin Kilosu / Boy Uzunluğunun Karesi
// 3 - Hesaplanan indeks bilgisine göre karşılaştırma yapınız.
// 4 - Aşağıdaki tabloya göre Sinan ve User hangi gruba giriyor.

// 0 - 18,4: Zayıf
// 18,5 - 24,9: Normal
// 25,0 - 29,9: Fazla Kilolu
// 30,0 - 34,9: Şişman (Obez)

let IndexSinan;
let IndexUser;

const kgSinan = 60;
const kgUser = 40;

const heigtSinan = 1.7;
const heigtUser = 1.5;

IndexUser = kgUser / (heigtUser * heigtUser);
IndexSinan = kgSinan / (heigtSinan * heigtSinan);

console.log(IndexUser.toFixed(2), IndexSinan.toFixed(3));

let UserHigherIndex = IndexUser > IndexSinan;
let SinanHigherIndex = IndexSinan > IndexUser;

console.log(
  "User'nın kilo indeksi Sinan'ın kilo indeksinden daha büyük : " + UserHigherIndex
);

console.log(
  "Sinan'ın kilo indeksi User'nın kilo indeksinden daha büyük : " + SinanHigherIndex
);

let UserZayif = IndexUser >= 0 && IndexUser <= 18.4;
let UserNormal = IndexUser >= 18.5 && IndexUser <= 24.9;
let UserKilolu = IndexUser >= 25 && IndexUser <= 29.9;
let UserSisman = IndexUser >= 30 && IndexUser <= 34.9;

console.log("User zayıf :" + UserZayif);
console.log("User'nın kilosu normal : " + UserNormal);
console.log("User kilolu mu : " + UserKilolu);
console.log("User şişman mı : " + UserSisman);
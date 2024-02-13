// String

var str1 = "Sinan";
var str2 = new String("Sinan");

console.log(str1);
console.log(typeof str1);
console.log(str2);
console.log(typeof str2);

if (str2 == "Sinan") {
  console.log("yes");
} else {
  console.log("no");
}

String.prototype.repeat = function (n) {
  return new Array(n + 1).join(this);
};

console.log("Sinan".repeat(4));

// Number
var num1 = 10;
var num2 = new Number(10);

// Boolean
var bool1 = true;
var bool2 = new Boolean(true);

// Object
var obj1 = {
  name: "Sinan",
};

var obj2 = new Object({
  name: "Sinan",
});

// Array
var arr1 = ["user", "sinan", "test", "sample"];
var arr2 = new Array("user", "sinan", "test", "sample");

Array.prototype.remove =
  Array.prototype.remove ||
  function (member) {
    var index = this.indexOf(member);
    if (index > -1) {
      this.splice(index, 1);
    }
    return this;
  };

console.log(arr1.remove("test"));
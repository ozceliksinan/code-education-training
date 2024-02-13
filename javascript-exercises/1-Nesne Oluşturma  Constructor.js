let sinan = {
  name: "sinan",
  yearOfBirth: 2010,
  job: "student",
};

function Person(name, yearOfBirth, job) {
  this.name = name;
  this.yearOfBirth = yearOfBirth;
  this.job = job;
  this.calculateAge = function () {
    return 2018 - this.yearOfBirth;
  };
}

let Person = function (name, yearOfBirth, job) {
  this.name = name;
  this.yearOfBirth = yearOfBirth;
  this.job = job;
  this.calculateAge = function () {
    return 2018 - this.yearOfBirth;
  };
};

let test = new Person("test", 2010, "student");
let user = new Person("user", 1989, "teacher");

console.log(test.name);
console.log(test.yearOfBirth);
console.log(test.job);
console.log(test.calculateAge());

console.log("***************");

console.log(user.name);
console.log(user.yearOfBirth);
console.log(user.job);
console.log(user.calculateAge());
//Object.create

let personProto = {
  calculateAge: function () {
    return 2018 - this.yearOfBirth;
  },
};

let sinan = Object.create(personProto);

sinan.name = "sinan";
sinan.yearOfBirth = 2010;
sinan.job = "student";

let user = Object.create(personProto, {
  name: { value: "user" },
  yearOfBirth: { value: 1989 },
  job: { value: "teacher" },
});

console.log(user);
console.log(user.calculateAge());

console.log(sinan);
console.log(sinan.calculateAge());
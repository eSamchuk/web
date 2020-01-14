/*
let author = "Arthur Conan Doyle";
let name = "Sharlock Holmes";
let myVar = `My favorite book is ${name} by ${author}`;
*/


var num1 = 42.01;
let num2 = 23;

var arr = [];

for (let index = 0; index < 5; index++) 
{
   arr.push(index * 2 + 1);
}

console.log(arr.some(function (i) { return i > 3 }));
console.log(arr);


// const c = 3;
// console.log(c);

// console.log(num1 + num2);
// console.log(num1 - num2);
// console.log(num1 * num2);
// console.log(num1 / num2);
// console.log(num1 % num2);
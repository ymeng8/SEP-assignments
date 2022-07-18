// problem 1
let salaries = {John: 100, Ann: 160, Pete: 130};
let salarySum = salaries.John + salaries.Ann + salaries.Pete;
console.log(salarySum);

// problem 2
function multiplyNumeric(obj) {
    for (const prop in obj) {
        if (typeof obj[prop] == 'number') {
            obj[prop] *= 2;
        }
    }
}
let menu = {width: 200, height: 300, title: "My menu"};
multiplyNumeric(menu);
console.log(menu);

// problem 3
function checkEmailId(str) {
    const regex = /.+@.+\./i;
    return regex.test(str);
}
console.log(checkEmailId("123@abc.com"))

// problem 4
function truncate(str, maxLength) {
    if (str.length > maxLength) {
        return str.slice(0, maxLength)+"..."
    }
    return str;
}
const s = "What I'd like to tell on this topic is:";
const s2 = "Hi everyone!";
console.log(truncate(s,20));
console.log(truncate(s2,20));

// problem 5
let arr = ["James", "Brennie"];
console.log(arr);
arr.push("Robert");
console.log(arr);
arr[Math.floor(arr.length/2)] = "Calvin";
console.log(arr);
console.log(arr.shift());
console.log(arr);
arr.unshift("Rose","Regal");
console.log(arr);
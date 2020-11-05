class Student {
    studCode: number;
    studName: string;
}

let stud = new Student();
stud.studCode = 101;
stud.studName = "ramya p m";

console.log(stud.studCode + " " + stud.studName);  



class Student1{  
public studCode1: number;  
private studName1: string;  
constructor(code1: number, name1: string){  
this.studCode1 = code;  
this.studName1 = name;  
}  
public display() {  
return (`My unique code: ${this.studCode1}, my name: ${this.studName1}.`);  
}  
}  
  
let student1: Student1 = new Student(1, "Ramya");  
console.log(student1.display());  



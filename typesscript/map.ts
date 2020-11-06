let m = new Map();  
  
m.set('1', 'ram');     
m.set(1, 'www.javatpoint.com');       
m.set(true, 'bool1');   
m.set('2', 'ramya');  
  
console.log( "Value1= " +m.get(1)   );   
console.log("Value2= " + m.get('1') );   
console.log( "Key is Present= " +m.has(3) );   
console.log( "Size= " +m.size );   
console.log( "Delete value= " +m.delete(1) );   
console.log( "New Size= " +m.size );
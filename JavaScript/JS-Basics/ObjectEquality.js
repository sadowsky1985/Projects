
let address1 = new Address('Mora d´Ebre 29', 'Barcelona', '08023');
let address2 = new Address('Mora d´Ebre 29', 'Barcelona', '08023');

// Constructor Function
function Address(street, city, zipCode){
    this.Address = street;
    this.city = city;
    this.zipCode = zipCode;
}

function areEqual(address1, address2){
    return address1.Address === address2.Address &&
        address1.city === address2.city &&
        address1.zipCode === address2.zipCode;
}
      
function areSame(address1, address2){
    return address1 === address2;
}

console.log(areEqual(address1, address2));
console.log(areSame(address1, address2));
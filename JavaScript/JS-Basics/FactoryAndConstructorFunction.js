
let address = new Address('Mora d´Ebre 29', 'Barcelona', '08023');

console.log(address);

// Factory Function
function createAddress(street, city, zipCode){
    return {
        street,
        city,
        zipCode
    };
}

// Constructor Function
function Address(street, city, zipCode){
    this.Address = street;
    this.city = city;
    this.zipCode = zipCode;
}
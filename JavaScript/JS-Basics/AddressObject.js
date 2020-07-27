
const myDirection = {
    street: 'Mora d´Ebre 29',
    city: 'Barcelona',
    zipCode: '08023'
};

function showAddress(address){
    for (key in myDirection)
    console.log(key, ': ', myDirection[key]);
};

showAddress(myDirection);
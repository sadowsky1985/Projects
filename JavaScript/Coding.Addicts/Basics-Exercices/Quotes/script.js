
const quotes = [
{
    name: 'Stephen King',
    quote: 'Get busy living or get busy dying.'
},
{
    name: 'John F. Kennedy',
    quote: 'Those who believed in me and I didn´t have the heart to let him down.'
},
{
    name: 'Leonardo Da Vinci',
    quote: 'It had long since come to my attention that people of accomplishment rarely sat nack and let thing happen to them. They went out and happened to things.'
},
{
    name: 'Leo Tolstoy',
    quote: 'If you want to be happy, be.'
},
{
    name: 'Nelson Mandela',
    quote: 'The greatest glory in living lies not in never falling, but in rising every time we fall.'
},
{
    name: 'John Lennon',
    quote: "Life is what happens when you're busy making other plans."
},
{ 
    name: 'Confucius',
    quote: "Life is really simple, but we insist on making it complicated." 
}
];

const quoteBtn = document.querySelector('#quoteBtn');
const quoteAuthor = document.querySelector('#quoteAuthor');
const quote = document.querySelector('#quote');

quoteBtn.addEventListener('click', displayQuote);

function displayQuote() {
    let number = Math.floor(Math.random()*quotes.length);
    quoteAuthor.innerHTML = quotes[number].name;
    quote.innerHTML = quotes[number].quote;
}
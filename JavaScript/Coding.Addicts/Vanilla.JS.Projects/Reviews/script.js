// local reviews data
const reviews = [
    {
        id: 1,
        name: "susan smith",
        job: 'web developer',
        img: 
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQEEBct97_UUQKZBzPkQWCepi4x0byjYAyDng&usqp=CAU",
        text: 
        'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum tempor felis eu dapibus. Pellentesque lacinia urna nec erat ornare, ut ultricies turpis tempor. Sed malesuada massa et varius dapibus. Class aptent taciti sociosqu ad litora.'
    },
    {
        id: 2,
        name: "anna johnson",
        job: 'web designer',
        img: 
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRwou-LOIlgzLb2Zjs3LPdjcVbUY8dqjjcsrA&usqp=CAU",
        text: 
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus dictum lacus sapien, ultricies dictum diam elementum fringilla. Donec luctus varius justo, tincidunt aliquam nunc sodales sed. Proin.",
    },
    {
        id: 3,
        name: "peter jones",
        job: 'intern',
        img: 
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTXaqWVMUSyeendpPUCb_C1GqIAhPM5CiUU1w&usqp=CAU",
        text: 
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus varius justo, tincidunt aliquam nunc sodales sed. Proin.",
    },
    {
        id: 4,
        name: "bill anderson",
        job: 'the boss',
        img: 
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTWHhrOKG4QwpXs_qReauJ7wGki63nRSG-XIg&usqp=CAU",
        text: 
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus varius justo, tincidunt aliquam nunc sodales sed. Proin, consectetur adipiscing elit. Phasellus dictum lacus sapien.",
    },
];

// select items
const img = document.getElementById('person-img');
const author = document.getElementById('author');
const job = document.getElementById('job');
const info = document.getElementById('info');

const prevBtn = document.querySelector('.prev-btn');
const nextBtn = document.querySelector('.next-btn');
const randomBtn = document.querySelector('.random-btn');

// set starting items
let currentItem = 0;

// load initial item
window.addEventListener('DOMContentLoaded', function () {
    showPerson();
});
// random number
function getRandomNum() {
    currentItem = Math.floor(Math.random()*reviews.length)
}

// show person based on item
function showPerson() {
    const item = reviews[currentItem];
    img.src = item.img;
    author.textContent = item.name;
    job.textContent = item.job;
    info.textContent = item.text;
}

// show next person
nextBtn.addEventListener('click', function(){
    currentItem++;
    if (currentItem > reviews.length - 1) {
        currentItem = 0;
    }
    showPerson();
});

// show prev person
prevBtn.addEventListener('click', function(){
    currentItem--;
    if (currentItem < 0) {
        currentItem = reviews.length - 1;
    }
    showPerson();
});

// show random person
randomBtn.addEventListener('click', function(){
    getRandomNum();
    showPerson();   
})

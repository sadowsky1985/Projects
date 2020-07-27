
// let counter = document.querySelector('.count');
// let btnDecrease = document.querySelector('.btn-dec');
// let btnReset = document.querySelector('.btn-rst');
// let btnIncrease = document.querySelector('.btn-inc');

// let count = 0;

// btnDecrease.addEventListener('click', decreaseCounter);
// btnReset.addEventListener('click', resetCounter);
// btnIncrease.addEventListener('click', incrementCounter);

// function decreaseCounter() {
//     count--;
//     counter.innerHTML = count;
//     if (counter.innerHTML<'0') {
//         counter.style.color = 'red';
//     }
//     else if (counter.innerHTML === '0') {
//         counter.style.color = 'black';
//     }
// }
// function resetCounter() {
//     count = 0;
//     counter.innerHTML = count;
//     counter.style.color = 'black';
// }

// function incrementCounter() {
//     count++;
//     counter.innerHTML = count;
//     if (counter.innerHTML>'0') {
//         counter.style.color = 'green';
//     }
//     else if (counter.innerHTML === '0') {
//         counter.style.color = 'black';
//     }
// }

let count = 0;
let value = document.querySelector('.count');
let btns = document.querySelectorAll('.btn');

btns.forEach(function(btn) {
    btn.addEventListener('click' ,function(e){
        const styles = e.currentTarget.classList;
        if(styles.contains('btn-dec')) {
            count--;
        }
        else if (styles.contains('btn-inc')) {
            count++;
        }
        else {
            count = 0;
        }
        if (count<0){
            value.style.color = 'red';
        }
        else if (count>0) {
            value.style.color = 'green';
        }
        else if (count == 0) {
            value.style.color = 'black';
        }
        value.textContent = count;
        animate();
    });
});

function animate () {
    value.animate([{opacity: '0.4'}, {opacity: '1.0'}],{duration: 500, fill: "forwards"});
}
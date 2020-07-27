const colortBtn = document.querySelector('.color-btn');
const bodyBackground = document.querySelector('body');

const colors = ['yellow', 'red', 'green', '#3b5998'];

colortBtn.addEventListener('click', changeColor);

function changeColor() {
    let random = Math.floor(Math.random()*colors.length)
    bodyBackground.style.backgroundColor = colors[random];
}
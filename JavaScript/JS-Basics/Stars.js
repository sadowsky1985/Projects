
showStars(5);

function showStars(rows){
    for (let row=1; row<=rows; row++){
        let msg = '';
        for (let i=0; i<row; i++)
            msg += '*';
        console.log(msg);
    }
}
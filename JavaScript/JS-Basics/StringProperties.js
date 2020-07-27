
const movie = {
    title: 'Avatar',
    releaseYear: 2009,
    rating: 4.5,
    director: 'James Cameron'
};

showProperties(movie);

function showProperties(obj) {
    for (key in obj)
        if (typeof(obj[key]) === 'string')
            console.log(key, obj[key])
}
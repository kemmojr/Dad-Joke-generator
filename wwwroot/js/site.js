// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById('getDadJoke').addEventListener('click', getDadJoke);

async function getDadJoke() {
    document.getElementById('currentDadJoke').innerText = 'loading...';

    const response = await fetch('api/Joke');
    const joke = await response.json();

    document.getElementById('currentDadJoke').innerText = joke.joke;
}

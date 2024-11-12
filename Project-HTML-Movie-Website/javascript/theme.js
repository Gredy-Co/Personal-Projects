const btnSwitch = document.querySelector('#switch');

btnSwitch.addEventListener('click', () => {
    // Alternar la clase 'dark' en el body
    document.body.classList.toggle('dark');

    // Alternar la clase 'active' en el botón switch
    btnSwitch.classList.toggle('active');
});

document.addEventListener('DOMContentLoaded', () => {
    const userButton = document.getElementById('userButton');

    userButton.addEventListener('click', () => {
        const confirmation = confirm('¿Deseas cerrar sesión?');
        if (confirmation) {
            // Eliminar la información del localStorage
            localStorage.setItem('isLogged', 'false');

            // Redirigir a la página de login
            window.location.href = 'login.html'; // Asegúrate de tener una página de login o una página adecuada para redirigir
        }
    });
    const user = JSON.parse(localStorage.getItem('user'));
    
    // Comprobar si el usuario está logueado y si existe el nombre en el localStorage
    if (user && user.username) {
        // Seleccionar el elemento donde se mostrará el nombre del usuario
        const userNameElement = document.getElementById('userName');
        
        // Establecer el nombre del usuario en el elemento
        userNameElement.textContent = user.username;
    }
    
});



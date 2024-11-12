document.addEventListener('DOMContentLoaded', () => {
    // Variables
    const loginForm = document.getElementById('loginForm');
    const loginMessage = document.getElementById('loginMessage');
    const usernameField = document.getElementById('username');
    const passwordField = document.getElementById('password');

    // Verificar si el usuario ya está logueado
    if (localStorage.getItem('isLogged') === 'true') {
        window.location.href = 'index.html';
    }

    // Funciones
    const getStoredUser = () => {
        const user = localStorage.getItem('user');
        return user ? JSON.parse(user) : null;
    };

    const validateCredentials = (username, password, userObject) => {
        return userObject && username === userObject.username && password === userObject.password;
    };

    const showErrorMessage = (message) => {
        loginMessage.textContent = message;
        loginMessage.style.color = 'black'; // Cambiar color del mensaje a rojo
    };

    const clearErrorMessage = () => {
        loginMessage.textContent = '';
    };

    const handleLogin = (event) => {
        event.preventDefault();

        const username = usernameField.value;
        const password = passwordField.value;
        const userObject = getStoredUser();

        console.log('Stored User:', userObject); // Debug: Verifica los datos almacenados
        console.log('Entered Username:', username); // Debug: Verifica el nombre de usuario ingresado
        console.log('Entered Password:', password); // Debug: Verifica la contraseña ingresada

        if (!userObject) {
            showErrorMessage('No user found. Please register first.');
        } else if (username === '' || password === '') {
            showErrorMessage('Username and password cannot be empty.');
        } else if (!validateCredentials(username, password, userObject)) {
            showErrorMessage('Invalid username or password');
            usernameField.value = '';
            passwordField.value = '';
        } else {
            localStorage.setItem('isLogged', 'true');
            console.log('Login successful, redirecting...');
            window.location.href = 'index.html'; // Redirigir a la página principal
        }
    };

    // Listeners
    loginForm.addEventListener('submit', handleLogin);

    usernameField.addEventListener('input', clearErrorMessage);
    passwordField.addEventListener('input', clearErrorMessage);
});

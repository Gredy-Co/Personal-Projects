document.querySelectorAll('.translate-btn').forEach(button => {
    button.addEventListener('click', () => {
        currentLang = button.getAttribute('data-lang');
        localStorage.setItem('selectedLanguage', currentLang); // Almacena en localStorage
        initializePage(); // Vuelve a cargar la página o renderiza los resultados con el nuevo idioma.
    });
});

// Al cargar la página, verifica si hay un idioma seleccionado previamente.
document.addEventListener('DOMContentLoaded', () => {
    const storedLang = localStorage.getItem('selectedLanguage');
    if (storedLang) {
        currentLang = storedLang;
    }
    // Tu código de inicialización de la página
    initializePage();
});

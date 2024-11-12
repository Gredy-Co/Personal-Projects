let translations = {};

// Cargar las traducciones desde el archivo JSON
fetch('../json/translations-main.json')
    .then(response => response.json())
    .then(data => {
        translations = data;

        // Traducir la página según el idioma guardado en localStorage
        const savedLanguage = localStorage.getItem('selectedLanguage') || 'en';
        translate(savedLanguage);
    })
    .catch(error => console.error('Error loading translations:', error));

// Función para traducir el contenido de la página y ajustar la dirección del texto
function translate(lang) {
    document.querySelectorAll('[data-key]').forEach(element => {
        const key = element.getAttribute('data-key');
        if (translations[lang] && translations[lang][key]) {
            element.innerHTML = translations[lang][key];  // Usa innerHTML en lugar de textContent si hay HTML dentro del texto
        }
    });

    // Ajustar la dirección del texto según el idioma
    document.documentElement.setAttribute('dir', lang === 'ar' ? 'rtl' : 'ltr');
}

// Añadir event listeners a los botones de traducción
document.querySelectorAll('.translate-btn').forEach(button => {
    button.addEventListener('click', () => {
        const lang = button.getAttribute('data-lang');
        localStorage.setItem('selectedLanguage', lang);  // Guardar el idioma seleccionado en localStorage
        translate(lang);
    });
});

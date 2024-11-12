let translations = {};

// Cargar las traducciones desde el archivo JSON
fetch('../json/translations-about-us.json')
    .then(response => response.json())
    .then(data => {
        translations = data;
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
        translate(lang);
    });
});

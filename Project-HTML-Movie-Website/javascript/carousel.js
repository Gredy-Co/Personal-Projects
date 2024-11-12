$(document).ready(function(){
    // Inicializa el carrusel con la configuración predeterminada
    initializeCarousel(true); // Inicializar con RTL como true por defecto

    // Añade el event listener a los botones de traducción
    document.querySelectorAll('.translate-btn').forEach(button => {
        button.addEventListener('click', function () {
            const lang = this.getAttribute('data-lang');
            localStorage.setItem('currentLanguage', lang);
            updateLanguage(); // Actualiza el contenido de la página al cambiar el idioma
            updateCarousel(lang); // Actualiza el carrusel según el idioma seleccionado
        });
    });

    // Actualiza la página y el carrusel al cargar la página
    const savedLanguage = localStorage.getItem('currentLanguage') || 'en';
    updateLanguage();
    updateCarousel(savedLanguage);
});

function initializeCarousel(isRtl) {
    $('.owl-carousel2').owlCarousel({
        loop: true,
        margin: 20,
        dots: true,
        items: 1,
        rtl: isRtl  // Configura RTL según el parámetro
    });
}

function updateCarousel(lang) {
    // Configura RTL en función del idioma seleccionado
    const isRtl = lang === 'ar';
    $('.owl-carousel2').trigger('destroy.owl.carousel'); // Destruye la instancia actual del carrusel
    initializeCarousel(isRtl); // Reinicializa el carrusel con la nueva configuración RTL
}

function updateLanguage() {
    let currentLanguage = localStorage.getItem('currentLanguage') || 'en';
    document.querySelectorAll('[data-en]').forEach(el => {
        if (currentLanguage === 'ar') {
            el.textContent = el.getAttribute('data-ar');
        } else {
            el.textContent = el.getAttribute('data-en');
        }
    });

    // Ajustar la dirección del texto según el idioma
    document.documentElement.setAttribute('dir', currentLanguage === 'ar' ? 'rtl' : 'ltr');
}

// Traduce el contenido de la página
fetch('../json/translations-main.json')
    .then(response => response.json())
    .then(data => {
        translations = data;
        const savedLanguage = localStorage.getItem('selectedLanguage') || 'en';
        translate(savedLanguage);
    })
    .catch(error => console.error('Error loading translations:', error));

// Función para traducir el contenido de la página
function translate(lang) {
    document.querySelectorAll('[data-key]').forEach(element => {
        const key = element.getAttribute('data-key');
        if (translations[lang] && translations[lang][key]) {
            element.innerHTML = translations[lang][key];
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

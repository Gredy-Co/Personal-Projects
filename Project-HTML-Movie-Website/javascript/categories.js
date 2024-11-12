document.addEventListener('DOMContentLoaded', function () {
    fetch('../json/info_categories.json')
        .then(response => response.json())
        .then(data => {
            window.posts = data; 
            initializePage();  // Inicia la página con el contenido adecuado
            initializeTranslationButtons(); // Configura los botones de traducción
        })
        .catch(error => console.error('Error loading JSON:', error));
});

// Recuperar el idioma del almacenamiento local o usar 'en' como predeterminado
let currentLanguage = localStorage.getItem('currentLanguage') || 'en';

function initializePage() {
    document.querySelectorAll('.dropdown__link').forEach(link => {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            const category = this.textContent.trim().toLowerCase();
            loadCategoryContent(category);
        });
    });

    document.querySelectorAll('.new-release__btn').forEach(button => {
        button.addEventListener('click', function (e) {
            e.preventDefault();
            const category = this.getAttribute('data-category');
            const title = this.getAttribute('data-title');
            history.pushState(null, '', `?category=${category}&title=${encodeURIComponent(title)}`);
            loadMovieDetails(category, title);
        });
    });

    const params = new URLSearchParams(window.location.search);
    const category = params.get('category');
    const title = params.get('title');

    if (category && title) {
        loadMovieDetails(category, decodeURIComponent(title));
    } else if (category) {
        loadCategoryContent(category);
    } else {
        updateContentForLanguage(); // Asegura que se carga el contenido correcto según el idioma
    }
}

function loadCategoryContent(category) {
    console.log("Categoría seleccionada:", category); // Agrega esto para depurar
    const categoryPosts = posts[category];
    if (categoryPosts) {
        const main = document.querySelector('main');
        main.classList.add('movies-grid');
        main.innerHTML = `
            <div class="hero" style="background-image: url('../images/fondo_${category.toLowerCase()}.jpg'); height: 80vh;">
                <h1 class="hero__title">${capitalizeFirstLetter(category)}</h1>
            </div>
            <section class="genre">
                <h2 class="genre__title">${currentLanguage === 'en' ? 'Browse Movies' : 'تصفح الأفلام'}</h2>
                <div class="movies">
                    ${categoryPosts.map(post => createPostHTML(post, category)).join('')}
                </div>
            </section>
        `;
    }
}

function createPostHTML(post, category) {
    const currentLanguage = localStorage.getItem('currentLanguage') || 'en';
    const title = post[`title_${currentLanguage}`] || post.title[currentLanguage] || post.title;
    const author = post[`author_${currentLanguage}`] || post.author;
    const date = post[`date_${currentLanguage}`] || post.date;
    const description = post[`description_${currentLanguage}`] || post.description;

    return `
        <div class="movies__movie">
            <a href="?category=${encodeURIComponent(category)}&title=${encodeURIComponent(title)}">
                <img src="${post.image}" alt="${title}" class="movies__movie__img">
                <h3 class="movies__movie__title">${title}</h3>
                <p class="movies__movie__author">Director: ${author}</p>
                <p class="movies__movie__date">${date}</p>
                <p class="movies__movie__description">${description}</p>
            </a>
        </div>
    `;
}

document.addEventListener('click', function(e) {
    if (e.target.matches('.movie-detail-link, .movie-detail-link *')) { 
        e.preventDefault();
        const link = e.target.closest('.movie-detail-link');
        const category = link.getAttribute('data-category');
        const title = link.getAttribute('data-title');
        loadMovieDetails(category, title);
    }
});

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function initializeTranslationButtons() {
    document.querySelectorAll('.translate-btn').forEach(button => {
        button.addEventListener('click', function () {
            currentLanguage = this.getAttribute('data-lang');
            localStorage.setItem('currentLanguage', currentLanguage); 
            location.reload(); 
        });
    });
}

function updateContentForLanguage() {
    const params = new URLSearchParams(window.location.search);
    const category = params.get('category');
    if (category) {
        loadCategoryContent(category);
    } 
}

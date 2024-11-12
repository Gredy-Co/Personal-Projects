function loadMovieDetails(category, title) {
    const currentLanguage = localStorage.getItem('currentLanguage') || 'en';
    const categoryPosts = window.posts[category];
    const movie = categoryPosts.find(post => post[`title_${currentLanguage}`] === title || post.title === title);

    if (movie) {
        const title = movie[`title_${currentLanguage}`] || movie.title;
        const author = movie[`author_${currentLanguage}`] || movie.author;
        const date = movie[`date_${currentLanguage}`] || movie.date;
        const description = movie[`description_${currentLanguage}`] || movie.description;

        const main = document.querySelector('main');
        main.innerHTML = `
            <div class="hero" style="background-image: url('${movie.image}'); height: 80vh;">
                <h1 class="hero__title">${title}</h1>
            </div>
            <div class="hero-container">
                <div class="hero-container__background">
                    <img src="${movie.image}" alt="${title}">
                </div>
                <div class="hero-container__content">
                    <div class="hero-container__video">
                        <iframe style="width: 100%; border: none;" height="500" src="${movie.trailer}" title="${title} Trailer" allowfullscreen></iframe>
                    </div>
                    <div class="movie-card">
                        <a href="#" class="movie-card__link">
                            <img src="${movie.image}" alt="${title}" class="movie-card__img">
                            <h3 class="movie-card__title">${title}</h3>
                            <p class="movie-card__author">Director: ${author}</p>
                            <p class="movie-card__date">${date}</p>
                            <p class="movie-card__description">${description}</p>
                        </a>
                    </div>
                    <div class="movie-summary-background">
                        <div class="movie-summary">
                            <h3 class="movie-summary__title">Summary</h3>
                            <p class="movie-summary__text">${description}</p>
                            <div class="post-details__rating">
                                <input type="radio" id="star5" name="rating" value="5" class="post-details__star"><label for="star5">&#9733;</label>
                                <input type="radio" id="star4" name="rating" value="4" class="post-details__star"><label for="star4">&#9733;</label>
                                <input type="radio" id="star3" name="rating" value="3" class="post-details__star"><label for="star3">&#9733;</label>
                                <input type="radio" id="star2" name="rating" value="2" class="post-details__star"><label for="star2">&#9733;</label>
                                <input type="radio" id="star1" name="rating" value="1" class="post-details__star"><label for="star1">&#9733;</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        `;

        // Ajuste de la calificación con estrellas
        const stars = document.querySelectorAll('.post-details__star');
        const storedRating = localStorage.getItem(`rating-${movie.title_en || movie.title}`);

        if (storedRating) {
            document.querySelector(`#star${storedRating}`).checked = true;
        }

        stars.forEach(star => {
            star.addEventListener('change', function () {
                localStorage.setItem(`rating-${movie.title_en || movie.title}`, this.value);
            });
        });
    }
}

// Escucha los cambios de estado para cargar detalles de la película
window.addEventListener('popstate', function () {
    const params = new URLSearchParams(window.location.search);
    const category = params.get('category');
    const title = decodeURIComponent(params.get('title'));

    if (category && title) {
        loadMovieDetails(category, title);
    }
});

document.addEventListener('DOMContentLoaded', function () {
    fetch('../json/info_categories.json')
        .then(response => response.json())
        .then(data => {
            window.posts = data;
            initializePage();
        })
        .catch(error => console.error('Error loading JSON:', error));
});

function initializePage() {
    setupSearch();
}

function setupSearch() {
    const params = new URLSearchParams(window.location.search);
    const query = params.get('query');

    if (query) {
        searchMovies(query);
    }
}

function searchMovies(query) {
    const results = {
        categories: [],
        movies: []
    };

    for (const [category, posts] of Object.entries(window.posts)) {
        if (category.toLowerCase().includes(query.toLowerCase())) {
            results.categories.push(category);
        }

        const filteredPosts = posts.filter(post => post.title.toLowerCase().includes(query.toLowerCase()));
        if (filteredPosts.length > 0) {
            results.movies.push({ category, posts: filteredPosts });
        }
    }

    displaySearchResults(results);
}

function displaySearchResults(results) {
    const searchResultsContainer = document.getElementById('search-results');
    if (!searchResultsContainer) return;

    searchResultsContainer.innerHTML = '';

    if (results.movies.length > 0) {
        const moviesHTML = results.movies.map(({ category, posts }) => `
            <section class="genre">
                <h2 class="genre__title">${capitalizeFirstLetter(category)}</h2>
                <div class="movies">
                    ${posts.map(post => createPostHTML(post, category)).join('')}
                </div>
            </section>
        `).join('');
        searchResultsContainer.innerHTML += moviesHTML;
    } else {
        searchResultsContainer.innerHTML = '<p>No results found</p>';
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
                <p class="movies__movie__author">author: ${author}</p>
                <p class="movies__movie__date">${date}</p>
                <p class="movies__movie__description">${description}</p>
            </a>
        </div>
    `;
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function handleMovieClick(category, title) {
    const url = new URL(window.location);
    url.searchParams.set('category', category);
    url.searchParams.set('title', title);
    window.history.pushState({}, '', url);

    loadMovieDetails(category, decodeURIComponent(title));
}


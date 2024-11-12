
// Al darle click en el botón de "Search" en el menú se ejecuta esta función para la búsqueda de la película

document.addEventListener('DOMContentLoaded', function () {
    const searchButton = document.getElementById('search-button');
    const searchInput = document.getElementById('search-input');

    if (searchButton && searchInput) {
        searchButton.addEventListener('click', function () {
            const query = searchInput.value.trim().toLowerCase();
            if (query) {
                window.location.href = `search.html?query=${encodeURIComponent(query)}`;
            }
        });
    }
});
